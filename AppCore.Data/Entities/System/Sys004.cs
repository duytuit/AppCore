using AppCore.Data.Interfaces;
using AppCore.Infrastructure.SharesKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppCore.Data.Entities.System
{
    [Table("Groups")]
    public class Sys004 : DomainEntity<string>, ISortable
    {
        public Sys004()
        {
        }

        public Sys004(string namegroup, int hoanthanh, int tongnhomky, int thutu)
        {
            Namegroup = namegroup;
            Hoanthanh = hoanthanh;
            Tongnhomky = tongnhomky;
            Thutu = thutu;
        }

        [MaxLength(100)]
        public string Namegroup { get; set; }

        public int Hoanthanh { get; set; }

        public int Tongnhomky { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Thutu { get ; set ; }
       // public virtual ICollection<Data1> Data1 { get; set; }
        public virtual ICollection<Sys007> Sys007 { get; set; }
        // public virtual ICollection<ThongkeloiMA5> ThongkeloiMA5 { get; set; }
    }
}
