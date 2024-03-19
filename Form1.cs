using Novell.Directory.Ldap;

namespace ActiveDirectoryVerify
{
    public partial class Form1 : Form
    {
        #region Constructor

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Public Mehthods

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Input_Host.Text = Settings1.Default.LadapHost;
                Input_Port.Text = Settings1.Default.LadapPort.ToString();
                Input_AdminAccount.Text = Settings1.Default.AdminAccount;
                Input_AdminPassword.Text = Settings1.Default.AdminPassword;
                Input_SearchBaseDn.Text = Settings1.Default.SearchBaseDn;
                Input_PropertyName.Text = Settings1.Default.PropertyName;
                Input_PropertyValue.Text = Settings1.Default.PropertyValue;
            }
            catch (Exception ex)
            {
                ShowEventErrorMessage("Form1_Load", ex);
            }
        }

        private void Button_Query_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckInput()) return;
                SaveSettings();

                var result = GetADInformation(
                        this.Input_Host.Text,
                        int.Parse(this.Input_Port.Text),
                        this.Input_AdminAccount.Text,
                        this.Input_AdminPassword.Text,
                        this.Input_SearchBaseDn.Text,
                        this.Input_PropertyName.Text,
                        this.Input_PropertyValue.Text
                 );

                this.Input_Result.Text = result;
            }
            catch (Exception ex)
            {
                ShowEventErrorMessage("Button_Query_Click", ex);
            }
        }

        #endregion

        #region Public Mehthods

        private bool CheckInput()
        {
            string message = string.Empty;
            string tips = "請輸入";

            if (string.IsNullOrEmpty(this.Input_Host.Text))
                message += $"{tips} {Label_Host.Text}\n";

            if (!int.TryParse(this.Input_Port.Text, out var _))
                message += $"{tips} {Label_Port.Text}\n";

            if (string.IsNullOrEmpty(this.Input_AdminAccount.Text))
                message += $"{tips} {Label_AdminAccount.Text}\n";

            if (string.IsNullOrEmpty(this.Input_AdminPassword.Text))
                message += $"{tips} {Label_AdminPassword.Text}\n";

            if (string.IsNullOrEmpty(this.Input_PropertyName.Text))
                message += $"{tips} {Label_PropertyName.Text}\n";

            if (string.IsNullOrEmpty(this.Input_PropertyValue.Text))
                message += $"{tips} {Label_PropertyValue.Text}\n";

            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message, "必填欄位", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private string GetADInformation(string host, int port, string adminAccount, string adminPassword, string searchBaseDn, string propertyName, string propertyValue)
        {
            string result = string.Empty;

            try
            {
                using (LdapConnection ldapConn = new LdapConnection())
                {
                    ldapConn.Connect(host, port);  // LdapConnection.DefaultPort 
                    ldapConn.Bind(adminAccount, adminPassword);

                    string searchFilter = $"({propertyName}={propertyValue})";
                    var searchResults = ldapConn.Search(
                        searchBaseDn,
                        LdapConnection.ScopeSub,
                        searchFilter,
                        null, // 返回所有屬性
                        false // 是否返回連結屬性
                    );

                    try
                    {
                        if (searchResults.HasMore())
                        {
                            // TODO : 執行 Next() 取得查詢的資料，但套件如果下一筆資料不存在會拋出例外，但目前沒查到有提供解決的辦法，暫時先用 try-catch 處理
                            var nextEntry = searchResults.Next();

                            result = $"【Dn 】: {nextEntry.Dn}{Environment.NewLine}{Environment.NewLine}";
                            result += $"其它可用屬性如下{Environment.NewLine}";

                            // 取得所有屬性
                            var attrs = nextEntry.GetAttributeSet().GetEnumerator();
                            var count = 1;
                            while (attrs.MoveNext())
                            {
                                var attrName = attrs.Current.Name;
                                var attrValue = attrs.Current.StringValue;

                                // AD 會傳回 char 0 的字串，這個不確定是那些設定，找到 char 0 就先不呈現了
                                var findChar0Key = attrValue.ToCharArray().Any(x => x == 0);
                                if (findChar0Key) attrValue = "** 無法顯示 **";

                                result += $"{count.ToString("00")}.【{attrName}】: {attrValue}{Environment.NewLine}";
                                count++;
                            }
                        }
                    }
                    catch (LdapException ex)
                    {
                        result += $"找不到設定屬性對應的值 : {ex.Message}";
                    }

                    ldapConn.Disconnect();
                }
            }
            catch (LdapException e)
            {
                MessageBox.Show($"LDAP 查詢錯誤: {e.Message}");
            }

            return result;
        }

        public bool IsContainHanString(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (IsHanCode(str, i))
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsHanCode(string str, int index)
        {
            int code = 0;
            int chFrom = Convert.ToInt32("4e00", 16);
            int chEnd = Convert.ToInt32("9fff", 16);

            if (str != "")
            {
                // 取得字串中指定索引處的字元 Unicode 編碼
                code = Char.ConvertToUtf32(str, index);

                if (code >= chFrom && code <= chEnd)
                {
                    return true;
                }

                return false;
            }

            return false;
        }

        private void SaveSettings()
        {
            Settings1.Default.LadapHost = this.Input_Host.Text;
            Settings1.Default.LadapPort = int.Parse(this.Input_Port.Text);
            Settings1.Default.AdminAccount = this.Input_AdminAccount.Text;
            Settings1.Default.AdminPassword = this.Input_AdminPassword.Text;
            Settings1.Default.SearchBaseDn = this.Input_SearchBaseDn.Text;
            Settings1.Default.PropertyName = this.Input_PropertyName.Text;
            Settings1.Default.PropertyValue = this.Input_PropertyValue.Text;
            Settings1.Default.Save();
        }

        private void ShowEventErrorMessage(string type, Exception error)
        {
            string errorMessage = $"Error Type : {type}{Environment.NewLine}{error}";
            MessageBox.Show(errorMessage, "系統錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        #endregion
    }
}
