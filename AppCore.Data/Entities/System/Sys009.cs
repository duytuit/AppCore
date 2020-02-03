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
    [Table("UserNhomKy")]
    public class Sys009 : DomainEntity<Guid>, ISwitchable, ISortable
    {
        public Sys009()
        {
        }

        public Sys009(Guid userID, string manhanvien, string username, string tennhomky, string email, Guid nhomky_id, Status trangthai, int thutu)
        {
            UserID = userID;
            Manhanvien = manhanvien;
            Username = username;
            Tennhomky = tennhomky;
            Email = email;
            Nhomky_id = nhomky_id;
            Trangthai = trangthai;
            Thutu = thutu;
        }

        [Required]
        public Guid UserID { get; set; }
        [Required]
        [MaxLength(15)]
        public string Manhanvien { get; set; }
        public string Username { get; set; }
        public string Tennhomky { get; set; }
        public string Email { get; set; }
        [Required]
        public Guid Nhomky_id { get; set; }
        public Status Trangthai { get ; set ; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Thutu { get ; set ; }
        public virtual Sys001 Sys001 { get; set; }
        public virtual Sys002 Sys002 { get; set; }

    }
}
