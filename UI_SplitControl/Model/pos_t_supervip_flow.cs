using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UI_SplitControl.Model
{
    [Serializable]
    public class pos_t_supervip_flow
    {
        public int flow_id { get; set; }
        public string vip_no { get; set; }
        public string super_no { get; set; }
        public DateTime super_start_date { get; set; }
        public DateTime super_end_date { get; set; }
        public DateTime oper_date { get; set; }
        public string oper_id { get; set; }
        public string tran_type { get; set; }
    }
}
