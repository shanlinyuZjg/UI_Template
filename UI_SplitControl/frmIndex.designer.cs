namespace UI_SplitControl
{
    partial class frmIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIndex));
            this.pl_Panernt = new UI_SplitControl.cons.MyPanel();
            this.pl_Main = new UI_SplitControl.cons.MyPanel();
            this.pl_Left = new UI_SplitControl.cons.MyPanel();
            this.btn_Exit = new UI_SplitControl.cons.ImgLabel();
            this.btn_Setting = new UI_SplitControl.cons.ImgLabel();
            this.btn_SuperVip = new UI_SplitControl.cons.ImgLabel();
            this.pl_Logo = new UI_SplitControl.cons.MyPanel();
            this.img_User = new UI_SplitControl.cons.ImgLabel();
            this.btn_Login = new UI_SplitControl.cons.ImgLabel();
            this.ui_top = new UI_SplitControl.cons.UIFromTop();
            this.pl_Panernt.SuspendLayout();
            this.pl_Left.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_Panernt
            // 
            this.pl_Panernt.Content = null;
            this.pl_Panernt.Content2 = null;
            this.pl_Panernt.Content3 = null;
            this.pl_Panernt.Controls.Add(this.pl_Main);
            this.pl_Panernt.Controls.Add(this.pl_Left);
            this.pl_Panernt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_Panernt.Image = null;
            this.pl_Panernt.Location = new System.Drawing.Point(2, 41);
            this.pl_Panernt.Name = "pl_Panernt";
            this.pl_Panernt.Size = new System.Drawing.Size(1314, 702);
            this.pl_Panernt.TabIndex = 2;
            // 
            // pl_Main
            // 
            this.pl_Main.Content = null;
            this.pl_Main.Content2 = null;
            this.pl_Main.Content3 = null;
            this.pl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_Main.Image = null;
            this.pl_Main.Location = new System.Drawing.Point(216, 0);
            this.pl_Main.Name = "pl_Main";
            this.pl_Main.Size = new System.Drawing.Size(1098, 702);
            this.pl_Main.TabIndex = 2;
            // 
            // pl_Left
            // 
            this.pl_Left.BackColor = System.Drawing.Color.White;
            this.pl_Left.Content = null;
            this.pl_Left.Content2 = null;
            this.pl_Left.Content3 = null;
            this.pl_Left.Controls.Add(this.btn_Exit);
            this.pl_Left.Controls.Add(this.btn_Setting);
            this.pl_Left.Controls.Add(this.btn_SuperVip);
            this.pl_Left.Controls.Add(this.pl_Logo);
            this.pl_Left.Controls.Add(this.img_User);
            this.pl_Left.Controls.Add(this.btn_Login);
            this.pl_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl_Left.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.pl_Left.Image = null;
            this.pl_Left.Location = new System.Drawing.Point(0, 0);
            this.pl_Left.Name = "pl_Left";
            this.pl_Left.Size = new System.Drawing.Size(216, 702);
            this.pl_Left.TabIndex = 1;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.Content = "    退出";
            this.btn_Exit.CornerRadius = 6;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_Exit.group_name = "ui_left";
            this.btn_Exit.Image_Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Exit.Image_Margin = 0;
            this.btn_Exit.is_select = false;
            this.btn_Exit.is_select_enable = true;
            this.btn_Exit.is_show_bord = false;
            this.btn_Exit.Label_Image = global::UI_SplitControl.Properties.Resources.退出;
            this.btn_Exit.Label_ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Exit.Level_SF = System.Drawing.StringAlignment.Near;
            this.btn_Exit.Location = new System.Drawing.Point(14, 427);
            this.btn_Exit.Move_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(174)))));
            this.btn_Exit.Move_ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Original_BackColor = System.Drawing.Color.White;
            this.btn_Exit.Original_ForeColor = System.Drawing.Color.Black;
            this.btn_Exit.Rect_Bottom = 0;
            this.btn_Exit.Rect_Color = System.Drawing.Color.Empty;
            this.btn_Exit.Rect_Left = 0;
            this.btn_Exit.Rect_Reserved = 0D;
            this.btn_Exit.Rect_Right = 0;
            this.btn_Exit.Rect_Top = 0;
            this.btn_Exit.Size = new System.Drawing.Size(183, 44);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.ToolString = "";
            this.btn_Exit.Vertical_SF = System.Drawing.StringAlignment.Center;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Setting
            // 
            this.btn_Setting.BackColor = System.Drawing.Color.Transparent;
            this.btn_Setting.Content = "    设置";
            this.btn_Setting.CornerRadius = 6;
            this.btn_Setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Setting.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_Setting.group_name = "ui_left";
            this.btn_Setting.Image_Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Setting.Image_Margin = 0;
            this.btn_Setting.is_select = false;
            this.btn_Setting.is_select_enable = true;
            this.btn_Setting.is_show_bord = false;
            this.btn_Setting.Label_Image = global::UI_SplitControl.Properties.Resources.设置;
            this.btn_Setting.Label_ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Setting.Level_SF = System.Drawing.StringAlignment.Near;
            this.btn_Setting.Location = new System.Drawing.Point(14, 377);
            this.btn_Setting.Move_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(174)))));
            this.btn_Setting.Move_ForeColor = System.Drawing.Color.White;
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Original_BackColor = System.Drawing.Color.White;
            this.btn_Setting.Original_ForeColor = System.Drawing.Color.Black;
            this.btn_Setting.Rect_Bottom = 0;
            this.btn_Setting.Rect_Color = System.Drawing.Color.Empty;
            this.btn_Setting.Rect_Left = 0;
            this.btn_Setting.Rect_Reserved = 0D;
            this.btn_Setting.Rect_Right = 0;
            this.btn_Setting.Rect_Top = 0;
            this.btn_Setting.Size = new System.Drawing.Size(183, 44);
            this.btn_Setting.TabIndex = 4;
            this.btn_Setting.ToolString = "";
            this.btn_Setting.Vertical_SF = System.Drawing.StringAlignment.Center;
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            // 
            // btn_SuperVip
            // 
            this.btn_SuperVip.BackColor = System.Drawing.Color.Transparent;
            this.btn_SuperVip.Content = "    超级会员";
            this.btn_SuperVip.CornerRadius = 6;
            this.btn_SuperVip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SuperVip.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_SuperVip.group_name = "ui_left";
            this.btn_SuperVip.Image_Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_SuperVip.Image_Margin = 0;
            this.btn_SuperVip.is_select = false;
            this.btn_SuperVip.is_select_enable = true;
            this.btn_SuperVip.is_show_bord = false;
            this.btn_SuperVip.Label_Image = global::UI_SplitControl.Properties.Resources.超级会员;
            this.btn_SuperVip.Label_ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_SuperVip.Level_SF = System.Drawing.StringAlignment.Near;
            this.btn_SuperVip.Location = new System.Drawing.Point(14, 327);
            this.btn_SuperVip.Move_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(174)))));
            this.btn_SuperVip.Move_ForeColor = System.Drawing.Color.White;
            this.btn_SuperVip.Name = "btn_SuperVip";
            this.btn_SuperVip.Original_BackColor = System.Drawing.Color.White;
            this.btn_SuperVip.Original_ForeColor = System.Drawing.Color.Black;
            this.btn_SuperVip.Rect_Bottom = 0;
            this.btn_SuperVip.Rect_Color = System.Drawing.Color.Empty;
            this.btn_SuperVip.Rect_Left = 0;
            this.btn_SuperVip.Rect_Reserved = 0D;
            this.btn_SuperVip.Rect_Right = 0;
            this.btn_SuperVip.Rect_Top = 0;
            this.btn_SuperVip.Size = new System.Drawing.Size(183, 44);
            this.btn_SuperVip.TabIndex = 3;
            this.btn_SuperVip.ToolString = "";
            this.btn_SuperVip.Vertical_SF = System.Drawing.StringAlignment.Center;
            this.btn_SuperVip.Click += new System.EventHandler(this.btn_SuperVip_Click);
            // 
            // pl_Logo
            // 
            this.pl_Logo.BackgroundImage = global::UI_SplitControl.Properties.Resources.横LOGO;
            this.pl_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pl_Logo.Content = null;
            this.pl_Logo.Content2 = null;
            this.pl_Logo.Content3 = null;
            this.pl_Logo.Image = null;
            this.pl_Logo.Location = new System.Drawing.Point(5, 9);
            this.pl_Logo.Name = "pl_Logo";
            this.pl_Logo.Size = new System.Drawing.Size(203, 70);
            this.pl_Logo.TabIndex = 1;
            // 
            // img_User
            // 
            this.img_User.BackColor = System.Drawing.Color.Transparent;
            this.img_User.Content = "未登录";
            this.img_User.CornerRadius = 1;
            this.img_User.Enabled = false;
            this.img_User.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.img_User.ForeColor = System.Drawing.Color.Black;
            this.img_User.group_name = null;
            this.img_User.Image_Dock = System.Windows.Forms.DockStyle.Top;
            this.img_User.Image_Margin = 0;
            this.img_User.is_select = false;
            this.img_User.is_select_enable = false;
            this.img_User.is_show_bord = false;
            this.img_User.Label_Image = global::UI_SplitControl.Properties.Resources.用户;
            this.img_User.Label_ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.img_User.Level_SF = System.Drawing.StringAlignment.Center;
            this.img_User.Location = new System.Drawing.Point(31, 118);
            this.img_User.Move_BackColor = System.Drawing.Color.Empty;
            this.img_User.Move_ForeColor = System.Drawing.Color.Black;
            this.img_User.Name = "img_User";
            this.img_User.Original_BackColor = System.Drawing.Color.Empty;
            this.img_User.Original_ForeColor = System.Drawing.Color.Black;
            this.img_User.Rect_Bottom = 0;
            this.img_User.Rect_Color = System.Drawing.Color.Empty;
            this.img_User.Rect_Left = 0;
            this.img_User.Rect_Reserved = 0D;
            this.img_User.Rect_Right = 0;
            this.img_User.Rect_Top = 0;
            this.img_User.Size = new System.Drawing.Size(140, 115);
            this.img_User.TabIndex = 2;
            this.img_User.ToolString = "";
            this.img_User.Vertical_SF = System.Drawing.StringAlignment.Far;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.btn_Login.Content = "    登录";
            this.btn_Login.CornerRadius = 6;
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_Login.group_name = "ui_left";
            this.btn_Login.Image_Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Login.Image_Margin = 0;
            this.btn_Login.is_select = false;
            this.btn_Login.is_select_enable = true;
            this.btn_Login.is_show_bord = false;
            this.btn_Login.Label_Image = global::UI_SplitControl.Properties.Resources.登录;
            this.btn_Login.Label_ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Login.Level_SF = System.Drawing.StringAlignment.Near;
            this.btn_Login.Location = new System.Drawing.Point(14, 277);
            this.btn_Login.Move_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(174)))));
            this.btn_Login.Move_ForeColor = System.Drawing.Color.White;
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Original_BackColor = System.Drawing.Color.White;
            this.btn_Login.Original_ForeColor = System.Drawing.Color.Black;
            this.btn_Login.Rect_Bottom = 0;
            this.btn_Login.Rect_Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Login.Rect_Left = 0;
            this.btn_Login.Rect_Reserved = 0D;
            this.btn_Login.Rect_Right = 0;
            this.btn_Login.Rect_Top = 0;
            this.btn_Login.Size = new System.Drawing.Size(183, 44);
            this.btn_Login.TabIndex = 1;
            this.btn_Login.ToolString = "";
            this.btn_Login.Vertical_SF = System.Drawing.StringAlignment.Center;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // ui_top
            // 
            this.ui_top.BackColor = System.Drawing.Color.White;
            this.ui_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.ui_top.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.ui_top.Frm_Icon = ((System.Drawing.Icon)(resources.GetObject("ui_top.Frm_Icon")));
            this.ui_top.Location = new System.Drawing.Point(2, 2);
            this.ui_top.Margin = new System.Windows.Forms.Padding(0);
            this.ui_top.MaximizeBox = true;
            this.ui_top.MinimizeBox = true;
            this.ui_top.Name = "ui_top";
            this.ui_top.ShowIco = true;
            this.ui_top.Size = new System.Drawing.Size(1314, 39);
            this.ui_top.TabIndex = 1;
            this.ui_top.Title = "超级会员";
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1318, 744);
            this.Controls.Add(this.pl_Panernt);
            this.Controls.Add(this.ui_top);
            this.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmIndex";
            this.Padding = new System.Windows.Forms.Padding(2, 2, 2, 1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIndex";
            this.Load += new System.EventHandler(this.frmIndex_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmIndex_Paint);
            this.pl_Panernt.ResumeLayout(false);
            this.pl_Left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private cons.UIFromTop ui_top;
        private cons.MyPanel pl_Panernt;
        private cons.MyPanel pl_Left;
        private cons.MyPanel pl_Logo;
        private cons.ImgLabel img_User;
        private cons.ImgLabel btn_Login;
        private cons.MyPanel pl_Main;
        private cons.ImgLabel btn_SuperVip;
        private cons.ImgLabel btn_Setting;
        private cons.ImgLabel btn_Exit;
    }
}