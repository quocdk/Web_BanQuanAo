﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebData.Models;

#nullable disable

namespace WebData.Migrations
{
    [DbContext(typeof(CuaHangDbContext))]
    [Migration("20231118172444_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebData.Models.ChucVu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenChucVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ChucVus");
                });

            modelBuilder.Entity("WebData.Models.GioHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdKhachHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdKhachHang");

                    b.ToTable("GioHangs");
                });

            modelBuilder.Entity("WebData.Models.GioHangChiTiet", b =>
                {
                    b.Property<Guid>("IdSanPhamChiTiet")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("DonGia")
                        .HasColumnType("bigint");

                    b.Property<long>("DonGiaKhiGiam")
                        .HasColumnType("bigint");

                    b.Property<Guid>("IdGioHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("IdSanPhamChiTiet");

                    b.HasIndex("IdGioHang");

                    b.ToTable("GioHangChiTiets");
                });

            modelBuilder.Entity("WebData.Models.HoaDon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdKhachHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdNhanVien")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayNhan")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayShip")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayThanhToan")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("NhanVienId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("IdKhachHang");

                    b.HasIndex("NhanVienId");

                    b.ToTable("HoaDons");
                });

            modelBuilder.Entity("WebData.Models.HoaDonChiTiet", b =>
                {
                    b.Property<Guid>("IdSanPhamChiTiet")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("DonGia")
                        .HasColumnType("bigint");

                    b.Property<Guid>("IdHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("IdSanPhamChiTiet");

                    b.HasIndex("IdHoaDon");

                    b.ToTable("HoaDonChiTiets");
                });

            modelBuilder.Entity("WebData.Models.KhachHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GioiTinh")
                        .HasColumnType("int");

                    b.Property<string>("Ho")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdChucVu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("KhachHangs");
                });

            modelBuilder.Entity("WebData.Models.LoaiSanPham", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenLoaiSanPham")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LoaiSanPhams");
                });

            modelBuilder.Entity("WebData.Models.MauSac", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenMauSac")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MauSacs");
                });

            modelBuilder.Entity("WebData.Models.NhanVien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GioiTinh")
                        .HasColumnType("int");

                    b.Property<string>("Ho")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdChucVu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdChucVu");

                    b.ToTable("NhanViens");
                });

            modelBuilder.Entity("WebData.Models.SanPham", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdLoaiSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdThuongHieu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaSanPham")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenSanPham")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdLoaiSanPham");

                    b.HasIndex("IdThuongHieu");

                    b.ToTable("SanPhams");
                });

            modelBuilder.Entity("WebData.Models.SanPhamChiTiet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("GiaBan")
                        .HasColumnType("bigint");

                    b.Property<long>("GiaNhap")
                        .HasColumnType("bigint");

                    b.Property<Guid>("IdMauSac")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSize")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuongTon")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdMauSac");

                    b.HasIndex("IdSanPham");

                    b.HasIndex("IdSize");

                    b.ToTable("SanPhamChiTiets");
                });

            modelBuilder.Entity("WebData.Models.Size", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenSize")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("WebData.Models.ThuongHieu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenThuongHieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ThuongHieus");
                });

            modelBuilder.Entity("WebData.Models.GioHang", b =>
                {
                    b.HasOne("WebData.Models.KhachHang", "KhachHang")
                        .WithMany("GioHangs")
                        .HasForeignKey("IdKhachHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");
                });

            modelBuilder.Entity("WebData.Models.GioHangChiTiet", b =>
                {
                    b.HasOne("WebData.Models.GioHang", "GioHang")
                        .WithMany("GioHangChiTiets")
                        .HasForeignKey("IdGioHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebData.Models.SanPhamChiTiet", "SanPhamChiTiet")
                        .WithMany("GioHangChiTiets")
                        .HasForeignKey("IdSanPhamChiTiet")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GioHang");

                    b.Navigation("SanPhamChiTiet");
                });

            modelBuilder.Entity("WebData.Models.HoaDon", b =>
                {
                    b.HasOne("WebData.Models.KhachHang", "KhachHang")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdKhachHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebData.Models.NhanVien", null)
                        .WithMany("HoaDons")
                        .HasForeignKey("NhanVienId");

                    b.Navigation("KhachHang");
                });

            modelBuilder.Entity("WebData.Models.HoaDonChiTiet", b =>
                {
                    b.HasOne("WebData.Models.HoaDon", "HoaDon")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IdHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebData.Models.SanPhamChiTiet", "SanPhamChiTiet")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IdSanPhamChiTiet")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDon");

                    b.Navigation("SanPhamChiTiet");
                });

            modelBuilder.Entity("WebData.Models.NhanVien", b =>
                {
                    b.HasOne("WebData.Models.ChucVu", "ChucVu")
                        .WithMany("NhanViens")
                        .HasForeignKey("IdChucVu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChucVu");
                });

            modelBuilder.Entity("WebData.Models.SanPham", b =>
                {
                    b.HasOne("WebData.Models.LoaiSanPham", "LoaiSanPham")
                        .WithMany("SanPhams")
                        .HasForeignKey("IdLoaiSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebData.Models.ThuongHieu", "ThuongHieu")
                        .WithMany("SanPhams")
                        .HasForeignKey("IdThuongHieu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoaiSanPham");

                    b.Navigation("ThuongHieu");
                });

            modelBuilder.Entity("WebData.Models.SanPhamChiTiet", b =>
                {
                    b.HasOne("WebData.Models.MauSac", "MauSac")
                        .WithMany("SanPhamChiTiets")
                        .HasForeignKey("IdMauSac")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebData.Models.SanPham", "SanPham")
                        .WithMany("SanPhamChiTiets")
                        .HasForeignKey("IdSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebData.Models.Size", "Size")
                        .WithMany("SanPhamChiTiets")
                        .HasForeignKey("IdSize")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MauSac");

                    b.Navigation("SanPham");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("WebData.Models.ChucVu", b =>
                {
                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("WebData.Models.GioHang", b =>
                {
                    b.Navigation("GioHangChiTiets");
                });

            modelBuilder.Entity("WebData.Models.HoaDon", b =>
                {
                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("WebData.Models.KhachHang", b =>
                {
                    b.Navigation("GioHangs");

                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("WebData.Models.LoaiSanPham", b =>
                {
                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("WebData.Models.MauSac", b =>
                {
                    b.Navigation("SanPhamChiTiets");
                });

            modelBuilder.Entity("WebData.Models.NhanVien", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("WebData.Models.SanPham", b =>
                {
                    b.Navigation("SanPhamChiTiets");
                });

            modelBuilder.Entity("WebData.Models.SanPhamChiTiet", b =>
                {
                    b.Navigation("GioHangChiTiets");

                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("WebData.Models.Size", b =>
                {
                    b.Navigation("SanPhamChiTiets");
                });

            modelBuilder.Entity("WebData.Models.ThuongHieu", b =>
                {
                    b.Navigation("SanPhams");
                });
#pragma warning restore 612, 618
        }
    }
}
