using AppCore.Infrastructure.SharesKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppCore.Data.Entities.System
{
    [Table("PhanQuyens")]
    public class Sys008: DomainEntity<Guid>
    {
        public Sys008()
        {
        }

        public Sys008(string menuid, Guid nhomky_id, bool quyenXem, bool quyenThem, bool quyenCapNhap, bool quyenXoa)
        {
            Menuid = menuid;
            Nhomky_id = nhomky_id;
            this.quyenXem = quyenXem;
            this.quyenThem = quyenThem;
            this.quyenCapNhap = quyenCapNhap;
            this.quyenXoa = quyenXoa;
        }

        public string Menuid { get; set; }
        public Guid Nhomky_id { get; set; }

        public bool quyenXem { get; set; }

        public bool quyenThem { get; set; }

        public bool quyenCapNhap { get; set; }

        public bool quyenXoa { get; set; }
        public virtual Sys006 Sys006 { get; set; }
        public virtual Sys002 Sys002 { get; set; }
    }
}
