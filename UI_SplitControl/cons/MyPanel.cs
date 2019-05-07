using UI_SplitControl.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace UI_SplitControl.cons
{
    class MyPanel : System.Windows.Forms.Panel
    {
        public MyPanel()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
               ControlStyles.ResizeRedraw |
               ControlStyles.AllPaintingInWmPaint, true);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MyPanel
            // 
            this.ResumeLayout(false);

        }


        [Description("图片")]
        public Image Image { get; set; }
        [Description("内容")]
        public string Content { get; set; }
        [Description("内容2")]
        public string Content2 { get; set; }
        [Description("内容3")]
        public string Content3 { get; set; }

    }
}
