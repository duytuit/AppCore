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
    [Table("DanhMucs")]
    public class Sys005 : DomainEntity<Guid>, ISwitchable, ISortable
    {
        public Sys005()
        {
        }

        public Sys005(string madanhmuc, string tendanhmuc, Status trangthai, int thutu)
        {
            Madanhmuc = madanhmuc;
            Tendanhmuc = tendanhmuc;
            Trangthai = trangthai;
            Thutu = thutu;
        }

        [Required]
        public string Madanhmuc { get; set; }
        [Required]
        public string Tendanhmuc { get; set; }
        public Status Trangthai { get ; set ; }
        public int Thutu { get ; set ; }
        public virtual ICollection<Sys006> Sys006 { get; set; }
        public virtual ICollection<Sys003> Sys003 { get; set; }
    }
}
