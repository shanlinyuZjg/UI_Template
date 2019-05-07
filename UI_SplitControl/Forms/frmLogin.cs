using UI_SplitControl.Extension;
using UI_SplitControl.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI_SplitControl.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        List<string> user_lis = new List<string>();
        Dictionary<string, string> pwd_dic = new Dictionary<string, string>();
        BLL.SupVipBLL vipBLL = new BLL.SupVipBLL();
        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                user_lis = user_lis.DeSerializableObject("user");
                pwd_dic = pwd_dic.DeSerializableObject("user_pwd");

                if (user_lis.Count > 0)
                {
                    int index = user_lis.Count - 1;
                    this.txt_User.Text = user_lis[index];

                    if (pwd_dic.TryGetValue(user_lis[index], out string result))
                    {
                        this.txt_Pwd.Text = result;
                        this.cb_RemberPwd.Checked = !string.IsNullOrEmpty(result);
                    }

                }

                AutoCompleteStringCollection source = new AutoCompleteStringCollection();
                source.AddRange(user_lis.ToArray());

                this.txt_User.AutoCompleteCustomSource = source;
                this.txt_User.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                this.txt_User.AutoCompleteSource = AutoCompleteSource.CustomSource;

            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txt_User.Text))
                {
                    throw new Exception("请输入帐户");
                }

                sa_t_operator_i oper = vipBLL.Login(this.txt_User.Text, this.txt_Pwd.Text);

                if (oper == null || string.IsNullOrEmpty(oper.oper_id))
                {
                    throw new Exception("帐户或密码错误");
                }

                if (pwd_dic.Keys.Contains(oper.oper_id))
                {
                    pwd_dic[oper.oper_id] = this.cb_RemberPwd.Checked ? this.txt_Pwd.Text : "";
                }
                else
                {
                    user_lis.Add(oper.oper_id);
                    pwd_dic.Add(oper.oper_id, this.cb_RemberPwd.Checked ? this.txt_Pwd.Text : "");
                }

                user_lis.SerializableObject("user");
                pwd_dic.SerializableObject("user_pwd");

                AppSetting.frmIndex.Operator = oper;

                MessageBox.Show("登录成功");
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void txt_User_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                this.txt_Pwd.Focus();
            }
        }

        private void txt_Pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btn_Login.PerformClick();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                e.Handled = true;
                cb_RemberPwd.Focus();
            }

        }
    }
}
