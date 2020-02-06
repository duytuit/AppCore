using AppCore.Data.Entities.System;
using AppCore.Infrastructure.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Data.EF.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            Guid getguidnhomky = Guid.NewGuid();
            Guid getguiddanhmuc = Guid.NewGuid();
            Guid getguiduser = Guid.NewGuid();
            modelBuilder.Entity<Sys001>().HasData(
             new Sys001() { Id = getguiduser, Manhanvien = "890801", Hovaten = "Admin", Password = "duytuit89!", Ngaysinh = DateTime.Now.Date, Ngaytao = DateTime.Now }
             );
            modelBuilder.Entity<Sys002>().HasData(
                new Sys002() { Id = getguidnhomky, Tennhom = "Quản trị", Kieunhom = 1, Trangthai = Status.Actived }
                );
            modelBuilder.Entity<Sys009>().HasData(
            new Sys009() { Id = Guid.NewGuid(),UserID= getguiduser, Manhanvien = "890801", Username = "Admin", Tennhomky = "Quản trị", Nhomky_id = getguidnhomky, Trangthai = Status.Actived }
            );
            modelBuilder.Entity<Sys005>().HasData(
               new Sys005() { Id = getguiddanhmuc, Madanhmuc = "DM01", Tendanhmuc = "Quản Trị", Thutu = 1, Trangthai = Status.Actived }
               );
            modelBuilder.Entity<Sys006>().HasData(
                new Sys006() { Id = "ht01", Tenmenu = "Quản trị", Danhmucid = getguiddanhmuc, Capdo = 1, Duongdan = "thongtin", Thutu = 1, Trangthai = Status.Actived },
                 new Sys006() { Id = "ht02", Tenmenu = "Menu", Idcha = "ht01", Danhmucid = getguiddanhmuc, Capdo = 3, Duongdan = "menu", Thutu = 2, Trangthai = Status.Actived },
                  new Sys006() { Id = "ht03", Tenmenu = "Danh mục", Idcha = "ht01", Danhmucid = getguiddanhmuc, Capdo = 3, Duongdan = "danhmuc", Thutu = 3, Trangthai = Status.Actived },
                   new Sys006() { Id = "ht04", Tenmenu = "Nhóm ký", Idcha = "ht01", Danhmucid = getguiddanhmuc, Capdo = 3, Duongdan = "nhomky", Thutu = 4, Trangthai = Status.Actived },
                    new Sys006() { Id = "ht05", Tenmenu = "Trình ký", Idcha = "ht01", Danhmucid = getguiddanhmuc, Capdo = 3, Duongdan = "trinhky", Thutu = 5, Trangthai = Status.Actived },
                     new Sys006() { Id = "ht06", Tenmenu = "Phân quyền", Idcha = "ht01", Danhmucid = getguiddanhmuc, Capdo = 3, Duongdan = "phanquyen", Thutu = 6, Trangthai = Status.Actived },
                      new Sys006() { Id = "ht07", Tenmenu = "User - nhóm", Idcha = "ht01", Danhmucid = getguiddanhmuc, Capdo = 3, Duongdan = "usernhom", Thutu = 7, Trangthai = Status.Actived }
                );

            modelBuilder.Entity<Sys008>().HasData(
                    new Sys008() { Id=Guid.NewGuid(), Menuid = "ht01", Nhomky_id = getguidnhomky, quyenXem = false, quyenThem = false, quyenCapNhap = false, quyenXoa = false },
                     new Sys008() { Id = Guid.NewGuid(), Menuid = "ht02", Nhomky_id = getguidnhomky, quyenXem = false, quyenThem = false, quyenCapNhap = false, quyenXoa = false },
                      new Sys008() { Id = Guid.NewGuid(), Menuid = "ht03", Nhomky_id = getguidnhomky, quyenXem = false, quyenThem = false, quyenCapNhap = false, quyenXoa = false },
                       new Sys008() { Id = Guid.NewGuid(), Menuid = "ht04", Nhomky_id = getguidnhomky, quyenXem = false, quyenThem = false, quyenCapNhap = false, quyenXoa = false },
                        new Sys008() { Id = Guid.NewGuid(), Menuid = "ht05", Nhomky_id = getguidnhomky, quyenXem = false, quyenThem = false, quyenCapNhap = false, quyenXoa = false },
                         new Sys008() { Id = Guid.NewGuid(), Menuid = "ht06", Nhomky_id = getguidnhomky, quyenXem = false, quyenThem = false, quyenCapNhap = false, quyenXoa = false },
                          new Sys008() { Id = Guid.NewGuid(), Menuid = "ht07", Nhomky_id = getguidnhomky, quyenXem = false, quyenThem = false, quyenCapNhap = false, quyenXoa = false }
                );
        }
        //public static void AddConfiguration<TEntity>(
        //this ModelBuilder modelBuilder,
        //DbEntityConfiguration<TEntity> entityConfiguration) where TEntity : class
        //{
        //    modelBuilder.Entity<TEntity>(entityConfiguration.Configure);
        //}
    }
    //public abstract class DbEntityConfiguration<TEntity> where TEntity : class
    //{
    //    public abstract void Configure(EntityTypeBuilder<TEntity> entity);
    //}
}
