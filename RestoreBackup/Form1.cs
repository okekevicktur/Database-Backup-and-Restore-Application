using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace RestoreBackup
{
    public partial class Form1 : Form
    {
        //Connection String
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\piedtech\documents\visual studio 2013\Projects\RestoreBackup\RestoreBackup\Database1.mdf");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

        //Database path
        string dbname = System.Windows.Forms.Application.StartupPath + "\\Database1.mdf";

        public Form1()
        {
            InitializeComponent();
        }

        public void loadcombo()
        {
            InitConnection();

            string ldcom = "Select * from Employee";
            SqlDataAdapter sda = new SqlDataAdapter(ldcom, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            comboBox1.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["Name"].ToString());
            }
        }

        public void InitConnection()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error: "+ e.Message);
            }
          
        }

        public void BackupPlug()
        {

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string cmd = "BACKUP DATABASE [" + dbname + "] TO DISK='" + backuppathCore + "\\" + "PMdbBkup.bak' ";
            using (SqlCommand command = new SqlCommand(cmd, con))
            {


                command.ExecuteNonQuery();

                MessageBox.Show("Database backup done successfully");


                con.Close();
                // btnBackup.Enabled = false;
            }
        }

        public void restorePlug()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string restQuery = "ALTER DATABASE [" + dbname + "] SET OFFLINE WITH ROLLBACK IMMEDIATE USE master RESTORE DATABASE [" + dbname + "] FROM DISK='" + backUpfile + "'  WITH REPLACE ALTER DATABASE  [" + dbname + "] SET ONLINE ";
            using (SqlCommand cmdRestore = new SqlCommand(restQuery, con))
            {
                cmdRestore.ExecuteNonQuery();
                MessageBox.Show("Restored Succesfully");
            }

            con.Close();
            loadcombo();

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            InitConnection();
            loadcombo();
        }


        #region  Main Event Handlers
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtBackupFileLoc.Text = dlg.SelectedPath;
                btnBackup.Enabled = true;
            }
        }

        string backuppathCore = @"c:\CoreBackupPM";
        string backUpfile = @"c:\CoreBackupPM\PMdbBkup.bak";


        private void btnBackup_Click(object sender, EventArgs e)
        {
            
            try
            {
                #region Default Location Backup
                if (defaultStorageLocation.Checked)
                {                   
                    string backUpfile = @"c:\CoreBackupPM\PMdbBkup.bak";

                    if (!System.IO.Directory.Exists(backuppathCore))
                    {
                        System.IO.Directory.CreateDirectory(backuppathCore);
                      //  MessageBox.Show("Core Backup Folder Created");
                    }
                    else
                    {
                        if (System.IO.File.Exists(backUpfile))
                        {
                            System.IO.File.Delete(backUpfile);
                            MessageBox.Show("Backup file Deleted");

                        }
                    }
                    BackupPlug();
                }
                    #endregion
                

                #region Custom Location Backup
                else if (customSToreLocation.Checked)
                {
                    MessageBox.Show("Custom");
                    if (txtBackupFileLoc.Text == string.Empty)
                    {
                        MessageBox.Show("Select a location to backup PayMag by Clicking the Browse Folder Button ");
                    }
                    else
                    {
                        string backUpfile = txtBackupFileLoc.Text + "\\" + "PMdbBkup.bak";

                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }

                        if (System.IO.File.Exists(backUpfile))
                        {
                            System.IO.File.Delete(backUpfile);
                            MessageBox.Show("Backup file Deleted");

                        }
                        string cmd = "BACKUP DATABASE [" + dbname + "] TO DISK='" + txtBackupFileLoc.Text + "\\" + "PMdbBkup.bak' ";
                        using (SqlCommand command = new SqlCommand(cmd, con))
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Database backup done successfully");
                            con.Close();
                            btnBackup.Enabled = false;
                        }
                    }
                }
               
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "SQL SERVER database bakup files|*.bak";
            opf.Title = "Database Restore";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = opf.FileName;
                btnRestore.Enabled = true;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {

                #region Default Restore Point Location
                if (defaultBackupLocation.Checked) 
                {
                  
                    if (!System.IO.Directory.Exists(backuppathCore))
                    {
                          MessageBox.Show("No Backup Exist, Try Backup PayMag");

                          return;
                        //  MessageBox.Show("Core Backup Folder Created");
                    }
                    else
                    {
                        if (System.IO.File.Exists(backUpfile))
                        {
                           
                            MessageBox.Show("Backup File Exist");

                        }
                    }
                    restorePlug();
                    
                }
                #endregion

                #region Custom Restore Point Location
                else if (CustomBackupLocation.Checked)
                {
                      if (!File.Exists(textBox2.Text))
                      {
                          MessageBox.Show("Can't find a backup file");
                      }
                      else
                      {
                          if (con.State != ConnectionState.Open)
                          {
                              con.Open();
                          }

                          string restQuery = "ALTER DATABASE [" + dbname + "] SET OFFLINE WITH ROLLBACK IMMEDIATE USE master RESTORE DATABASE [" + dbname + "] FROM DISK='" + textBox2.Text + "'  WITH REPLACE ALTER DATABASE  [" + dbname + "] SET ONLINE ";


                          using (SqlCommand cmdRestore = new SqlCommand(restQuery, con))
                          {
                              cmdRestore.ExecuteNonQuery();
                              MessageBox.Show("Restored Succesfully");

                          }

                      }
                      con.Close();
                      loadcombo();
                }
             
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }
        }
       
        private void split_Click(object sender, EventArgs e)
        {
            try
            {
                InitConnection();
                string insertQuery = "INSERT INTO Employee (Name) Values ('" + textBox1.Text + "')";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("ADDED");
                textBox1.Text = string.Empty;
                loadcombo();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }



        }

        private void defaultBackupLocation_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
            btnRestore.Enabled = true;


        }

        private void CustomBackupLocation_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            btnRestore.Enabled = false;
        }

        private void customSToreLocation_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            btnBackup.Enabled = false;
        }

        private void defaultStorageLocation_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            btnBackup.Enabled = true;

        }


        #endregion 

      
      
    }
}
