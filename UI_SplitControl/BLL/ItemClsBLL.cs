using DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace UI_SplitControl.BLL
{
    public class ItemClsBLL
    {

        public DataTable GetItemCls()
        {
            IDB db = new DBByAutoClose(AppSetting.con);

            DataTable tb = db.ExecuteToTable(@"SELECT ROW_NUMBER() OVER(ORDER BY t.item_clsno ) AS flow_id,* FROM (
SELECT * ,'0' as 'check'
FROM dbo.bi_t_item_cls
WHERE item_flag = '0' 
) t");

            return tb;
        }

        public DataTable GetReiectCls()
        {
            IDB db = new DBByAutoClose(AppSetting.con);

            DataTable tb = db.ExecuteToTable(@"SELECT * 
FROM dbo.pos_t_supervip_rejectclass s
LEFT JOIN dbo.bi_t_item_cls c ON s.item_clsno = c.item_clsno");

            return tb;
        }

        public void UpdateReiectCls(DataTable table)
        {
            DBByHandClose db = new DBByHandClose(AppSetting.con);
            IDB d = db;
            try
            {
                db.Open();
                db.BeginTran();

                d.ExecuteScalar("delete from dbo.pos_t_supervip_rejectclass");

                int flow_id = 1;
                foreach (DataRow dr in table.Rows)
                {
                    d.ExecuteScalar($@"INSERT	INTO dbo.pos_t_supervip_rejectclass(flow_id,item_clsno)
VALUES ({flow_id},'{dr["item_clsno"]}')");
                    flow_id++;
                }

                db.CommitTran();
            }
            catch (Exception)
            {
                db.RollBackTran();
                throw;
            }
            finally
            {
                db.Close();
            }
        }

    }
}
