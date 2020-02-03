using AppCore.Data.Interfaces;
using AppCore.Infrastructure.Enums;
using AppCore.Infrastructure.SharesKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppCore.Data.Entities.System
{
    [Table("TrinhKys")]
    public class Sys003 : DomainEntity<Guid>, IDateTracking, ISwitchable, IOwner
    {
        public Sys003()
        {
        }

        public Sys003(Guid nhomky_id, Guid danhmucid, string tennhomky, string tendanhmuc, int kieutrinhky, DateTime ngaytao,
            DateTime? ngaycapnhap, DateTime? ngayhuy, DateTime? ngayhoanthanh, Status trangthai, string ghichu, string nguoitaoid, string nguoitao)
        {
            Nhomky_id = nhomky_id;
            Danhmucid = danhmucid;
            Tennhomky = tennhomky;
            Tendanhmuc = tendanhmuc;
            Kieutrinhky = kieutrinhky;
            Ngaytao = ngaytao;
            Ngaycapnhap = ngaycapnhap;
            Ngayhuy = ngayhuy;
            Ngayhoanthanh = ngayhoanthanh;
            Trangthai = trangthai;
            Ghichu = ghichu;
            Nguoitaoid = nguoitaoid;
            Nguoitao = nguoitao;
        }

        public Guid Nhomky_id { get; set; }
        public Guid Danhmucid { get; set; }
        public string Tennhomky { get; set; }
        public string Tendanhmuc { get; set; }

        public int Kieutrinhky { get; set; }
        public DateTime Ngaytao { get ; set ; }
        public DateTime? Ngaycapnhap { get ; set ; }
        public DateTime? Ngayhuy { get ; set ; }
        public DateTime? Ngayhoanthanh { get ; set ; }
        public Status Trangthai { get ; set ; }
        public string Ghichu { get ; set ; }
        public string Nguoitaoid { get ; set ; }
        public string Nguoitao { get ; set ; }
        public virtual Sys002 Sys002 { get; set; }
        public virtual Sys005 Sys005 { get; set; }
    }
}
