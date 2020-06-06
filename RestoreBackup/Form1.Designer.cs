namespace RestoreBackup
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtBackupFileLoc = new System.Windows.Forms.TextBox();
            this.customSToreLocation = new System.Windows.Forms.RadioButton();
            this.defaultStorageLocation = new System.Windows.Forms.RadioButton();
            this.split = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CustomBackupLocation = new System.Windows.Forms.RadioButton();
            this.defaultBackupLocation = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.customSToreLocation);
            this.groupBox1.Controls.Add(this.defaultStorageLocation);
            this.groupBox1.Controls.Add(this.btnBackup);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 146);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Backup";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBrowse);
            this.groupBox3.Controls.Add(this.txtBackupFileLoc);
            this.groupBox3.Location = new System.Drawing.Point(157, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 47);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(272, 16);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtBackupFileLoc
            // 
            this.txtBackupFileLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackupFileLoc.Location = new System.Drawing.Point(6, 15);
            this.txtBackupFileLoc.Name = "txtBackupFileLoc";
            this.txtBackupFileLoc.ReadOnly = true;
            this.txtBackupFileLoc.Size = new System.Drawing.Size(244, 21);
            this.txtBackupFileLoc.TabIndex = 1;
            // 
            // customSToreLocation
            // 
            this.customSToreLocation.AutoSize = true;
            this.customSToreLocation.Location = new System.Drawing.Point(9, 58);
            this.customSToreLocation.Name = "customSToreLocation";
            this.customSToreLocation.Size = new System.Drawing.Size(143, 17);
            this.customSToreLocation.TabIndex = 7;
            this.customSToreLocation.Text = "Choose Custom Location";
            this.customSToreLocation.UseVisualStyleBackColor = true;
            this.customSToreLocation.CheckedChanged += new System.EventHandler(this.customSToreLocation_CheckedChanged);
            // 
            // defaultStorageLocation
            // 
            this.defaultStorageLocation.AutoSize = true;
            this.defaultStorageLocation.Checked = true;
            this.defaultStorageLocation.Location = new System.Drawing.Point(10, 23);
            this.defaultStorageLocation.Name = "defaultStorageLocation";
            this.defaultStorageLocation.Size = new System.Drawing.Size(103, 17);
            this.defaultStorageLocation.TabIndex = 6;
            this.defaultStorageLocation.TabStop = true;
            this.defaultStorageLocation.Text = "Default Location";
            this.defaultStorageLocation.UseVisualStyleBackColor = true;
            this.defaultStorageLocation.CheckedChanged += new System.EventHandler(this.defaultStorageLocation_CheckedChanged);
            // 
            // split
            // 
            this.split.Location = new System.Drawing.Point(227, 335);
            this.split.Name = "split";
            this.split.Size = new System.Drawing.Size(72, 23);
            this.split.TabIndex = 5;
            this.split.Text = "Insert";
            this.split.UseVisualStyleBackColor = true;
            this.split.Click += new System.EventHandler(this.split_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(93, 337);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 21);
            this.textBox1.TabIndex = 4;
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(157, 108);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 23);
            this.btnBackup.TabIndex = 2;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CustomBackupLocation);
            this.groupBox2.Controls.Add(this.defaultBackupLocation);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.btnRestore);
            this.groupBox2.Location = new System.Drawing.Point(6, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 141);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Database Restore";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 371);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.Location = new System.Drawing.Point(272, 16);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse2.TabIndex = 4;
            this.btnBrowse2.Text = "Browse";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.btnBrowse2_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(158, 111);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 3;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(6, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(244, 21);
            this.textBox2.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.btnBrowse2);
            this.groupBox4.Location = new System.Drawing.Point(157, 43);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(353, 45);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Visible = false;
            // 
            // CustomBackupLocation
            // 
            this.CustomBackupLocation.AutoSize = true;
            this.CustomBackupLocation.Location = new System.Drawing.Point(10, 59);
            this.CustomBackupLocation.Name = "CustomBackupLocation";
            this.CustomBackupLocation.Size = new System.Drawing.Size(143, 17);
            this.CustomBackupLocation.TabIndex = 9;
            this.CustomBackupLocation.Text = "Choose Custom Location";
            this.CustomBackupLocation.UseVisualStyleBackColor = true;
            this.CustomBackupLocation.CheckedChanged += new System.EventHandler(this.CustomBackupLocation_CheckedChanged);
            // 
            // defaultBackupLocation
            // 
            this.defaultBackupLocation.AutoSize = true;
            this.defaultBackupLocation.Checked = true;
            this.defaultBackupLocation.Location = new System.Drawing.Point(10, 22);
            this.defaultBackupLocation.Name = "defaultBackupLocation";
            this.defaultBackupLocation.Size = new System.Drawing.Size(103, 17);
            this.defaultBackupLocation.TabIndex = 8;
            this.defaultBackupLocation.TabStop = true;
            this.defaultBackupLocation.Text = "Default Location";
            this.defaultBackupLocation.UseVisualStyleBackColor = true;
            this.defaultBackupLocation.CheckedChanged += new System.EventHandler(this.defaultBackupLocation_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ADD TEXT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "VIEW DATA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 406);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.split);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup/Restore";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button split;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.TextBox txtBackupFileLoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBrowse2;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton customSToreLocation;
        private System.Windows.Forms.RadioButton defaultStorageLocation;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton CustomBackupLocation;
        private System.Windows.Forms.RadioButton defaultBackupLocation;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

