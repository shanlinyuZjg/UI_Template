using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI_SplitControl.cons
{
    public partial class UIFromTop : UserControl
    {
        public UIFromTop()
        {
            InitializeComponent();
        }

        private Icon _frm_Ico;
        public Icon Frm_Icon
        {
            get
            {
                if (_frm_Ico == null)
                {
                    Form frm = this.Parent as Form;
                    if (frm != null && ShowIco)
                        _frm_Ico = frm.Icon;
                }
                return _frm_Ico;
            }
            set
            {
                _frm_Ico = value;
            }
        }
        public bool ShowIco { get; set; } = true;

        public string Title { get; set; }

        public bool MaximizeBox
        {
            get
            {
                return this.pic_Max.Visible;
            }
            set
            {
                this.pic_Max.Visible = value;
            }
        }
        public bool MinimizeBox
        {
            get
            {
                return this.pic_Min.Visible;
            }
            set
            {
                this.pic_Min.Visible = value;
            }
        }

        private void pl_Top_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Rectangle rect = this.ClientRectangle;

            g.FillRectangle(new SolidBrush(this.BackColor), rect);

            Rectangle rect_ico = new Rectangle(0, 0, 0, 0);

            if (Frm_Icon != null && ShowIco)
            {
                rect_ico = new Rectangle(5, (rect.Height - 21) / 2, 20, 20);
                g.DrawIcon(Frm_Icon, rect_ico);
            }

            StringFormat sf = new StringFormat()
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center,
            };
            Rectangle rect_title = new Rectangle(rect_ico.Right + 5, 0, rect.Width - rect_ico.Width, rect.Height);
            g.DrawString(Title, this.Font, Brushes.Black, rect_title, sf);

        }

        #region 右上角 最小化 最大化 关闭

        private void pic_Close_MouseEnter(object sender, EventArgs e)
        {
            PictureBox c = sender as PictureBox;

            c.BackColor = Color.Red;
        }

        private void pic_Close_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.Parent != null)
            {
                Form frm = this.Parent as Form;

                frm.DialogResult = DialogResult.No;
                frm.Close();
            }
        }

        private void pic_Close_MouseLeave(object sender, EventArgs e)
        {
            PictureBox c = sender as PictureBox;

            c.BackColor = Color.Transparent;
        }

        private void ui_pic_MouseEnter(object sender, EventArgs e)
        {
            Control control = sender as Control;

            control.BackColor = Color.WhiteSmoke;
        }
        private void ui_pic__MouseLeave(object sender, EventArgs e)
        {
            Control control = sender as Control;

            control.BackColor = this.BackColor;
        }

        private void pic_Min_Click(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                Form frm = this.Parent as Form;

                frm.WindowState = FormWindowState.Minimized;
            }
        }
        private void pic_Max_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.Parent != null)
            {
                Form frm = this.Parent as Form;

                if (frm.WindowState == FormWindowState.Maximized)
                {
                    frm.WindowState = FormWindowState.Normal;
                }
                else
                {
                    frm.WindowState = FormWindowState.Maximized;
                }

            }
        }

        #endregion


        Point p;
        bool is_move = false;
        private void pl_Top_MouseDown(object sender, MouseEventArgs e)
        {
            p = new Point(e.X, e.Y);
            is_move = true;
        }

        private void pl_Top_MouseMove(object sender, MouseEventArgs e)
        {
            if (is_move && p.X != -100)
            {
                Form frm = this.Parent as Form;

                frm.Left += e.X - p.X;
                frm.Top += e.Y - p.Y;
            }
        }

        private void pl_Top_MouseUp(object sender, MouseEventArgs e)
        {
            p = new Point(-100, -100);
            is_move = false;
        }


    }
}
