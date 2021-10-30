namespace LaunchGame
{
    partial class frmLauncher
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
            this.components = new System.ComponentModel.Container();
            this.btnLaunchConan = new System.Windows.Forms.Button();
            this.txtUrlToResolve = new System.Windows.Forms.TextBox();
            this.lblResolvedIp = new System.Windows.Forms.Label();
            this.lblUrlTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.chkSavePassword = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.btnCopy = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLaunchConan
            // 
            this.btnLaunchConan.Location = new System.Drawing.Point(614, 66);
            this.btnLaunchConan.Name = "btnLaunchConan";
            this.btnLaunchConan.Size = new System.Drawing.Size(75, 20);
            this.btnLaunchConan.TabIndex = 0;
            this.btnLaunchConan.Text = "Launch Conan";
            this.btnLaunchConan.UseVisualStyleBackColor = true;
            this.btnLaunchConan.Click += new System.EventHandler(this.btnLaunchConan_Click);
            // 
            // txtUrlToResolve
            // 
            this.txtUrlToResolve.Location = new System.Drawing.Point(23, 66);
            this.txtUrlToResolve.Name = "txtUrlToResolve";
            this.txtUrlToResolve.Size = new System.Drawing.Size(233, 20);
            this.txtUrlToResolve.TabIndex = 1;
            // 
            // lblResolvedIp
            // 
            this.lblResolvedIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResolvedIp.Location = new System.Drawing.Point(262, 66);
            this.lblResolvedIp.Name = "lblResolvedIp";
            this.lblResolvedIp.Size = new System.Drawing.Size(120, 20);
            this.lblResolvedIp.TabIndex = 2;
            this.lblResolvedIp.Text = "Not Found Yet";
            // 
            // lblUrlTitle
            // 
            this.lblUrlTitle.AutoSize = true;
            this.lblUrlTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrlTitle.Location = new System.Drawing.Point(20, 39);
            this.lblUrlTitle.Name = "lblUrlTitle";
            this.lblUrlTitle.Size = new System.Drawing.Size(102, 17);
            this.lblUrlTitle.TabIndex = 3;
            this.lblUrlTitle.Text = "URL to resolve";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(262, 39);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(408, 66);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(405, 39);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // chkSavePassword
            // 
            this.chkSavePassword.AutoSize = true;
            this.chkSavePassword.Location = new System.Drawing.Point(408, 93);
            this.chkSavePassword.Name = "chkSavePassword";
            this.chkSavePassword.Size = new System.Drawing.Size(100, 17);
            this.chkSavePassword.TabIndex = 7;
            this.chkSavePassword.Text = "Save Password";
            this.chkSavePassword.UseVisualStyleBackColor = true;
            this.chkSavePassword.CheckedChanged += new System.EventHandler(this.chkSavePassword_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::LaunchGame.Properties.Resources.refresh_small;
            this.btnRefresh.Location = new System.Drawing.Point(386, 64);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(21, 23);
            this.btnRefresh.TabIndex = 10;
            this.toolTips.SetToolTip(this.btnRefresh, "Manually refresh the IP if you suspect it has changed.");
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnCopy
            // 
            this.btnCopy.Image = global::LaunchGame.Properties.Resources.copyIcon_small15x15;
            this.btnCopy.Location = new System.Drawing.Point(353, 87);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(27, 26);
            this.btnCopy.TabIndex = 12;
            this.toolTips.SetToolTip(this.btnCopy, "This will copy the resolved IP and append :7777 so it can be manually pasted.");
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(23, 93);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 11;
            // 
            // frmLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 118);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.chkSavePassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblUrlTitle);
            this.Controls.Add(this.lblResolvedIp);
            this.Controls.Add(this.txtUrlToResolve);
            this.Controls.Add(this.btnLaunchConan);
            this.Name = "frmLauncher";
            this.Text = "Dead Men Gaming Launcher V1.1";
            this.Load += new System.EventHandler(this.frmLauncher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLaunchConan;
        private System.Windows.Forms.TextBox txtUrlToResolve;
        private System.Windows.Forms.Label lblResolvedIp;
        private System.Windows.Forms.Label lblUrlTitle;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox chkSavePassword;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnCopy;
    }
}

