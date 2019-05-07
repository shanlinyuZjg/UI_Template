using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UI_SplitControl.Helper;

namespace UI_SplitControl
{
    public class AppSetting
    {
        public static frmIndex frmIndex;

        private static string _ip;
        public static string Ip
        {
            get
            {
                if (string.IsNullOrEmpty(_ip))
                {
                    _ip = InI.ReadValue("server", "ip");
                }
                return _ip;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    InI.Writue("server", "ip", value);
                    _ip = value;
                }
            }
        }

        private static string _port;
        public static string Port
        {
            get
            {
                if (string.IsNullOrEmpty(_port))
                {
                    _port = InI.ReadValue("server", "port");
                }
                return _port;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    InI.Writue("server", "port", value);
                    _port = value;
                }
            }
        }

        private static string _db;
        public static string Db
        {
            get
            {
                if (string.IsNullOrEmpty(_db))
                {
                    _db = InI.ReadValue("server", "db");
                }
                return _db;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    InI.Writue("server", "db", value);
                    _db = value;
                }
            }
        }

        private static string _con;
        public static string con
        {
            get
            {
                if (string.IsNullOrEmpty(_con))
                {
                    _con = $"user id=ivytalktm;password=346440713;initial catalog={Db}; data source={Ip},{Port}";
                }
                return _con;
            }
            set
            {
                _con = value;
            }
        }

    }
}
