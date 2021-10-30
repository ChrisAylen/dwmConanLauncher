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
            this.btnLaunchConan.Location = new System.Drawing.Point(716, 76);
            this.btnLaunchConan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLaunchConan.Name = "btnLaunchConan";
            this.btnLaunchConan.Size = new System.Drawing.Size(88, 23);
            this.btnLaunchConan.TabIndex = 0;
            this.btnLaunchConan.Text = "Launch Conan";
            this.btnLaunchConan.UseVisualStyleBackColor = true;
            this.btnLaunchConan.Click += new System.EventHandler(this.btnLaunchConan_Click);
            // 
            // txtUrlToResolve
            // 
            this.txtUrlToResolve.Location = new System.Drawing.Point(27, 76);
            this.txtUrlToResolve.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUrlToResolve.Name = "txtUrlToResolve";
            this.txtUrlToResolve.Size = new System.Drawing.Size(271, 23);
            this.txtUrlToResolve.TabIndex = 1;
            // 
            // lblResolvedIp
            // 
            this.lblResolvedIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResolvedIp.Location = new System.Drawing.Point(306, 76);
            this.lblResolvedIp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResolvedIp.Name = "lblResolvedIp";
            this.lblResolvedIp.Size = new System.Drawing.Size(140, 23);
            this.lblResolvedIp.TabIndex = 2;
            this.lblResolvedIp.Text = "Not Found Yet";
            // 
            // lblUrlTitle
            // 
            this.lblUrlTitle.AutoSize = true;
            this.lblUrlTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUrlTitle.Location = new System.Drawing.Point(23, 45);
            this.lblUrlTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrlTitle.Name = "lblUrlTitle";
            this.lblUrlTitle.Size = new System.Drawing.Size(102, 17);
            this.lblUrlTitle.TabIndex = 3;
            this.lblUrlTitle.Text = "URL to resolve";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(306, 45);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(476, 76);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(233, 23);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(472, 45);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // chkSavePassword
            // 
            this.chkSavePassword.AutoSize = true;
            this.chkSavePassword.Location = new System.Drawing.Point(476, 107);
            this.chkSavePassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkSavePassword.Name = "chkSavePassword";
            this.chkSavePassword.Size = new System.Drawing.Size(103, 19);
            this.chkSavePassword.TabIndex = 7;
            this.chkSavePassword.Text = "Save Password";
            this.chkSavePassword.UseVisualStyleBackColor = true;
            this.chkSavePassword.CheckedChanged += new System.EventHandler(this.chkSavePassword_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::LaunchGame.Properties.Resources.refresh_small;
            this.btnRefresh.Location = new System.Drawing.Point(450, 74);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(24, 27);
            this.btnRefresh.TabIndex = 10;
            this.toolTips.SetToolTip(this.btnRefresh, "Manually refresh the IP if you suspect it has changed.");
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnCopy
            // 
            this.btnCopy.Image = global::LaunchGame.Properties.Resources.copyIcon_small15x15;
            this.btnCopy.Location = new System.Drawing.Point(412, 100);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(31, 30);
            this.btnCopy.TabIndex = 12;
            this.toolTips.SetToolTip(this.btnCopy, "This will copy the resolved IP and append :7777 so it can be manually pasted.");
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(27, 107);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 15);
            this.lblMessage.TabIndex = 11;
            // 
            // frmLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 136);
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
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmLauncher";
            this.Text = "Dead Men Gaming Launcher V2.0";
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

