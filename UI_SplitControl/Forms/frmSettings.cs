using UI_SplitControl.Extension;
using UI_SplitControl.Helper;
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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }
        BLL.SupVipBLL supVipBLL = new BLL.SupVipBLL();

        private void frmSettings_Load(object sender, EventArgs e)
        {
            try
            {
                this.txt_IP.Text = AppSetting.Ip;
                this.txt_Port.Text = AppSetting.Port;
                this.txt_DB.Text = AppSetting.Db;
                this.cb_Locking.Checked = InI.ReadValue("server", "is_lock").ToBool();
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void btn_TestDB_Click(object sender, EventArgs e)
        {
            try
            {
                AppSetting.Ip = txt_IP.Text;
                AppSetting.Port = txt_Port.Text;
                AppSetting.Db = txt_DB.Text;

                supVipBLL.TestConnection();

                MessageBox.Show("测试成功");
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
                AppSetting.Ip = txt_IP.Text;
                AppSetting.Port = txt_Port.Text;
                AppSetting.Db = txt_DB.Text;
                InI.Writue("server", "is_lock", this.cb_Locking.Checked.ToString());

                MessageBox.Show("保存成功");
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }

        }

        private void cb_Locking_CheckedChanged(object sender, EventArgs e)
        {
            this.txt_DB.Enabled = !cb_Locking.Checked;
            this.txt_IP.Enabled = !cb_Locking.Checked;
            this.txt_Port.Enabled = !cb_Locking.Checked;
        }


    }
}
