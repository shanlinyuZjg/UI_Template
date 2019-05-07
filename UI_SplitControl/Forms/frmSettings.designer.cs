namespace UI_SplitControl.Forms
{
    partial class frmSettings
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
            this.myPanel4 = new UI_SplitControl.cons.MyPanel();
            this.btn_TestDB = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.myPanel1 = new UI_SplitControl.cons.MyPanel();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.myPanel2 = new UI_SplitControl.cons.MyPanel();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.myPanel3 = new UI_SplitControl.cons.MyPanel();
            this.txt_DB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Locking = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.myPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.myPanel1.SuspendLayout();
            this.myPanel2.SuspendLayout();
            this.myPanel3.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1040, 672);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.myPanel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(270, 136);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(500, 400);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // myPanel4
            // 
            this.myPanel4.Content = null;
            this.myPanel4.Content2 = null;
            this.myPanel4.Content3 = null;
            this.myPanel4.Controls.Add(this.btn_TestDB);
            this.myPanel4.Controls.Add(this.btn_Login);
            this.myPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myPanel4.Image = null;
            this.myPanel4.Location = new System.Drawing.Point(3, 283);
            this.myPanel4.Name = "myPanel4";
            this.myPanel4.Size = new System.Drawing.Size(494, 114);
            this.myPanel4.TabIndex = 3;
            // 
            // btn_TestDB
            // 
            this.btn_TestDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(158)))), ((int)(((byte)(67)))));
            this.btn_TestDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TestDB.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.btn_TestDB.ForeColor = System.Drawing.Color.White;
            this.btn_TestDB.Location = new System.Drawing.Point(32, 37);
            this.btn_TestDB.Margin = new System.Windows.Forms.Padding(130, 40, 3, 3);
            this.btn_TestDB.Name = "btn_TestDB";
            this.btn_TestDB.Size = new System.Drawing.Size(208, 55);
            this.btn_TestDB.TabIndex = 2;
            this.btn_TestDB.Text = "测 试 连 接";
            this.btn_TestDB.UseVisualStyleBackColor = false;
            this.btn_TestDB.Click += new System.EventHandler(this.btn_TestDB_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(158)))), ((int)(((byte)(67)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(253, 37);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(130, 40, 3, 3);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(208, 55);
            this.btn_Login.TabIndex = 1;
            this.btn_Login.Text = "保    存";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.flowLayoutPanel1.Controls.Add(this.myPanel1);
            this.flowLayoutPanel1.Controls.Add(this.myPanel2);
            this.flowLayoutPanel1.Controls.Add(this.myPanel3);
            this.flowLayoutPanel1.Controls.Add(this.cb_Locking);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(500, 280);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // myPanel1
            // 
            this.myPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.myPanel1.Content = null;
            this.myPanel1.Content2 = null;
            this.myPanel1.Content3 = null;
            this.myPanel1.Controls.Add(this.txt_IP);
            this.myPanel1.Controls.Add(this.label1);
            this.myPanel1.Image = null;
            this.myPanel1.Location = new System.Drawing.Point(0, 0);
            this.myPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.myPanel1.Name = "myPanel1";
            this.myPanel1.Size = new System.Drawing.Size(497, 75);
            this.myPanel1.TabIndex = 2;
            // 
            // txt_IP
            // 
            this.txt_IP.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.txt_IP.Location = new System.Drawing.Point(117, 18);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(310, 38);
            this.txt_IP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // myPanel2
            // 
            this.myPanel2.Content = null;
            this.myPanel2.Content2 = null;
            this.myPanel2.Content3 = null;
            this.myPanel2.Controls.Add(this.txt_Port);
            this.myPanel2.Controls.Add(this.label2);
            this.myPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.myPanel2.Image = null;
            this.myPanel2.Location = new System.Drawing.Point(0, 75);
            this.myPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.myPanel2.Name = "myPanel2";
            this.myPanel2.Size = new System.Drawing.Size(497, 75);
            this.myPanel2.TabIndex = 3;
            // 
            // txt_Port
            // 
            this.txt_Port.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.txt_Port.Location = new System.Drawing.Point(117, 18);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(310, 38);
            this.txt_Port.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label2.Location = new System.Drawing.Point(9, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "端口:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // myPanel3
            // 
            this.myPanel3.Content = null;
            this.myPanel3.Content2 = null;
            this.myPanel3.Content3 = null;
            this.myPanel3.Controls.Add(this.txt_DB);
            this.myPanel3.Controls.Add(this.label3);
            this.myPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.myPanel3.Image = null;
            this.myPanel3.Location = new System.Drawing.Point(0, 150);
            this.myPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.myPanel3.Name = "myPanel3";
            this.myPanel3.Size = new System.Drawing.Size(497, 75);
            this.myPanel3.TabIndex = 5;
            // 
            // txt_DB
            // 
            this.txt_DB.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.txt_DB.Location = new System.Drawing.Point(117, 18);
            this.txt_DB.Name = "txt_DB";
            this.txt_DB.Size = new System.Drawing.Size(310, 38);
            this.txt_DB.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "数据库:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_Locking
            // 
            this.cb_Locking.AutoSize = true;
            this.cb_Locking.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.cb_Locking.Location = new System.Drawing.Point(120, 235);
            this.cb_Locking.Margin = new System.Windows.Forms.Padding(120, 10, 3, 3);
            this.cb_Locking.Name = "cb_Locking";
            this.cb_Locking.Size = new System.Drawing.Size(79, 34);
            this.cb_Locking.TabIndex = 4;
            this.cb_Locking.Text = "锁定";
            this.cb_Locking.UseVisualStyleBackColor = true;
            this.cb_Locking.CheckedChanged += new System.EventHandler(this.cb_Locking_CheckedChanged);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1040, 672);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSettings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.myPanel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.myPanel1.ResumeLayout(false);
            this.myPanel1.PerformLayout();
            this.myPanel2.ResumeLayout(false);
            this.myPanel2.PerformLayout();
            this.myPanel3.ResumeLayout(false);
            this.myPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private cons.MyPanel myPanel1;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.Label label1;
        private cons.MyPanel myPanel2;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_Locking;
        private cons.MyPanel myPanel3;
        private System.Windows.Forms.TextBox txt_DB;
        private System.Windows.Forms.Label label3;
        private cons.MyPanel myPanel4;
        private System.Windows.Forms.Button btn_TestDB;
    }
}