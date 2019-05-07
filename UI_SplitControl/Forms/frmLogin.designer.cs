namespace UI_SplitControl.Forms
{
    partial class frmLogin
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.imgLabel1 = new UI_SplitControl.cons.ImgLabel();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.imgLabel2 = new UI_SplitControl.cons.ImgLabel();
            this.txt_Pwd = new System.Windows.Forms.TextBox();
            this.cb_RemberPwd = new System.Windows.Forms.CheckBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.imgLabel1.SuspendLayout();
            this.imgLabel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(876, 584);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Login, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(188, 142);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(500, 300);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.imgLabel1);
            this.flowLayoutPanel1.Controls.Add(this.imgLabel2);
            this.flowLayoutPanel1.Controls.Add(this.cb_RemberPwd);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(500, 200);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // imgLabel1
            // 
            this.imgLabel1.BackColor = System.Drawing.Color.Transparent;
            this.imgLabel1.Content = null;
            this.imgLabel1.Controls.Add(this.txt_User);
            this.imgLabel1.CornerRadius = 1;
            this.imgLabel1.ForeColor = System.Drawing.Color.Black;
            this.imgLabel1.group_name = null;
            this.imgLabel1.Image_Dock = System.Windows.Forms.DockStyle.Left;
            this.imgLabel1.Image_Margin = 0;
            this.imgLabel1.is_select = true;
            this.imgLabel1.is_select_enable = false;
            this.imgLabel1.is_show_bord = true;
            this.imgLabel1.Label_Image = global::UI_SplitControl.Properties.Resources.帐户;
            this.imgLabel1.Label_ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgLabel1.Level_SF = System.Drawing.StringAlignment.Near;
            this.imgLabel1.Location = new System.Drawing.Point(50, 3);
            this.imgLabel1.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.imgLabel1.Move_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.imgLabel1.Move_ForeColor = System.Drawing.Color.Empty;
            this.imgLabel1.Name = "imgLabel1";
            this.imgLabel1.Original_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.imgLabel1.Original_ForeColor = System.Drawing.Color.Empty;
            this.imgLabel1.Rect_Bottom = 1;
            this.imgLabel1.Rect_Color = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(64)))));
            this.imgLabel1.Rect_Left = 0;
            this.imgLabel1.Rect_Reserved = 0;
            this.imgLabel1.Rect_Right = 0;
            this.imgLabel1.Rect_Top = 0;
            this.imgLabel1.Size = new System.Drawing.Size(388, 61);
            this.imgLabel1.TabIndex = 0;
            this.imgLabel1.ToolString = "";
            this.imgLabel1.Vertical_SF = System.Drawing.StringAlignment.Near;
            // 
            // txt_User
            // 
            this.txt_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.txt_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_User.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.txt_User.Location = new System.Drawing.Point(52, 17);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(333, 31);
            this.txt_User.TabIndex = 0;
            this.txt_User.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_User_KeyDown);
            // 
            // imgLabel2
            // 
            this.imgLabel2.BackColor = System.Drawing.Color.Transparent;
            this.imgLabel2.Content = null;
            this.imgLabel2.Controls.Add(this.txt_Pwd);
            this.imgLabel2.CornerRadius = 1;
            this.imgLabel2.ForeColor = System.Drawing.Color.Black;
            this.imgLabel2.group_name = null;
            this.imgLabel2.Image_Dock = System.Windows.Forms.DockStyle.Left;
            this.imgLabel2.Image_Margin = 0;
            this.imgLabel2.is_select = true;
            this.imgLabel2.is_select_enable = false;
            this.imgLabel2.is_show_bord = true;
            this.imgLabel2.Label_Image = global::UI_SplitControl.Properties.Resources.密码;
            this.imgLabel2.Label_ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgLabel2.Level_SF = System.Drawing.StringAlignment.Near;
            this.imgLabel2.Location = new System.Drawing.Point(50, 77);
            this.imgLabel2.Margin = new System.Windows.Forms.Padding(50, 10, 3, 3);
            this.imgLabel2.Move_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.imgLabel2.Move_ForeColor = System.Drawing.Color.Empty;
            this.imgLabel2.Name = "imgLabel2";
            this.imgLabel2.Original_BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.imgLabel2.Original_ForeColor = System.Drawing.Color.Empty;
            this.imgLabel2.Rect_Bottom = 1;
            this.imgLabel2.Rect_Color = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(64)))));
            this.imgLabel2.Rect_Left = 0;
            this.imgLabel2.Rect_Reserved = 0;
            this.imgLabel2.Rect_Right = 0;
            this.imgLabel2.Rect_Top = 0;
            this.imgLabel2.Size = new System.Drawing.Size(388, 61);
            this.imgLabel2.TabIndex = 1;
            this.imgLabel2.ToolString = "";
            this.imgLabel2.Vertical_SF = System.Drawing.StringAlignment.Near;
            // 
            // txt_Pwd
            // 
            this.txt_Pwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.txt_Pwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Pwd.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.txt_Pwd.Location = new System.Drawing.Point(52, 17);
            this.txt_Pwd.Name = "txt_Pwd";
            this.txt_Pwd.PasswordChar = '*';
            this.txt_Pwd.Size = new System.Drawing.Size(333, 31);
            this.txt_Pwd.TabIndex = 1;
            this.txt_Pwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Pwd_KeyDown);
            // 
            // cb_RemberPwd
            // 
            this.cb_RemberPwd.AutoSize = true;
            this.cb_RemberPwd.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.cb_RemberPwd.Location = new System.Drawing.Point(50, 161);
            this.cb_RemberPwd.Margin = new System.Windows.Forms.Padding(50, 20, 3, 3);
            this.cb_RemberPwd.Name = "cb_RemberPwd";
            this.cb_RemberPwd.Size = new System.Drawing.Size(123, 34);
            this.cb_RemberPwd.TabIndex = 2;
            this.cb_RemberPwd.Text = "记住密码";
            this.cb_RemberPwd.UseVisualStyleBackColor = true;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(158)))), ((int)(((byte)(67)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(120, 240);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(120, 40, 3, 3);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(208, 55);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "登     录";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(876, 584);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.imgLabel1.ResumeLayout(false);
            this.imgLabel1.PerformLayout();
            this.imgLabel2.ResumeLayout(false);
            this.imgLabel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private cons.ImgLabel imgLabel1;
        private System.Windows.Forms.TextBox txt_User;
        private cons.ImgLabel imgLabel2;
        private System.Windows.Forms.TextBox txt_Pwd;
        private System.Windows.Forms.CheckBox cb_RemberPwd;
        private System.Windows.Forms.Button btn_Login;
    }
}