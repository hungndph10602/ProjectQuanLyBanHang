namespace DTO_QLBH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CTHDs",
                c => new
                    {
                        macthd = c.Int(nullable: false, identity: true),
                        mshd = c.Int(nullable: false),
                        mssp = c.Int(nullable: false),
                        soluong = c.Int(nullable: false),
                        gia = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.macthd)
                .ForeignKey("dbo.HoaDons", t => t.mshd, cascadeDelete: true)
                .Index(t => t.mshd);
            
            CreateTable(
                "dbo.HoaDons",
                c => new
                    {
                        mahd = c.Int(nullable: false, identity: true),
                        mskh = c.Int(nullable: false),
                        msnv = c.Int(nullable: false),
                        ngaylap = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.mahd)
                .ForeignKey("dbo.KhachHangs", t => t.mskh, cascadeDelete: true)
                .ForeignKey("dbo.NhanViens", t => t.msnv, cascadeDelete: true)
                .Index(t => t.mskh)
                .Index(t => t.msnv);
            
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        makh = c.Int(nullable: false, identity: true),
                        tenkh = c.String(),
                        diachi = c.String(),
                        gioitinh = c.Boolean(nullable: false),
                        khachhang_makh = c.Int(),
                    })
                .PrimaryKey(t => t.makh)
                .ForeignKey("dbo.KhachHangs", t => t.khachhang_makh)
                .Index(t => t.khachhang_makh);
            
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        manv = c.Int(nullable: false, identity: true),
                        hoten = c.String(),
                        ngaysinh = c.DateTime(nullable: false),
                        diachi = c.String(),
                        vaitro = c.String(),
                        matkhau = c.String(),
                        tinhtrang = c.String(),
                        nhanvien_manv = c.Int(),
                    })
                .PrimaryKey(t => t.manv)
                .ForeignKey("dbo.NhanViens", t => t.nhanvien_manv)
                .Index(t => t.nhanvien_manv);
            
            CreateTable(
                "dbo.SanPhams",
                c => new
                    {
                        masp = c.Int(nullable: false, identity: true),
                        tensp = c.String(),
                        soluong = c.Int(nullable: false),
                        gianhap = c.Double(nullable: false),
                        giaban = c.Double(nullable: false),
                        hinhanh = c.String(),
                        sanpham_masp = c.Int(),
                        CTHD_macthd = c.Int(),
                    })
                .PrimaryKey(t => t.masp)
                .ForeignKey("dbo.SanPhams", t => t.sanpham_masp)
                .ForeignKey("dbo.CTHDs", t => t.CTHD_macthd)
                .Index(t => t.sanpham_masp)
                .Index(t => t.CTHD_macthd);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SanPhams", "CTHD_macthd", "dbo.CTHDs");
            DropForeignKey("dbo.SanPhams", "sanpham_masp", "dbo.SanPhams");
            DropForeignKey("dbo.CTHDs", "mshd", "dbo.HoaDons");
            DropForeignKey("dbo.HoaDons", "msnv", "dbo.NhanViens");
            DropForeignKey("dbo.NhanViens", "nhanvien_manv", "dbo.NhanViens");
            DropForeignKey("dbo.HoaDons", "mskh", "dbo.KhachHangs");
            DropForeignKey("dbo.KhachHangs", "khachhang_makh", "dbo.KhachHangs");
            DropIndex("dbo.SanPhams", new[] { "CTHD_macthd" });
            DropIndex("dbo.SanPhams", new[] { "sanpham_masp" });
            DropIndex("dbo.NhanViens", new[] { "nhanvien_manv" });
            DropIndex("dbo.KhachHangs", new[] { "khachhang_makh" });
            DropIndex("dbo.HoaDons", new[] { "msnv" });
            DropIndex("dbo.HoaDons", new[] { "mskh" });
            DropIndex("dbo.CTHDs", new[] { "mshd" });
            DropTable("dbo.SanPhams");
            DropTable("dbo.NhanViens");
            DropTable("dbo.KhachHangs");
            DropTable("dbo.HoaDons");
            DropTable("dbo.CTHDs");
        }
    }
}
