using DB;
using UI_SplitControl.Extension;
using UI_SplitControl.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UI_SplitControl.BLL
{
    public class SysBLL
    {
        public sys_t_system ReadSystem(string key)
        {
            IDB db = new DBByAutoClose(AppSetting.con);

            sys_t_system system = db.ExecuteToModel<sys_t_system>($"SELECT * FROM dbo.sys_t_system WHERE sys_var_id='{key}'");

            return system;
        }

        public void UpdateSys(string key, string value)
        {
            IDB db = new DBByAutoClose(AppSetting.con);

            var count = db.ExecuteScalar($"SELECT count(*) FROM dbo.sys_t_system WHERE sys_var_id='{key}'").ToInt32();
            if (count < 1)
            {
                throw new Exception("不存在该系统节点");
            }

            string sql = $"update dbo.sys_t_system set sys_var_value='{value}' , update_time='{DateTime.Now.Toyyyy_MM_dd_HH_mm_ss()}' " +
                               $"where sys_var_id='{key}' ";
            db.ExecuteScalar(sql);

        }


    }
}
