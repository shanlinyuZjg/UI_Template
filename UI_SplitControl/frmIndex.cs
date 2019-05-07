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
using UI_SplitControl.Model;
using UI_SplitControl.Forms;

namespace UI_SplitControl
{
    public partial class frmIndex : Form
    {
        public frmIndex()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.AllPaintingInWmPaint, true);

            InitializeComponent();

            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);

            AppSetting.frmIndex = this;
        }

        public sa_t_operator_i _operator;
        public sa_t_operator_i Operator
        {
            get
            {
                return _operator;
            }
            set
            {
                _operator = value;

                if (value != null)
                {
                    this.img_User.Content = value.oper_name;
                    this.img_User.Refresh();
                }
            }
        }

        private void frmIndex_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Rectangle rec = new Rectangle(1, 1, this.Width - 2, this.Height - 2);
            g.DrawRectangle(new Pen(Brushes.Gainsboro), rec);
        }

        private void frmIndex_Load(object sender, EventArgs e)
        {
            try
            {
                btn_Login.SimMouseClick();
                btn_Login_Click(btn_Login, e);
            }
            catch (Exception ex)
            {
                ex.ShowMessage();
            }
        }

        //切换窗口
        private void SwitchFrm(Form frm)
        {
            if (frm == null) return;

            this.pl_Main.Controls.Clear();

            frm.TopLevel = false;
            this.pl_Main.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            frm.Show();
        }

        #region 左侧面板 
        private void btn_Login_Click(object sender, EventArgs e)
        {
            Form frm = new frmLogin();

            if (string.IsNullOrEmpty(AppSetting.Ip) || string.IsNullOrEmpty(AppSetting.Port) || string.IsNullOrEmpty(AppSetting.Db))
            {
                MessageBox.Show("未设置数据库信息,请先设置数据库信息");
                btn_Setting.SimClick();
                return;
            }

            SwitchFrm(frm);
        }

        private void btn_SuperVip_Click(object sender, EventArgs e)
        {
            Form frm = new frmSuperVip();
            if (Operator == null || string.IsNullOrEmpty(Operator.oper_id))
            {
                MessageBox.Show("请先登录");
                btn_Login.SimClick();
                return;
            }

            SwitchFrm(frm);
        }

        private void btn_Setting_Click(object sender, EventArgs e)
        {
            Form frm = new frmSettings();

            SwitchFrm(frm);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认要退出吗?", "系统提示",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        #endregion


    }


}
