namespace ActiveDirectoryVerify
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Input_Host = new TextBox();
            Input_Port = new TextBox();
            Input_AdminAccount = new TextBox();
            Input_AdminPassword = new TextBox();
            Label_Host = new Label();
            Label_Port = new Label();
            Label_AdminAccount = new Label();
            Label_AdminPassword = new Label();
            Label_PropertyName = new Label();
            Input_PropertyName = new TextBox();
            Label_PropertyValue = new Label();
            Input_PropertyValue = new TextBox();
            Button_Query = new Button();
            Input_Result = new TextBox();
            Label_SearchBaseDn = new Label();
            Input_SearchBaseDn = new TextBox();
            SuspendLayout();
            // 
            // Input_Host
            // 
            Input_Host.Location = new Point(168, 12);
            Input_Host.Name = "Input_Host";
            Input_Host.PlaceholderText = "LDAP Host";
            Input_Host.Size = new Size(382, 27);
            Input_Host.TabIndex = 0;
            // 
            // Input_Port
            // 
            Input_Port.Location = new Point(168, 47);
            Input_Port.Name = "Input_Port";
            Input_Port.PlaceholderText = "LDAP Port";
            Input_Port.Size = new Size(382, 27);
            Input_Port.TabIndex = 1;
            // 
            // Input_AdminAccount
            // 
            Input_AdminAccount.Location = new Point(168, 80);
            Input_AdminAccount.Name = "Input_AdminAccount";
            Input_AdminAccount.PlaceholderText = "AD 管理者帳號";
            Input_AdminAccount.Size = new Size(382, 27);
            Input_AdminAccount.TabIndex = 2;
            // 
            // Input_AdminPassword
            // 
            Input_AdminPassword.Location = new Point(168, 113);
            Input_AdminPassword.Name = "Input_AdminPassword";
            Input_AdminPassword.PasswordChar = '*';
            Input_AdminPassword.PlaceholderText = "AD 管理者密碼";
            Input_AdminPassword.Size = new Size(382, 27);
            Input_AdminPassword.TabIndex = 3;
            // 
            // Label_Host
            // 
            Label_Host.AutoSize = true;
            Label_Host.Location = new Point(16, 15);
            Label_Host.Name = "Label_Host";
            Label_Host.Size = new Size(83, 19);
            Label_Host.TabIndex = 4;
            Label_Host.Text = "LDAP Host";
            // 
            // Label_Port
            // 
            Label_Port.AutoSize = true;
            Label_Port.Location = new Point(15, 50);
            Label_Port.Name = "Label_Port";
            Label_Port.Size = new Size(80, 19);
            Label_Port.TabIndex = 5;
            Label_Port.Text = "LDAP Port";
            // 
            // Label_AdminAccount
            // 
            Label_AdminAccount.AutoSize = true;
            Label_AdminAccount.Location = new Point(15, 83);
            Label_AdminAccount.Name = "Label_AdminAccount";
            Label_AdminAccount.Size = new Size(115, 19);
            Label_AdminAccount.TabIndex = 6;
            Label_AdminAccount.Text = "AD Admin 帳號";
            // 
            // Label_AdminPassword
            // 
            Label_AdminPassword.AutoSize = true;
            Label_AdminPassword.Location = new Point(15, 116);
            Label_AdminPassword.Name = "Label_AdminPassword";
            Label_AdminPassword.Size = new Size(115, 19);
            Label_AdminPassword.TabIndex = 7;
            Label_AdminPassword.Text = "AD Admin 密碼";
            // 
            // Label_PropertyName
            // 
            Label_PropertyName.AutoSize = true;
            Label_PropertyName.Location = new Point(15, 181);
            Label_PropertyName.Name = "Label_PropertyName";
            Label_PropertyName.Size = new Size(99, 19);
            Label_PropertyName.TabIndex = 9;
            Label_PropertyName.Text = "要查詢的屬性";
            // 
            // Input_PropertyName
            // 
            Input_PropertyName.Location = new Point(168, 178);
            Input_PropertyName.Name = "Input_PropertyName";
            Input_PropertyName.PlaceholderText = "根據組織 AD 設定值來調整";
            Input_PropertyName.Size = new Size(382, 27);
            Input_PropertyName.TabIndex = 8;
            // 
            // Label_PropertyValue
            // 
            Label_PropertyValue.AutoSize = true;
            Label_PropertyValue.Location = new Point(15, 214);
            Label_PropertyValue.Name = "Label_PropertyValue";
            Label_PropertyValue.Size = new Size(84, 19);
            Label_PropertyValue.TabIndex = 11;
            Label_PropertyValue.Text = "要查詢的值";
            // 
            // Input_PropertyValue
            // 
            Input_PropertyValue.Location = new Point(168, 211);
            Input_PropertyValue.Name = "Input_PropertyValue";
            Input_PropertyValue.PlaceholderText = "要查詢的值";
            Input_PropertyValue.Size = new Size(382, 27);
            Input_PropertyValue.TabIndex = 10;
            // 
            // Button_Query
            // 
            Button_Query.Location = new Point(15, 251);
            Button_Query.Name = "Button_Query";
            Button_Query.Size = new Size(535, 29);
            Button_Query.TabIndex = 12;
            Button_Query.Text = "查詢";
            Button_Query.UseVisualStyleBackColor = true;
            Button_Query.Click += Button_Query_Click;
            // 
            // Input_Result
            // 
            Input_Result.Location = new Point(15, 295);
            Input_Result.Multiline = true;
            Input_Result.Name = "Input_Result";
            Input_Result.PlaceholderText = "查詢結果";
            Input_Result.ScrollBars = ScrollBars.Vertical;
            Input_Result.Size = new Size(535, 350);
            Input_Result.TabIndex = 13;
            // 
            // Label_SearchBaseDn
            // 
            Label_SearchBaseDn.AutoSize = true;
            Label_SearchBaseDn.Location = new Point(15, 148);
            Label_SearchBaseDn.Name = "Label_SearchBaseDn";
            Label_SearchBaseDn.Size = new Size(145, 19);
            Label_SearchBaseDn.TabIndex = 15;
            Label_SearchBaseDn.Text = "要查詢的 DN 根路徑";
            // 
            // Input_SearchBaseDn
            // 
            Input_SearchBaseDn.Location = new Point(168, 145);
            Input_SearchBaseDn.Name = "Input_SearchBaseDn";
            Input_SearchBaseDn.PlaceholderText = "LDAP基礎搜尋路徑";
            Input_SearchBaseDn.Size = new Size(382, 27);
            Input_SearchBaseDn.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 657);
            Controls.Add(Label_SearchBaseDn);
            Controls.Add(Input_SearchBaseDn);
            Controls.Add(Input_Result);
            Controls.Add(Button_Query);
            Controls.Add(Label_PropertyValue);
            Controls.Add(Input_PropertyValue);
            Controls.Add(Label_PropertyName);
            Controls.Add(Input_PropertyName);
            Controls.Add(Label_AdminPassword);
            Controls.Add(Label_AdminAccount);
            Controls.Add(Label_Port);
            Controls.Add(Label_Host);
            Controls.Add(Input_AdminPassword);
            Controls.Add(Input_AdminAccount);
            Controls.Add(Input_Port);
            Controls.Add(Input_Host);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AD 屬性查詢";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Input_Host;
        private TextBox Input_Port;
        private TextBox Input_AdminAccount;
        private TextBox Input_AdminPassword;
        private Label Label_Host;
        private Label Label_Port;
        private Label Label_AdminAccount;
        private Label Label_AdminPassword;
        private Label Label_PropertyName;
        private TextBox Input_PropertyName;
        private Label Label_PropertyValue;
        private TextBox Input_PropertyValue;
        private Button Button_Query;
        private TextBox Input_Result;
        private Label Label_SearchBaseDn;
        private TextBox Input_SearchBaseDn;
    }
}
