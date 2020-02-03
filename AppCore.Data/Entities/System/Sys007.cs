using AppCore.Data.Interfaces;
using AppCore.Infrastructure.Enums;
using AppCore.Infrastructure.SharesKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppCore.Data.Entities.System
{
    [Table("QuyTrinhs")]
    public class Sys007 : DomainEntity<Guid>, ISwitchable, ISortable, IHasSoftDelete, IDateTracking, IOwner
    {
        public Sys007()
        {
        }

        public Sys007(string groupid, Guid trinhky_id, int kieutrinhky, Status trangthai, int thutu, bool dahuy, DateTime ngaytao,
            DateTime? ngaycapnhap, DateTime? ngayhuy, DateTime? ngayhoanthanh, string ghichu, string nguoitaoid, string nguoitao)
        {
            Groupid = groupid;
            Trinhky_id = trinhky_id;
            Kieutrinhky = kieutrinhky;
            Trangthai = trangthai;
            Thutu = thutu;
            Dahuy = dahuy;
            Ngaytao = ngaytao;
            Ngaycapnhap = ngaycapnhap;
            Ngayhuy = ngayhuy;
            Ngayhoanthanh = ngayhoanthanh;
            Ghichu = ghichu;
            Nguoitaoid = nguoitaoid;
            Nguoitao = nguoitao;
        }

        [Required]
        public string Groupid { get; set; }
        public Guid Trinhky_id { get; set; }
        public int Kieutrinhky { get; set; }
        public Status Trangthai { get ; set ; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Thutu { get ; set ; }
        public bool Dahuy { get ; set ; }
        public DateTime Ngaytao { get ; set ; }
        public DateTime? Ngaycapnhap { get ; set ; }
        public DateTime? Ngayhuy { get ; set ; }
        public DateTime? Ngayhoanthanh { get ; set ; }
        public string Ghichu { get ; set ; }
        public string Nguoitaoid { get ; set ; }
        public string Nguoitao { get ; set ; }
        public virtual Sys003 Sys003 { get; set; }
        public virtual Sys004 Sys004 { get; set; }
    }
}
