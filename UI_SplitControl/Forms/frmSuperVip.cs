using UI_SplitControl.BLL;
using UI_SplitControl.cons;
using UI_SplitControl.Extension;
using UI_SplitControl.Helper;
using UI_SplitControl.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace UI_SplitControl.Forms
{
    public partial class frmSuperVip : Form
    {
        public frmSuperVip()
        {
            InitializeComponent();

            this.dgv_Vip.AutoGenerateColumns = false;
        }
        SupVipBLL vipBLL = new SupVipBLL();
        DataTable tb = new DataTable();
        DataTable vip_tb = new DataTable();
        private void frmSuperVip_Load(object sender, EventArgs e)
        {
            try
            {
                btn_UpgradeVip.SimMouseClick();
                cb_Status.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        private void SwitchTab(Control con)
        {
            var imgLabel = con as ImgLabel;
            if (imgLabel == null) return;

            foreach (Control c in imgLabel.Parent.Controls)
            {
                var img = c as ImgLabel;
                if (img == null || c == con) continue;

                img.is_show_bord = false;
                img.Refresh();
            }

            imgLabel.is_show_bord = true;
            imgLabel.Refresh();


            int index = imgLabel.TabIndex;
            this.tb_Main.SelectedIndex = index;
            TabDo();
        }
        private void TabDo()
        {
            switch (this.tb_Main.SelectedIndex)
            {
                case 0:
                    break;
            }
        }

        private void btn_Tab_MouseClick(object sender, MouseEventArgs e)
        {
            Control con = sender as Control;
            SwitchTab(con);
        }

        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            int WM_KEYDOWN = 256;

            if (msg.Msg == WM_KEYDOWN)
            {
                switch (keyData)
                {
                    case Keys.Enter:
                        SendKeys.Send("{TAB}");
                        break;
                }
            }


            return false;
        }

        private void frmSuperVip_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        #region 超级会员

        private void btn_Select_Click(object sender, EventArgs e)
        {
            try
            {
                vip_tb = vipBLL.GetSuperVip(this.txt_Name.Text, this.cb_Status.SelectedIndex);
                this.dgv_Vip.DataSource = vip_tb;
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        #endregion


    }
}
