namespace UI_SplitControl.Forms
{
    partial class frmSuperVip
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tb_Main = new System.Windows.Forms.TabControl();
            this.tp_SupVip = new System.Windows.Forms.TabPage();
            this.dgv_Vip = new System.Windows.Forms.DataGridView();
            this.flow_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vip_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vip_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vip_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.super_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oper_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oper_date2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pl_MainTop = new UI_SplitControl.cons.MyPanel();
            this.flp_Where = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.btn_Select = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_UpgradeVip = new UI_SplitControl.cons.ImgLabel();
            this.tb_Main.SuspendLayout();
            this.tp_SupVip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vip)).BeginInit();
            this.pl_MainTop.SuspendLayout();
            this.flp_Where.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Main
            // 
            this.tb_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Main.Controls.Add(this.tp_SupVip);
            this.tb_Main.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.tb_Main.ItemSize = new System.Drawing.Size(0, 1);
            this.tb_Main.Location = new System.Drawing.Point(-6, 43);
            this.tb_Main.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Main.Name = "tb_Main";
            this.tb_Main.Padding = new System.Drawing.Point(0, 0);
            this.tb_Main.SelectedIndex = 0;
            this.tb_Main.Size = new System.Drawing.Size(1131, 706);
            this.tb_Main.TabIndex = 0;
            // 
            // tp_SupVip
            // 
            this.tp_SupVip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.tp_SupVip.Controls.Add(this.dgv_Vip);
            this.tp_SupVip.Controls.Add(this.pl_MainTop);
            this.tp_SupVip.Location = new System.Drawing.Point(4, 5);
            this.tp_SupVip.Margin = new System.Windows.Forms.Padding(0);
            this.tp_SupVip.Name = "tp_SupVip";
            this.tp_SupVip.Padding = new System.Windows.Forms.Padding(10, 8, 15, 5);
            this.tp_SupVip.Size = new System.Drawing.Size(1123, 697);
            this.tp_SupVip.TabIndex = 0;
            // 
            // dgv_Vip
            // 
            this.dgv_Vip.AllowUserToAddRows = false;
            this.dgv_Vip.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgv_Vip.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Vip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Vip.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Vip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Vip.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Vip.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Vip.ColumnHeadersHeight = 45;
            this.dgv_Vip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flow_id,
            this.vip_no,
            this.vip_name,
            this.vip_tel,
            this.super_no,
            this.oper_date,
            this.oper_date2,
            this.sale_money});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Vip.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Vip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Vip.Location = new System.Drawing.Point(10, 61);
            this.dgv_Vip.MultiSelect = false;
            this.dgv_Vip.Name = "dgv_Vip";
            this.dgv_Vip.ReadOnly = true;
            this.dgv_Vip.RowHeadersVisible = false;
            this.dgv_Vip.RowHeadersWidth = 50;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 11F);
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Vip.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Vip.RowTemplate.Height = 30;
            this.dgv_Vip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Vip.Size = new System.Drawing.Size(1098, 631);
            this.dgv_Vip.TabIndex = 0;
            // 
            // flow_id
            // 
            this.flow_id.DataPropertyName = "flow_id";
            this.flow_id.FillWeight = 60F;
            this.flow_id.HeaderText = "序号";
            this.flow_id.Name = "flow_id";
            this.flow_id.ReadOnly = true;
            // 
            // vip_no
            // 
            this.vip_no.DataPropertyName = "vip_no";
            this.vip_no.FillWeight = 150F;
            this.vip_no.HeaderText = "会员号";
            this.vip_no.Name = "vip_no";
            this.vip_no.ReadOnly = true;
            // 
            // vip_name
            // 
            this.vip_name.DataPropertyName = "vip_name";
            this.vip_name.FillWeight = 150F;
            this.vip_name.HeaderText = "会员名称";
            this.vip_name.Name = "vip_name";
            this.vip_name.ReadOnly = true;
            // 
            // vip_tel
            // 
            this.vip_tel.DataPropertyName = "vip_tel";
            this.vip_tel.FillWeight = 150F;
            this.vip_tel.HeaderText = "会员电话";
            this.vip_tel.Name = "vip_tel";
            this.vip_tel.ReadOnly = true;
            // 
            // super_no
            // 
            this.super_no.DataPropertyName = "super_no";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            this.super_no.DefaultCellStyle = dataGridViewCellStyle3;
            this.super_no.FillWeight = 150F;
            this.super_no.HeaderText = "会员卡号";
            this.super_no.Name = "super_no";
            this.super_no.ReadOnly = true;
            // 
            // oper_date
            // 
            this.oper_date.DataPropertyName = "oper_date";
            this.oper_date.FillWeight = 150F;
            this.oper_date.HeaderText = "创建日期";
            this.oper_date.Name = "oper_date";
            this.oper_date.ReadOnly = true;
            // 
            // oper_date2
            // 
            this.oper_date2.DataPropertyName = "oper_date2";
            this.oper_date2.FillWeight = 150F;
            this.oper_date2.HeaderText = "升级日期";
            this.oper_date2.Name = "oper_date2";
            this.oper_date2.ReadOnly = true;
            // 
            // sale_money
            // 
            this.sale_money.DataPropertyName = "sale_money";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "0.00";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.sale_money.DefaultCellStyle = dataGridViewCellStyle4;
            this.sale_money.FillWeight = 150F;
            this.sale_money.HeaderText = "消费金额";
            this.sale_money.Name = "sale_money";
            this.sale_money.ReadOnly = true;
            // 
            // pl_MainTop
            // 
            this.pl_MainTop.Content = null;
            this.pl_MainTop.Content2 = null;
            this.pl_MainTop.Content3 = null;
            this.pl_MainTop.Controls.Add(this.flp_Where);
            this.pl_MainTop.Controls.Add(this.btn_Select);
            this.pl_MainTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_MainTop.Image = null;
            this.pl_MainTop.Location = new System.Drawing.Point(10, 8);
            this.pl_MainTop.Name = "pl_MainTop";
            this.pl_MainTop.Size = new System.Drawing.Size(1098, 53);
            this.pl_MainTop.TabIndex = 2;
            // 
            // flp_Where
            // 
            this.flp_Where.Controls.Add(this.label1);
            this.flp_Where.Controls.Add(this.txt_Name);
            this.flp_Where.Controls.Add(this.label8);
            this.flp_Where.Controls.Add(this.cb_Status);
            this.flp_Where.Dock = System.Windows.Forms.DockStyle.Left;
            this.flp_Where.Location = new System.Drawing.Point(0, 0);
            this.flp_Where.Name = "flp_Where";
            this.flp_Where.Size = new System.Drawing.Size(617, 53);
            this.flp_Where.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "关键字:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(120, 12);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(188, 29);
            this.txt_Name.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(314, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 52);
            this.label8.TabIndex = 2;
            this.label8.Text = "会员状态:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_Status
            // 
            this.cb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Status.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "全部",
            "已领卡",
            "未领卡"});
            this.cb_Status.Location = new System.Drawing.Point(431, 10);
            this.cb_Status.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(167, 31);
            this.cb_Status.TabIndex = 3;
            // 
            // btn_Select
            // 
            this.btn_Select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(158)))), ((int)(((byte)(67)))));
            this.btn_Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Select.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_Select.ForeColor = System.Drawing.Color.White;
            this.btn_Select.Location = new System.Drawing.Point(774, 4);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(120, 42);
            this.btn_Select.TabIndex = 4;
            this.btn_Select.Text = "查    询";
            this.btn_Select.UseVisualStyleBackColor = false;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Controls.Add(this.btn_UpgradeVip);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1116, 54);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btn_UpgradeVip
            // 
            this.btn_UpgradeVip.BackColor = System.Drawing.Color.Transparent;
            this.btn_UpgradeVip.Content = "升级会员";
            this.btn_UpgradeVip.CornerRadius = 1;
            this.btn_UpgradeVip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UpgradeVip.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_UpgradeVip.group_name = "tab_top";
            this.btn_UpgradeVip.Image_Dock = System.Windows.Forms.DockStyle.None;
            this.btn_UpgradeVip.Image_Margin = 0;
            this.btn_UpgradeVip.is_select = false;
            this.btn_UpgradeVip.is_select_enable = true;
            this.btn_UpgradeVip.is_show_bord = true;
            this.btn_UpgradeVip.Label_Image = null;
            this.btn_UpgradeVip.Label_ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_UpgradeVip.Level_SF = System.Drawing.StringAlignment.Center;
            this.btn_UpgradeVip.Location = new System.Drawing.Point(3, 3);
            this.btn_UpgradeVip.Move_BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_UpgradeVip.Move_ForeColor = System.Drawing.Color.Black;
            this.btn_UpgradeVip.Name = "btn_UpgradeVip";
            this.btn_UpgradeVip.Original_BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_UpgradeVip.Original_ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btn_UpgradeVip.Rect_Bottom = 1;
            this.btn_UpgradeVip.Rect_Color = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(64)))));
            this.btn_UpgradeVip.Rect_Left = 0;
            this.btn_UpgradeVip.Rect_Reserved = 2D;
            this.btn_UpgradeVip.Rect_Right = 0;
            this.btn_UpgradeVip.Rect_Top = 0;
            this.btn_UpgradeVip.Size = new System.Drawing.Size(75, 47);
            this.btn_UpgradeVip.TabIndex = 0;
            this.btn_UpgradeVip.ToolString = "";
            this.btn_UpgradeVip.Vertical_SF = System.Drawing.StringAlignment.Center;
            this.btn_UpgradeVip.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Tab_MouseClick);
            // 
            // frmSuperVip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1116, 746);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tb_Main);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSuperVip";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSuperVip";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSuperVip_FormClosing);
            this.Load += new System.EventHandler(this.frmSuperVip_Load);
            this.tb_Main.ResumeLayout(false);
            this.tp_SupVip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vip)).EndInit();
            this.pl_MainTop.ResumeLayout(false);
            this.flp_Where.ResumeLayout(false);
            this.flp_Where.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tb_Main;
        private System.Windows.Forms.TabPage tp_SupVip;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private cons.ImgLabel btn_UpgradeVip;
        private System.Windows.Forms.DataGridView dgv_Vip;
        private cons.MyPanel pl_MainTop;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn flow_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn vip_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn vip_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn vip_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn super_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn oper_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn oper_date2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_money;
        private System.Windows.Forms.FlowLayoutPanel flp_Where;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_Status;
    }
}