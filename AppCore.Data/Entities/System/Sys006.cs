using AppCore.Data.Interfaces;
using AppCore.Infrastructure.Enums;
using AppCore.Infrastructure.SharesKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppCore.Data.Entities.System
{
    [Table("Menus")]
    public class Sys006 : DomainEntity<string>, ISwitchable, ISortable
    {
        public Sys006()
        {
        }

        public Sys006(Guid danhmucid, string idcha, string tenmenu, string duongdan, string macode, int capdo, string icon, Status trangthai, int thutu)
        {
            Danhmucid = danhmucid;
            Idcha = idcha;
            Tenmenu = tenmenu;
            Duongdan = duongdan;
            Macode = macode;
            Capdo = capdo;
            Icon = icon;
            Trangthai = trangthai;
            Thutu = thutu;
        }

        public Guid Danhmucid { get; set; }
        public string Idcha { get; set; }

        public string Tenmenu { get; set; }

        public string Duongdan { get; set; }

        public string Macode { get; set; }

        public int Capdo { get; set; }

        public string Icon { get; set; }
        public Status Trangthai { get ; set ; }
        public int Thutu { get ; set ; }
        public virtual ICollection<Sys008> Sys008 { get; set; }
        public virtual Sys005 Sys005 { get; set; }
    }
}
