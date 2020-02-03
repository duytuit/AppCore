using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Data.Entities.System
{
    class HistoryResetPassword
    {
        public string HistoryresetID { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string IPtruycap { get; set; }
        public string Thietbitruycap { get; set; }
        public bool Tinhtrang { get; set; }
        public string Ngayreset { get; set; }
    }
}
