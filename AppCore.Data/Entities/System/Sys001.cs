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
    [Table("AppUsers")]
    public class Sys001 : DomainEntity<Guid>, IDateTracking, ISwitchable
    {
        public Sys001()
        {
        }

        public Sys001(string manhanvien, string hovaten, string email, string sodienthoai, string username, string password,
            string anhdaidien, string diachi, DateTime ngaysinh, string cMTND, int kieuuser, int capbac, string chucvu,
            DateTime ngaytao, DateTime? ngaycapnhap, DateTime? ngayhuy, DateTime? ngayhoanthanh, Status trangthai)
        {
            Manhanvien = manhanvien;
            Hovaten = hovaten;
            Email = email;
            Sodienthoai = sodienthoai;
            Username = username;
            Password = password;
            Anhdaidien = anhdaidien;
            Diachi = diachi;
            Ngaysinh = ngaysinh;
            CMTND = cMTND;
            Kieuuser = kieuuser;
            Capbac = capbac;
            Chucvu = chucvu;
            Ngaytao = ngaytao;
            Ngaycapnhap = ngaycapnhap;
            Ngayhuy = ngayhuy;
            Ngayhoanthanh = ngayhoanthanh;
            Trangthai = trangthai;
        }

        [Required]
        [MaxLength(15)]
        public string Manhanvien { get; set; }
        [Required]
        [MaxLength(256)]
        public string Hovaten { get; set; }
        public string Email { get; set; }
        public string Sodienthoai { get; set; }
        public string Username { get; set; }
        [Required]
        [MaxLength(256)]
        public string Password { get; set; }
        public string Anhdaidien { get; set; }
        public string Diachi { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string CMTND { get; set; }
        public int Kieuuser { get; set; }
        public int Capbac { get; set; }
        public string Chucvu { get; set; }
        public DateTime Ngaytao { get; set; }
        public DateTime? Ngaycapnhap { get; set; }
        public DateTime? Ngayhuy { get; set; }
        public DateTime? Ngayhoanthanh { get; set;}
        public Status Trangthai { get; set; }
        public virtual ICollection<Sys009> Sys009 { get; set; }
    }
}
