namespace Final_Project___Library_Management_System
{
    partial class frmMain
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
            this.btnEnterUserFrm = new System.Windows.Forms.Button();
            this.btnEnterLibraryFrm = new System.Windows.Forms.Button();
            this.btnEnterReportFrm = new System.Windows.Forms.Button();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnterUserFrm
            // 
            this.btnEnterUserFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterUserFrm.Location = new System.Drawing.Point(33, 195);
            this.btnEnterUserFrm.Name = "btnEnterUserFrm";
            this.btnEnterUserFrm.Size = new System.Drawing.Size(172, 85);
            this.btnEnterUserFrm.TabIndex = 0;
            this.btnEnterUserFrm.Text = "User Form";
            this.btnEnterUserFrm.UseVisualStyleBackColor = true;
            this.btnEnterUserFrm.Click += new System.EventHandler(this.btnEnterUserFrm_Click);
            // 
            // btnEnterLibraryFrm
            // 
            this.btnEnterLibraryFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterLibraryFrm.Location = new System.Drawing.Point(230, 195);
            this.btnEnterLibraryFrm.Name = "btnEnterLibraryFrm";
            this.btnEnterLibraryFrm.Size = new System.Drawing.Size(172, 85);
            this.btnEnterLibraryFrm.TabIndex = 1;
            this.btnEnterLibraryFrm.Text = "Library Form";
            this.btnEnterLibraryFrm.UseVisualStyleBackColor = true;
            this.btnEnterLibraryFrm.Click += new System.EventHandler(this.btnEnterLibraryFrm_Click);
            // 
            // btnEnterReportFrm
            // 
            this.btnEnterReportFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterReportFrm.Location = new System.Drawing.Point(427, 195);
            this.btnEnterReportFrm.Name = "btnEnterReportFrm";
            this.btnEnterReportFrm.Size = new System.Drawing.Size(172, 85);
            this.btnEnterReportFrm.TabIndex = 2;
            this.btnEnterReportFrm.Text = "Report Form";
            this.btnEnterReportFrm.UseVisualStyleBackColor = true;
            this.btnEnterReportFrm.Click += new System.EventHandler(this.btnEnterReportFrm_Click);
            // 
            // btnExitApp
            // 
            this.btnExitApp.BackColor = System.Drawing.Color.Transparent;
            this.btnExitApp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExitApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitApp.Location = new System.Drawing.Point(624, 195);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(172, 85);
            this.btnExitApp.TabIndex = 3;
            this.btnExitApp.Text = "Exit Application";
            this.btnExitApp.UseVisualStyleBackColor = false;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExitApp;
            this.ClientSize = new System.Drawing.Size(853, 475);
            this.Controls.Add(this.btnExitApp);
            this.Controls.Add(this.btnEnterReportFrm);
            this.Controls.Add(this.btnEnterLibraryFrm);
            this.Controls.Add(this.btnEnterUserFrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = "Library Management System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnterUserFrm;
        private System.Windows.Forms.Button btnEnterLibraryFrm;
        private System.Windows.Forms.Button btnEnterReportFrm;
        private System.Windows.Forms.Button btnExitApp;
    }
}

