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
    [Table("NhomKys")]
    public class Sys002 : DomainEntity<Guid>, IDateTracking, ISwitchable, ISortable, IOwner
    {
        public Sys002()
        {
        }

        public Sys002(string tennhom, int kieunhom, Status trangthai, DateTime ngaytao,
            DateTime? ngaycapnhap, DateTime? ngayhuy, DateTime? ngayhoanthanh,
            int thutu, string ghichu, string nguoitaoid, string nguoitao)
        {
            Tennhom = tennhom;
            Kieunhom = kieunhom;
            Trangthai = trangthai;
            Ngaytao = ngaytao;
            Ngaycapnhap = ngaycapnhap;
            Ngayhuy = ngayhuy;
            Ngayhoanthanh = ngayhoanthanh;
            Thutu = thutu;
            Ghichu = ghichu;
            Nguoitaoid = nguoitaoid;
            Nguoitao = nguoitao;
        }

        [Required]
        [MaxLength(256)]
        public string Tennhom { get; set; }
        [Required]
        public int Kieunhom { get; set; }
        public Status Trangthai { get  ; set  ; }
        public DateTime Ngaytao { get  ; set  ; }
        public DateTime? Ngaycapnhap { get  ; set  ; }
        public DateTime? Ngayhuy { get  ; set  ; }
        public DateTime? Ngayhoanthanh { get  ; set  ; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Thutu { get  ; set  ; }
        public string Ghichu { get  ; set  ; }
        public string Nguoitaoid { get  ; set  ; }
        public string Nguoitao { get  ; set  ; }
        public virtual ICollection<Sys009> Sys009 { get; set; }
        public virtual ICollection<Sys008> Sys008 { get; set; }
        public virtual ICollection<Sys003> Sys003 { get; set; }
    }
}
