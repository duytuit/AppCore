using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppCore.Data.EF.Migrations
{
    public partial class create002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Manhanvien = table.Column<string>(maxLength: 15, nullable: false),
                    Hovaten = table.Column<string>(maxLength: 256, nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Sodienthoai = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(maxLength: 256, nullable: false),
                    Anhdaidien = table.Column<string>(nullable: true),
                    Diachi = table.Column<string>(nullable: true),
                    Ngaysinh = table.Column<string>(nullable: false),
                    CMTND = table.Column<string>(nullable: true),
                    Kieuuser = table.Column<int>(nullable: false),
                    Capbac = table.Column<int>(nullable: false),
                    Chucvu = table.Column<string>(nullable: true),
                    Ngaytao = table.Column<DateTime>(nullable: false),
                    Ngaycapnhap = table.Column<DateTime>(nullable: true),
                    Ngayhuy = table.Column<DateTime>(nullable: true),
                    Ngayhoanthanh = table.Column<DateTime>(nullable: true),
                    Trangthai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuditLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    BrowserInfo = table.Column<string>(nullable: true),
                    ClientIpAddress = table.Column<string>(nullable: true),
                    ClientName = table.Column<string>(nullable: true),
                    CustomData = table.Column<string>(nullable: true),
                    Exception = table.Column<string>(nullable: true),
                    ExecutionDuration = table.Column<int>(nullable: false),
                    ExecutionTime = table.Column<DateTime>(nullable: false),
                    ImpersonatorTenantId = table.Column<Guid>(nullable: true),
                    ImpersonatorUserId = table.Column<Guid>(nullable: true),
                    MethodName = table.Column<string>(nullable: true),
                    Parameters = table.Column<string>(nullable: true),
                    ServiceName = table.Column<string>(nullable: true),
                    TenantId = table.Column<Guid>(nullable: true),
                    UserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Madanhmuc = table.Column<string>(nullable: false),
                    Tendanhmuc = table.Column<string>(nullable: false),
                    Trangthai = table.Column<int>(nullable: false),
                    Thutu = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Namegroup = table.Column<string>(maxLength: 100, nullable: true),
                    Hoanthanh = table.Column<int>(nullable: false),
                    Tongnhomky = table.Column<int>(nullable: false),
                    Thutu = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhomKys",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Tennhom = table.Column<string>(maxLength: 256, nullable: false),
                    Kieunhom = table.Column<int>(nullable: false),
                    Trangthai = table.Column<int>(nullable: false),
                    Ngaytao = table.Column<DateTime>(nullable: false),
                    Ngaycapnhap = table.Column<DateTime>(nullable: true),
                    Ngayhuy = table.Column<DateTime>(nullable: true),
                    Ngayhoanthanh = table.Column<DateTime>(nullable: true),
                    Thutu = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ghichu = table.Column<string>(nullable: true),
                    Nguoitaoid = table.Column<string>(nullable: true),
                    Nguoitao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhomKys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Timers",
                columns: table => new
                {
                    Timerid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Thoigiandangxuat = table.Column<int>(nullable: false),
                    Trangthai = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timers", x => x.Timerid);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Danhmucid = table.Column<Guid>(nullable: false),
                    Idcha = table.Column<string>(nullable: true),
                    Tenmenu = table.Column<string>(nullable: true),
                    Duongdan = table.Column<string>(nullable: true),
                    Macode = table.Column<string>(nullable: true),
                    Capdo = table.Column<int>(nullable: false),
                    Icon = table.Column<string>(nullable: true),
                    Trangthai = table.Column<int>(nullable: false),
                    Thutu = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menus_DanhMucs_Danhmucid",
                        column: x => x.Danhmucid,
                        principalTable: "DanhMucs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrinhKys",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nhomky_id = table.Column<Guid>(nullable: false),
                    Danhmucid = table.Column<Guid>(nullable: false),
                    Tennhomky = table.Column<string>(nullable: true),
                    Tendanhmuc = table.Column<string>(nullable: true),
                    Kieutrinhky = table.Column<int>(nullable: false),
                    Ngaytao = table.Column<DateTime>(nullable: false),
                    Ngaycapnhap = table.Column<DateTime>(nullable: true),
                    Ngayhuy = table.Column<DateTime>(nullable: true),
                    Ngayhoanthanh = table.Column<DateTime>(nullable: true),
                    Trangthai = table.Column<int>(nullable: false),
                    Ghichu = table.Column<string>(nullable: true),
                    Nguoitaoid = table.Column<string>(nullable: true),
                    Nguoitao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrinhKys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrinhKys_DanhMucs_Danhmucid",
                        column: x => x.Danhmucid,
                        principalTable: "DanhMucs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrinhKys_NhomKys_Nhomky_id",
                        column: x => x.Nhomky_id,
                        principalTable: "NhomKys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserNhomKy",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserID = table.Column<Guid>(nullable: false),
                    Manhanvien = table.Column<string>(maxLength: 15, nullable: false),
                    Username = table.Column<string>(nullable: true),
                    Tennhomky = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Nhomky_id = table.Column<Guid>(nullable: false),
                    Trangthai = table.Column<int>(nullable: false),
                    Thutu = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNhomKy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserNhomKy_NhomKys_Nhomky_id",
                        column: x => x.Nhomky_id,
                        principalTable: "NhomKys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserNhomKy_AppUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhanQuyens",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Menuid = table.Column<string>(nullable: true),
                    Nhomky_id = table.Column<Guid>(nullable: false),
                    quyenXem = table.Column<bool>(nullable: false),
                    quyenThem = table.Column<bool>(nullable: false),
                    quyenCapNhap = table.Column<bool>(nullable: false),
                    quyenXoa = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanQuyens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhanQuyens_Menus_Menuid",
                        column: x => x.Menuid,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhanQuyens_NhomKys_Nhomky_id",
                        column: x => x.Nhomky_id,
                        principalTable: "NhomKys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuyTrinhs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Groupid = table.Column<string>(nullable: false),
                    Trinhky_id = table.Column<Guid>(nullable: false),
                    Kieutrinhky = table.Column<int>(nullable: false),
                    Trangthai = table.Column<int>(nullable: false),
                    Thutu = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dahuy = table.Column<bool>(nullable: false),
                    Ngaytao = table.Column<DateTime>(nullable: false),
                    Ngaycapnhap = table.Column<DateTime>(nullable: true),
                    Ngayhuy = table.Column<DateTime>(nullable: true),
                    Ngayhoanthanh = table.Column<DateTime>(nullable: true),
                    Ghichu = table.Column<string>(nullable: true),
                    Nguoitaoid = table.Column<string>(nullable: true),
                    Nguoitao = table.Column<string>(nullable: true),
                    Sys003Id = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuyTrinhs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuyTrinhs_Groups_Groupid",
                        column: x => x.Groupid,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuyTrinhs_TrinhKys_Sys003Id",
                        column: x => x.Sys003Id,
                        principalTable: "TrinhKys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "Anhdaidien", "CMTND", "Capbac", "Chucvu", "Diachi", "Email", "Hovaten", "Kieuuser", "Manhanvien", "Ngaycapnhap", "Ngayhoanthanh", "Ngayhuy", "Ngaysinh", "Ngaytao", "Password", "Sodienthoai", "Trangthai", "Username" },
                values: new object[] { new Guid("093d68c9-d02f-457a-b62f-0f067dcf4fcc"), null, null, 0, null, null, null, "Admin", 0, "890801", null, null, null, "2020-02-02 11:06", new DateTime(2020, 2, 2, 11, 6, 33, 856, DateTimeKind.Local).AddTicks(1657), "duytuit89!", null, 0, null });

            migrationBuilder.InsertData(
                table: "DanhMucs",
                columns: new[] { "Id", "Madanhmuc", "Tendanhmuc", "Thutu", "Trangthai" },
                values: new object[] { new Guid("f65afc49-fd8d-4d98-8969-bc6cbc7b8e5c"), "DM01", "Quản Trị", 1, 1 });

            migrationBuilder.InsertData(
                table: "NhomKys",
                columns: new[] { "Id", "Ghichu", "Kieunhom", "Ngaycapnhap", "Ngayhoanthanh", "Ngayhuy", "Ngaytao", "Nguoitao", "Nguoitaoid", "Tennhom", "Trangthai" },
                values: new object[] { new Guid("73df7fbf-15af-4e3d-a4b9-9a4e107e8586"), null, 1, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Quản trị", 1 });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Capdo", "Danhmucid", "Duongdan", "Icon", "Idcha", "Macode", "Tenmenu", "Thutu", "Trangthai" },
                values: new object[,]
                {
                    { "ht01", 1, new Guid("f65afc49-fd8d-4d98-8969-bc6cbc7b8e5c"), "thongtin", null, null, null, "Quản trị", 1, 1 },
                    { "ht02", 3, new Guid("f65afc49-fd8d-4d98-8969-bc6cbc7b8e5c"), "menu", null, "ht01", null, "Menu", 2, 1 },
                    { "ht03", 3, new Guid("f65afc49-fd8d-4d98-8969-bc6cbc7b8e5c"), "danhmuc", null, "ht01", null, "Danh mục", 3, 1 },
                    { "ht04", 3, new Guid("f65afc49-fd8d-4d98-8969-bc6cbc7b8e5c"), "nhomky", null, "ht01", null, "Nhóm ký", 4, 1 },
                    { "ht05", 3, new Guid("f65afc49-fd8d-4d98-8969-bc6cbc7b8e5c"), "trinhky", null, "ht01", null, "Trình ký", 5, 1 },
                    { "ht06", 3, new Guid("f65afc49-fd8d-4d98-8969-bc6cbc7b8e5c"), "phanquyen", null, "ht01", null, "Phân quyền", 6, 1 },
                    { "ht07", 3, new Guid("f65afc49-fd8d-4d98-8969-bc6cbc7b8e5c"), "usernhom", null, "ht01", null, "User - nhóm", 7, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserNhomKy",
                columns: new[] { "Id", "Email", "Manhanvien", "Nhomky_id", "Tennhomky", "Trangthai", "UserID", "Username" },
                values: new object[] { new Guid("edc08678-09f6-4de6-ad41-a1daaa5e3ce2"), null, "890801", new Guid("73df7fbf-15af-4e3d-a4b9-9a4e107e8586"), "Quản trị", 1, new Guid("093d68c9-d02f-457a-b62f-0f067dcf4fcc"), "Admin" });

            migrationBuilder.InsertData(
                table: "PhanQuyens",
                columns: new[] { "Id", "Menuid", "Nhomky_id", "quyenCapNhap", "quyenThem", "quyenXem", "quyenXoa" },
                values: new object[,]
                {
                    { new Guid("df32a9e5-ed11-48a3-a7d6-f8e16198d2d0"), "ht01", new Guid("73df7fbf-15af-4e3d-a4b9-9a4e107e8586"), false, false, false, false },
                    { new Guid("013d2c92-b78f-43d8-9220-ace94411288b"), "ht02", new Guid("73df7fbf-15af-4e3d-a4b9-9a4e107e8586"), false, false, false, false },
                    { new Guid("779963f9-e9b1-41ba-a05b-65d054838918"), "ht03", new Guid("73df7fbf-15af-4e3d-a4b9-9a4e107e8586"), false, false, false, false },
                    { new Guid("c66759c2-1070-4dc6-8e3d-2f1f4a6ec02f"), "ht04", new Guid("73df7fbf-15af-4e3d-a4b9-9a4e107e8586"), false, false, false, false },
                    { new Guid("24a6c212-c316-4fcd-ad11-d1db9eba81bc"), "ht05", new Guid("73df7fbf-15af-4e3d-a4b9-9a4e107e8586"), false, false, false, false },
                    { new Guid("0c3b6db7-06a8-4292-ae72-46587f57789f"), "ht06", new Guid("73df7fbf-15af-4e3d-a4b9-9a4e107e8586"), false, false, false, false },
                    { new Guid("09a4765f-611a-42fc-acad-f42e48348d2e"), "ht07", new Guid("73df7fbf-15af-4e3d-a4b9-9a4e107e8586"), false, false, false, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Menus_Danhmucid",
                table: "Menus",
                column: "Danhmucid");

            migrationBuilder.CreateIndex(
                name: "IX_PhanQuyens_Menuid",
                table: "PhanQuyens",
                column: "Menuid");

            migrationBuilder.CreateIndex(
                name: "IX_PhanQuyens_Nhomky_id",
                table: "PhanQuyens",
                column: "Nhomky_id");

            migrationBuilder.CreateIndex(
                name: "IX_QuyTrinhs_Groupid",
                table: "QuyTrinhs",
                column: "Groupid");

            migrationBuilder.CreateIndex(
                name: "IX_QuyTrinhs_Sys003Id",
                table: "QuyTrinhs",
                column: "Sys003Id");

            migrationBuilder.CreateIndex(
                name: "IX_TrinhKys_Danhmucid",
                table: "TrinhKys",
                column: "Danhmucid");

            migrationBuilder.CreateIndex(
                name: "IX_TrinhKys_Nhomky_id",
                table: "TrinhKys",
                column: "Nhomky_id");

            migrationBuilder.CreateIndex(
                name: "IX_UserNhomKy_Nhomky_id",
                table: "UserNhomKy",
                column: "Nhomky_id");

            migrationBuilder.CreateIndex(
                name: "IX_UserNhomKy_UserID",
                table: "UserNhomKy",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditLogs");

            migrationBuilder.DropTable(
                name: "PhanQuyens");

            migrationBuilder.DropTable(
                name: "QuyTrinhs");

            migrationBuilder.DropTable(
                name: "Timers");

            migrationBuilder.DropTable(
                name: "UserNhomKy");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "TrinhKys");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "DanhMucs");

            migrationBuilder.DropTable(
                name: "NhomKys");
        }
    }
}
