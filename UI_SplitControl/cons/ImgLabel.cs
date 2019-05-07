using UI_SplitControl.Extension;
using UI_SplitControl.Helper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI_SplitControl.cons
{
    public class ImgLabel : ScrollableControl
    {
        public ImgLabel()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                            ControlStyles.ResizeRedraw |
                            ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);

            InitializeComponent();

            this.BackColor = Color.Transparent;
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ImgLabel
            // 
            this.BackColorChanged += new System.EventHandler(this.ImgLabel_BackColorChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ImgLabel_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImgLabel_MouseDown);
            this.MouseEnter += new System.EventHandler(this.ImgLabel_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ImgLabel_MouseLeave);
            this.ResumeLayout(false);

        }

        public bool is_select { get; set; } = false;
        public bool is_select_enable { get; set; } = true;
        public string group_name { get; set; }

        public Image Label_Image { get; set; }
        public ImageLayout Label_ImageLayout { get; set; }
        public DockStyle Image_Dock { get; set; }
        public int Image_Margin { get; set; }

        public string Content { get; set; }
        public StringAlignment Level_SF { get; set; }
        public StringAlignment Vertical_SF { get; set; }

        public Color Original_BackColor { get; set; }
        public Color Original_ForeColor { get; set; }
        private Color Temp_BackColor { get; set; } = Color.Transparent;
        private Color Temp_ForeColor { get; set; } = Color.Transparent;
        public Color Move_BackColor { get; set; }
        public Color Move_ForeColor { get; set; }


        //边框
        public bool is_show_bord { get; set; } = false;
        public int Rect_Top { get; set; }
        public int Rect_Left { get; set; }
        public int Rect_Right { get; set; }
        public int Rect_Bottom { get; set; }
        public double Rect_Reserved { get; set; }
        public Color Rect_Color { get; set; }


        public string ToolString { get; set; } = "";

        public int CornerRadius { get; set; } = 1;

        /// <summary>
        /// 计算位置
        /// </summary>
        private void CalculatedPosition(Rectangle rect, int top_jg, out Rectangle rect_img, out Rectangle rect_str)
        {
            rect_img = new Rectangle(0, 0, 0, 0);
            rect_str = new Rectangle(0, 0, 0, 0);

            if (Image_Dock == DockStyle.Top)
            {
                if (Label_Image != null)
                {
                    rect_img = new Rectangle((rect.Width - Label_Image.Width) / 2, top_jg, Label_Image.Width, Label_Image.Height);
                }
                rect_str = new Rectangle(0, rect_img.Bottom, rect.Width, rect.Height - rect_img.Height - top_jg);
            }
            else if (Image_Dock == DockStyle.Left)
            {
                if (Label_Image != null)
                {
                    rect_img = new Rectangle(top_jg, (rect.Height - Label_Image.Height) / 2, Label_Image.Width, Label_Image.Height);
                }
                rect_str = new Rectangle(rect_img.Right, 0, rect.Width - rect_img.Width - top_jg, rect.Height);
            }
            else if (Image_Dock == DockStyle.Right)
            {
                if (Label_Image != null)
                {
                    rect_str = new Rectangle(0, 0, rect.Width - Label_Image.Width - top_jg, rect.Height);
                }
                rect_img = new Rectangle(rect_str.Right, (rect.Height - Label_Image.Height) / 2, Label_Image.Width, Label_Image.Height);
            }
            else if (Image_Dock == DockStyle.Bottom)
            {
                if (Label_Image != null)
                {
                    rect_str = new Rectangle(0, 0, rect.Width, rect.Height - Label_Image.Height - top_jg);
                }
                rect_img = new Rectangle((rect.Width - Label_Image.Width) / 2, rect_str.Bottom, Label_Image.Width, Label_Image.Height);
            }
            else
            {
                rect_str = rect;
            }
        }
        private void DrawBorder(Graphics g)
        {
            if (!is_show_bord) return;

            int reserved = 0;

            if (Rect_Reserved >= 1)
            {
                reserved = Rect_Reserved.ToInt32();
            }
            else if (Rect_Reserved > 0 && Rect_Reserved < 1)
            {
                int mul = (Rect_Reserved * 10).ToInt32();
                reserved = this.Width / 2 / 10 * mul;
                Console.WriteLine($"mul:{mul},reserved:{reserved}");
            }

            {
                //top
                Point pleft = new Point(reserved, -1 + Rect_Top);
                Point pright = new Point(this.Width - reserved * 2, -1 + Rect_Top);
                g.DrawLine(new Pen(Rect_Color), pleft, pright);
            }
            {
                //bottom
                Point pleft = new Point(reserved, this.Height - Rect_Top - Rect_Bottom);
                Point pright = new Point(this.Width - reserved * 2, this.Height - Rect_Top - Rect_Bottom);
                g.DrawLine(new Pen(Rect_Color), pleft, pright);
            }
            {
                //left
                Point ptop = new Point(-1 + Rect_Left, reserved);
                Point pbottom = new Point(-1 + Rect_Left, this.Height - reserved * 2);
                g.DrawLine(new Pen(Rect_Color), ptop, pbottom);
            }
            {
                //Right
                Point ptop = new Point(this.Width - Rect_Right, reserved);
                Point pbottom = new Point(this.Width - Rect_Right, this.Height - reserved * 2);
                g.DrawLine(new Pen(Rect_Color), ptop, pbottom);
            }

        }
        private void ImgLabel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.SmoothingMode = SmoothingMode.HighQuality;

            int top_jg = 3;

            Rectangle rect = this.ClientRectangle;

            DrawHelper.FillRoundRectangle(g, new SolidBrush(this.Original_BackColor), rect, CornerRadius);

            //画边框
            DrawBorder(g);

            Rectangle rect_img = new Rectangle();
            Rectangle rect_str = new Rectangle();

            CalculatedPosition(rect, top_jg, out rect_img, out rect_str);

            StringFormat sf = new StringFormat()
            {
                Alignment = Level_SF,
                LineAlignment = Vertical_SF,
            };

            if (Label_Image == null)
            {
                g.DrawString(Content, this.Font, new SolidBrush(this.Original_ForeColor), rect, sf);
            }
            else
            {
                g.DrawImage(Label_Image, rect_img);
                g.DrawString(Content, this.Font, new SolidBrush(this.Original_ForeColor), rect_str, sf);
            }
        }

        private void ImgLabel_MouseEnter(object sender, EventArgs e)
        {
            if (Temp_BackColor == Color.Transparent && Temp_ForeColor == Color.Transparent)
            {
                Temp_BackColor = Original_BackColor;
                Temp_ForeColor = Original_ForeColor;
            }

            Original_BackColor = Move_BackColor;
            Original_ForeColor = Move_ForeColor;

            if (!string.IsNullOrEmpty(this.ToolString))
            {
                ToolTip toolTip = new ToolTip();
                toolTip.AutoPopDelay = 5000;
                toolTip.InitialDelay = 500;
                toolTip.ReshowDelay = 300;
                toolTip.ShowAlways = true;
                toolTip.SetToolTip(this, ToolString);
            }
            this.Refresh();
        }

        private void ImgLabel_MouseLeave(object sender, EventArgs e)
        {
            if (!is_select)
            {
                Original_BackColor = Temp_BackColor;
                Original_ForeColor = Temp_ForeColor;

                Temp_BackColor = Color.Transparent;
                Temp_ForeColor = Color.Transparent;
            }
            this.Refresh();
        }

        private void ImgLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (is_select_enable)
            {
                is_select = !is_select;
            }

            if (is_select == true && !string.IsNullOrEmpty(group_name))
            {
                foreach (Control con in this.Parent.Controls)
                {
                    ImgLabel btn = con as ImgLabel;
                    if (btn == null) continue;

                    if (group_name.Equals(btn.group_name) && btn != this)
                    {
                        btn.is_select = false;
                        btn.SimMouseMove();
                    }
                }
            }

            this.Parent.Refresh();
            this.Refresh();
        }


        private void ImgLabel_BackColorChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
            this.Refresh();
        }


        public void SimClick()
        {
            ImgLabel_MouseEnter(null, null);
            ImgLabel_MouseDown(null, null);
            base.OnClick(null);
        }
        public void SimMouseClick()
        {
            ImgLabel_MouseEnter(null, null);
            ImgLabel_MouseDown(null, null);
            base.OnMouseClick(null);
        }

        public void SimMouseMove()
        {
            ImgLabel_MouseEnter(null, null);
            ImgLabel_MouseLeave(null, null);
            base.OnMouseMove(null);
        }

    }
}
