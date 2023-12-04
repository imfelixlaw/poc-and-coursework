namespace HR_Attendance_Module_Client
{
    partial class FrmMain
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
            this.groupBoxBranch = new System.Windows.Forms.GroupBox();
            this.comboBoxBranch = new System.Windows.Forms.ComboBox();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.groupBoxPassword = new System.Windows.Forms.GroupBox();
            this.labelPasswordRequired = new System.Windows.Forms.Label();
            this.buttonAuthentication = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.groupBoxLanguage = new System.Windows.Forms.GroupBox();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.groupBoxAction = new System.Windows.Forms.GroupBox();
            this.labelLastAttendanceMode = new System.Windows.Forms.Label();
            this.labelLastAttendanceTime = new System.Windows.Forms.Label();
            this.textBoxSystemMessage = new System.Windows.Forms.TextBox();
            this.labelSystemMessage = new System.Windows.Forms.Label();
            this.buttonTodayAttendanceHistory = new System.Windows.Forms.Button();
            this.buttonPunchAttendance = new System.Windows.Forms.Button();
            this.labelLastAttendance = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelOfflineMode = new System.Windows.Forms.Label();
            this.groupBoxBranch.SuspendLayout();
            this.groupBoxUser.SuspendLayout();
            this.groupBoxPassword.SuspendLayout();
            this.groupBoxLanguage.SuspendLayout();
            this.groupBoxAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBranch
            // 
            this.groupBoxBranch.Controls.Add(this.comboBoxBranch);
            this.groupBoxBranch.Location = new System.Drawing.Point(12, 12);
            this.groupBoxBranch.Name = "groupBoxBranch";
            this.groupBoxBranch.Size = new System.Drawing.Size(200, 53);
            this.groupBoxBranch.TabIndex = 0;
            this.groupBoxBranch.TabStop = false;
            this.groupBoxBranch.Text = "groupBoxBranch";
            // 
            // comboBoxBranch
            // 
            this.comboBoxBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBranch.FormattingEnabled = true;
            this.comboBoxBranch.Location = new System.Drawing.Point(6, 21);
            this.comboBoxBranch.Name = "comboBoxBranch";
            this.comboBoxBranch.Size = new System.Drawing.Size(188, 21);
            this.comboBoxBranch.TabIndex = 0;
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.comboBoxUser);
            this.groupBoxUser.Location = new System.Drawing.Point(12, 71);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(200, 53);
            this.groupBoxUser.TabIndex = 1;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "groupBoxUser";
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(6, 20);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(188, 21);
            this.comboBoxUser.TabIndex = 1;
            // 
            // groupBoxPassword
            // 
            this.groupBoxPassword.Controls.Add(this.labelPasswordRequired);
            this.groupBoxPassword.Controls.Add(this.buttonAuthentication);
            this.groupBoxPassword.Controls.Add(this.textBoxPassword);
            this.groupBoxPassword.Location = new System.Drawing.Point(12, 130);
            this.groupBoxPassword.Name = "groupBoxPassword";
            this.groupBoxPassword.Size = new System.Drawing.Size(200, 80);
            this.groupBoxPassword.TabIndex = 2;
            this.groupBoxPassword.TabStop = false;
            this.groupBoxPassword.Text = "groupBoxPassword";
            // 
            // labelPasswordRequired
            // 
            this.labelPasswordRequired.Location = new System.Drawing.Point(4, 43);
            this.labelPasswordRequired.Name = "labelPasswordRequired";
            this.labelPasswordRequired.Size = new System.Drawing.Size(91, 31);
            this.labelPasswordRequired.TabIndex = 2;
            this.labelPasswordRequired.Text = "Password is required";
            // 
            // buttonAuthentication
            // 
            this.buttonAuthentication.Location = new System.Drawing.Point(103, 46);
            this.buttonAuthentication.Name = "buttonAuthentication";
            this.buttonAuthentication.Size = new System.Drawing.Size(91, 23);
            this.buttonAuthentication.TabIndex = 1;
            this.buttonAuthentication.Text = "buttonAuthentication";
            this.buttonAuthentication.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(6, 20);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(188, 20);
            this.textBoxPassword.TabIndex = 2;
            // 
            // groupBoxLanguage
            // 
            this.groupBoxLanguage.Controls.Add(this.comboBoxLanguage);
            this.groupBoxLanguage.Location = new System.Drawing.Point(12, 216);
            this.groupBoxLanguage.Name = "groupBoxLanguage";
            this.groupBoxLanguage.Size = new System.Drawing.Size(200, 53);
            this.groupBoxLanguage.TabIndex = 3;
            this.groupBoxLanguage.TabStop = false;
            this.groupBoxLanguage.Text = "groupBoxLanguage";
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Location = new System.Drawing.Point(6, 19);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(188, 21);
            this.comboBoxLanguage.TabIndex = 3;
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage_SelectedIndexChanged);
            // 
            // groupBoxAction
            // 
            this.groupBoxAction.Controls.Add(this.labelLastAttendanceMode);
            this.groupBoxAction.Controls.Add(this.labelLastAttendanceTime);
            this.groupBoxAction.Controls.Add(this.textBoxSystemMessage);
            this.groupBoxAction.Controls.Add(this.labelSystemMessage);
            this.groupBoxAction.Controls.Add(this.buttonTodayAttendanceHistory);
            this.groupBoxAction.Controls.Add(this.buttonPunchAttendance);
            this.groupBoxAction.Controls.Add(this.labelLastAttendance);
            this.groupBoxAction.Location = new System.Drawing.Point(218, 12);
            this.groupBoxAction.Name = "groupBoxAction";
            this.groupBoxAction.Size = new System.Drawing.Size(230, 228);
            this.groupBoxAction.TabIndex = 4;
            this.groupBoxAction.TabStop = false;
            this.groupBoxAction.Text = "groupBoxAction";
            // 
            // labelLastAttendanceMode
            // 
            this.labelLastAttendanceMode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLastAttendanceMode.Location = new System.Drawing.Point(152, 38);
            this.labelLastAttendanceMode.Name = "labelLastAttendanceMode";
            this.labelLastAttendanceMode.Size = new System.Drawing.Size(31, 16);
            this.labelLastAttendanceMode.TabIndex = 8;
            this.labelLastAttendanceMode.Text = "labelLastAttendance";
            // 
            // labelLastAttendanceTime
            // 
            this.labelLastAttendanceTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLastAttendanceTime.Location = new System.Drawing.Point(22, 38);
            this.labelLastAttendanceTime.Name = "labelLastAttendanceTime";
            this.labelLastAttendanceTime.Size = new System.Drawing.Size(124, 16);
            this.labelLastAttendanceTime.TabIndex = 7;
            this.labelLastAttendanceTime.Text = "labelLastAttendanceTime";
            // 
            // textBoxSystemMessage
            // 
            this.textBoxSystemMessage.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSystemMessage.Location = new System.Drawing.Point(9, 125);
            this.textBoxSystemMessage.Multiline = true;
            this.textBoxSystemMessage.Name = "textBoxSystemMessage";
            this.textBoxSystemMessage.ReadOnly = true;
            this.textBoxSystemMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSystemMessage.Size = new System.Drawing.Size(212, 97);
            this.textBoxSystemMessage.TabIndex = 6;
            // 
            // labelSystemMessage
            // 
            this.labelSystemMessage.AutoSize = true;
            this.labelSystemMessage.Location = new System.Drawing.Point(6, 109);
            this.labelSystemMessage.Name = "labelSystemMessage";
            this.labelSystemMessage.Size = new System.Drawing.Size(106, 13);
            this.labelSystemMessage.TabIndex = 5;
            this.labelSystemMessage.Text = "labelSystemMessage";
            // 
            // buttonTodayAttendanceHistory
            // 
            this.buttonTodayAttendanceHistory.Location = new System.Drawing.Point(189, 33);
            this.buttonTodayAttendanceHistory.Name = "buttonTodayAttendanceHistory";
            this.buttonTodayAttendanceHistory.Size = new System.Drawing.Size(31, 25);
            this.buttonTodayAttendanceHistory.TabIndex = 4;
            this.buttonTodayAttendanceHistory.Text = ">>";
            this.buttonTodayAttendanceHistory.UseVisualStyleBackColor = true;
            // 
            // buttonPunchAttendance
            // 
            this.buttonPunchAttendance.Location = new System.Drawing.Point(73, 63);
            this.buttonPunchAttendance.Name = "buttonPunchAttendance";
            this.buttonPunchAttendance.Size = new System.Drawing.Size(85, 41);
            this.buttonPunchAttendance.TabIndex = 5;
            this.buttonPunchAttendance.Text = "buttonPunchAttendance";
            this.buttonPunchAttendance.UseVisualStyleBackColor = true;
            // 
            // labelLastAttendance
            // 
            this.labelLastAttendance.AutoSize = true;
            this.labelLastAttendance.Location = new System.Drawing.Point(6, 21);
            this.labelLastAttendance.Name = "labelLastAttendance";
            this.labelLastAttendance.Size = new System.Drawing.Size(85, 13);
            this.labelLastAttendance.TabIndex = 0;
            this.labelLastAttendance.Text = "Last Attendance";
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(373, 246);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "buttonClose";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(224, 251);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(64, 13);
            this.labelVersion.TabIndex = 6;
            this.labelVersion.Text = "labelVersion";
            // 
            // labelOfflineMode
            // 
            this.labelOfflineMode.AutoSize = true;
            this.labelOfflineMode.Location = new System.Drawing.Point(293, 251);
            this.labelOfflineMode.Name = "labelOfflineMode";
            this.labelOfflineMode.Size = new System.Drawing.Size(86, 13);
            this.labelOfflineMode.TabIndex = 7;
            this.labelOfflineMode.Text = "labelOfflineMode";
            this.labelOfflineMode.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(459, 278);
            this.Controls.Add(this.labelOfflineMode);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxAction);
            this.Controls.Add(this.groupBoxLanguage);
            this.Controls.Add(this.groupBoxPassword);
            this.Controls.Add(this.groupBoxUser);
            this.Controls.Add(this.groupBoxBranch);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR Attendance Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.groupBoxBranch.ResumeLayout(false);
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxPassword.ResumeLayout(false);
            this.groupBoxPassword.PerformLayout();
            this.groupBoxLanguage.ResumeLayout(false);
            this.groupBoxAction.ResumeLayout(false);
            this.groupBoxAction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBranch;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.ComboBox comboBoxBranch;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.GroupBox groupBoxPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonAuthentication;
        private System.Windows.Forms.Label labelPasswordRequired;
        private System.Windows.Forms.GroupBox groupBoxLanguage;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.GroupBox groupBoxAction;
        private System.Windows.Forms.Label labelLastAttendance;
        private System.Windows.Forms.Button buttonPunchAttendance;
        private System.Windows.Forms.Button buttonTodayAttendanceHistory;
        private System.Windows.Forms.Label labelSystemMessage;
        private System.Windows.Forms.TextBox textBoxSystemMessage;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelLastAttendanceTime;
        private System.Windows.Forms.Label labelLastAttendanceMode;
        private System.Windows.Forms.Label labelOfflineMode;
    }
}

