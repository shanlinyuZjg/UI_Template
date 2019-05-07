using DB;
using UI_SplitControl.Extension;
using UI_SplitControl.Helper;
using UI_SplitControl.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace UI_SplitControl.BLL
{
    public class SupVipBLL
    {

        public void TestConnection()
        {
            IDB db = new DBByAutoClose(AppSetting.con);

            db.ExecuteScalar("SELECT GETDATE()");
        }

        public sa_t_operator_i GetOper(string oper_id)
        {
            sa_t_operator_i oper = null;

            IDB db = new DBByAutoClose(AppSetting.con);

            string sql = $"SELECT * FROM dbo.sa_t_operator_i WHERE oper_id = '{oper_id}'";

            oper = db.ExecuteToModel<sa_t_operator_i>(sql);

            return oper;
        }

        public sa_t_operator_i Login(string oper_id, string oper_pwd)
        {
            IDB db = new DBByAutoClose(AppSetting.con);

            sa_t_operator_i oper = GetOper(oper_id);
            if (oper == null || string.IsNullOrEmpty(oper.oper_id))
            {
                throw new Exception($"帐户[{oper_id}]不存在");
            }

            if (oper.oper_pw != sec.des(oper_pwd) && !(string.IsNullOrEmpty(oper.oper_pw) && string.IsNullOrEmpty(oper_pwd)))
            {
                throw new Exception($"密码错误");
            }

            return oper;
        }

        public DataTable GetVip(string name, string money)
        {
            IDB db = new DBByAutoClose(AppSetting.con);

            string sql = $@" select  ROW_NUMBER() OVER(ORDER BY oper_date ) AS flow_id,*,'0' 'check' from (
SELECT f.vip_no, i.vip_name,i.vip_tel,i.vip_sex,SUM(f.sale_money) sale_money,i.oper_date
FROM dbo.pos_t_saleflow f
LEFT JOIN dbo.pos_t_vip_info i ON i.card_id = f.vip_no
LEFT JOIN dbo.pos_t_supervip_flow s ON s.vip_no = f.vip_no
WHERE f.vip_no IS NOT NULL AND f.vip_no <> '' AND s.vip_no IS NULL
and (i.vip_name like '%{name}%' or f.vip_no like '%{name}%' or i.vip_tel like '%{name}%' )  and YEAR (f.oper_date)='{DateTime.Now.Year}'
GROUP BY f.vip_no, i.vip_name,i.vip_tel,i.vip_sex,i.oper_date
HAVING SUM(f.sale_money) >= {money}
) t";
            DataTable tb = db.ExecuteToTable(sql);
            return tb;
        }
        public DataTable GetVip(DateTime time, string name, string money)
        {
            IDB db = new DBByAutoClose(AppSetting.con);

            string sql = $@" select  ROW_NUMBER() OVER(ORDER BY oper_date ) AS flow_id,*,'0' 'check' from (
SELECT f.vip_no, i.vip_name,i.vip_tel,i.vip_sex,SUM(f.sale_money) sale_money,i.oper_date
FROM dbo.pos_t_saleflow f
LEFT JOIN dbo.pos_t_vip_info i ON i.card_id = f.vip_no
LEFT JOIN dbo.pos_t_supervip_flow s ON s.vip_no = f.vip_no
WHERE f.vip_no IS NOT NULL AND f.vip_no <> '' AND s.vip_no IS NULL
and (i.vip_name like '%{name}%' or f.vip_no like '%{name}%' or i.vip_tel like '%{name}%' )  
and f.oper_date >= '{time.Toyyyy_MM_dd()}' and f.oper_date <= '{time.AddYears(1).Toyyyy_MM_dd()}'
GROUP BY f.vip_no, i.vip_name,i.vip_tel,i.vip_sex,i.oper_date
HAVING SUM(f.sale_money) >= {money}
) t";
            DataTable tb = db.ExecuteToTable(sql);
            return tb;
        }

        public DataTable GetSuperVip(string name, int vip_status)
        {
            IDB db = new DBByAutoClose(AppSetting.con);

            string sql = $@" select  ROW_NUMBER() OVER(ORDER BY oper_date ) AS flow_id,*from (
SELECT s.vip_no, i.vip_name,i.vip_tel,i.vip_sex,ISNULL(SUM(f.sale_money),0.00) sale_money,
i.oper_date,s.oper_date oper_date2 ,s.super_no
FROM dbo.pos_t_supervip_flow s
LEFT JOIN dbo.pos_t_vip_info i ON i.card_id = s.vip_no
LEFT JOIN dbo.pos_t_saleflow f ON f.vip_no=s.vip_no AND YEAR(f.oper_date)='2019'  
WHERE (i.vip_name like '%{name}%' or s.vip_no like '%{name}%' or i.vip_tel like '%{name}%' ) ";

            if (vip_status == 1)
            {
                sql += " and s.super_no <> '' ";
            }
            else if (vip_status == 2)
            {
                sql += " and s.super_no= '' ";
            }

            sql += $@" GROUP BY s.vip_no, i.vip_name,i.vip_tel,i.vip_sex,i.oper_date,s.oper_date ,s.super_no  ) t ";

            DataTable tb = db.ExecuteToTable(sql);
            return tb;
        }

        private int GetSupVipid(IDB db)
        {
            int id = 1;

            id = db.ExecuteScalar("select ISNULL(max(flow_id),0) from dbo.pos_t_supervip_flow").ToInt32();

            id++;

            return id;
        }

        public void UpgradeVip(DataTable tb)
        {
            DBByHandClose db = new DBByHandClose(AppSetting.con);
            IDB d = db;
            try
            {
                db.Open();
                db.BeginTran();

                foreach (DataRow dr in tb.Rows)
                {
                    string vip_no = dr["vip_no"].ToString();
                    if (string.IsNullOrEmpty(vip_no)) continue;
                    pos_t_supervip_flow flow = new pos_t_supervip_flow()
                    {
                        flow_id = GetSupVipid(d),
                        super_no = "",
                        tran_type = "0",
                        oper_id = AppSetting.frmIndex.Operator.oper_id,
                        vip_no = vip_no,
                        oper_date = DateTime.Now,
                        super_start_date = DateTime.Now,
                        super_end_date = new DateTime(2100, 1, 1),
                    };
                    d.Insert(flow);
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

        public void BindCard(string vip_no, string sup_no)
        {
            if (string.IsNullOrEmpty(sup_no))
            {
                throw new Exception("会员卡号不能为空");
            }

            IDB db = new DBByAutoClose(AppSetting.con);

            var count = db.ExecuteScalar($"SELECT COUNT(*) FROM dbo.pos_t_supervip_flow WHERE super_no='{sup_no}'").ToInt32();
            if (count > 0)
            {
                throw new Exception("该会员卡已绑卡");
            }

            pos_t_supervip_flow flow = db.ExecuteToModel<pos_t_supervip_flow>($" select * from pos_t_supervip_flow  where vip_no='{vip_no}' ");

            if (flow == null || string.IsNullOrEmpty(flow.vip_no))
            {
                throw new Exception("该会员未升级超级会员");
            }

            if (!string.IsNullOrEmpty(flow.super_no))
            {
                throw new Exception("该会员已绑定会员卡");
            }

            flow.super_no = sup_no;

            db.Update(flow, "flow_id,vip_no");
        }

        public void NoCardSupVip(string card_id, string vip_name, string vip_tel)
        {
            DBByHandClose db = new DBByHandClose(AppSetting.con);
            IDB d = db;
            try
            {
                db.Open();
                db.BeginTran();

                var count = d.ExecuteScalar($"select count(*) from dbo.pos_t_vip_info where card_id='{card_id}'").ToInt32();
                if (count > 0)
                {
                    throw new Exception($"会员:[{card_id}]已存在");
                }

                string sql = $@"INSERT INTO dbo.pos_t_vip_info
(
card_id,card_type,vip_name,vip_tel,oper_id,oper_date,card_status
)
VALUES
(  
'{card_id}','01','{vip_name}','{vip_tel}','{AppSetting.frmIndex.Operator.oper_id}',GETDATE(),'0'
)";
                d.ExecuteScalar(sql);

                pos_t_supervip_flow flow = new pos_t_supervip_flow()
                {
                    flow_id = GetSupVipid(d),
                    super_no = card_id,
                    tran_type = "0",
                    oper_id = AppSetting.frmIndex.Operator.oper_id,
                    vip_no = card_id,
                    oper_date = DateTime.Now,
                    super_start_date = DateTime.Now,
                    super_end_date = new DateTime(2100, 1, 1),
                };
                d.Insert(flow);


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
