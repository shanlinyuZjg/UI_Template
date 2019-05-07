
namespace UI_SplitControl.cons
{
    partial class UIFromTop
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIFromTop));
            this.pl_Top = new UI_SplitControl.cons.MyPanel();
            this.pic_Min = new System.Windows.Forms.PictureBox();
            this.pic_Max = new System.Windows.Forms.PictureBox();
            this.pic_Close = new System.Windows.Forms.PictureBox();
            this.pl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_Top
            // 
            this.pl_Top.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pl_Top.Content = null;
            this.pl_Top.Content2 = null;
            this.pl_Top.Content3 = null;
            this.pl_Top.Controls.Add(this.pic_Min);
            this.pl_Top.Controls.Add(this.pic_Max);
            this.pl_Top.Controls.Add(this.pic_Close);
            this.pl_Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_Top.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pl_Top.Image = null;
            this.pl_Top.Location = new System.Drawing.Point(0, 0);
            this.pl_Top.Name = "pl_Top";
            this.pl_Top.Padding = new System.Windows.Forms.Padding(1);
            this.pl_Top.Size = new System.Drawing.Size(573, 42);
            this.pl_Top.TabIndex = 1;
            this.pl_Top.Paint += new System.Windows.Forms.PaintEventHandler(this.pl_Top_Paint);
            this.pl_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pl_Top_MouseDown);
            this.pl_Top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pl_Top_MouseMove);
            this.pl_Top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pl_Top_MouseUp);
            // 
            // pic_Min
            // 
            this.pic_Min.BackColor = System.Drawing.Color.Transparent;
            this.pic_Min.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_Min.Image = ((System.Drawing.Image)(resources.GetObject("pic_Min.Image")));
            this.pic_Min.Location = new System.Drawing.Point(437, 1);
            this.pic_Min.Margin = new System.Windows.Forms.Padding(0);
            this.pic_Min.Name = "pic_Min";
            this.pic_Min.Size = new System.Drawing.Size(45, 40);
            this.pic_Min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_Min.TabIndex = 3;
            this.pic_Min.TabStop = false;
            this.pic_Min.Click += new System.EventHandler(this.pic_Min_Click);
            this.pic_Min.MouseEnter += new System.EventHandler(this.ui_pic_MouseEnter);
            this.pic_Min.MouseLeave += new System.EventHandler(this.ui_pic__MouseLeave);
            // 
            // pic_Max
            // 
            this.pic_Max.BackColor = System.Drawing.Color.Transparent;
            this.pic_Max.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_Max.Image = ((System.Drawing.Image)(resources.GetObject("pic_Max.Image")));
            this.pic_Max.Location = new System.Drawing.Point(482, 1);
            this.pic_Max.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.pic_Max.Name = "pic_Max";
            this.pic_Max.Size = new System.Drawing.Size(44, 40);
            this.pic_Max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_Max.TabIndex = 2;
            this.pic_Max.TabStop = false;
            this.pic_Max.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_Max_MouseClick);
            this.pic_Max.MouseEnter += new System.EventHandler(this.ui_pic_MouseEnter);
            this.pic_Max.MouseLeave += new System.EventHandler(this.ui_pic__MouseLeave);
            // 
            // pic_Close
            // 
            this.pic_Close.BackColor = System.Drawing.Color.Transparent;
            this.pic_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_Close.Image = ((System.Drawing.Image)(resources.GetObject("pic_Close.Image")));
            this.pic_Close.Location = new System.Drawing.Point(526, 1);
            this.pic_Close.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.pic_Close.Name = "pic_Close";
            this.pic_Close.Size = new System.Drawing.Size(46, 40);
            this.pic_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_Close.TabIndex = 1;
            this.pic_Close.TabStop = false;
            this.pic_Close.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_Close_MouseClick);
            this.pic_Close.MouseEnter += new System.EventHandler(this.pic_Close_MouseEnter);
            this.pic_Close.MouseLeave += new System.EventHandler(this.pic_Close_MouseLeave);
            // 
            // UIFromTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pl_Top);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UIFromTop";
            this.Size = new System.Drawing.Size(573, 42);
            this.pl_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyPanel pl_Top;
        private System.Windows.Forms.PictureBox pic_Close;
        private System.Windows.Forms.PictureBox pic_Min;
        private System.Windows.Forms.PictureBox pic_Max;
    }
}
