﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopDienThoai.Infrastructure.Context;

#nullable disable

namespace ShopDienThoai.Infrastructure.Migrations
{
    [DbContext(typeof(KinhdoanhdienthoaiContext))]
    [Migration("20231119091336_V1")]
    partial class V1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ShopDienThoai.Domain.Entities.Avartarkhachhang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("Avartarkhachhang1")
                        .HasColumnType("image")
                        .HasColumnName("AVARTARKHACHHANG");

                    b.Property<int?>("Idkhachhang")
                        .HasColumnType("int")
                        .HasColumnName("IDKHACHHANG");

                    b.HasKey("Id")
                        .HasName("PK__AVARTARK__3214EC27B25BA327");

                    b.HasIndex("Idkhachhang");

                    b.ToTable("AVARTARKHACHHANG", (string)null);
                });

            modelBuilder.Entity("ShopDienThoai.Domain.Entities.Binhluan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Idkhachhang")
                        .HasColumnType("int")
                        .HasColumnName("IDKHACHHANG");

                    b.Property<int?>("Idsanpham")
                        .HasColumnType("int")
                        .HasColumnName("IDSANPHAM");

                    b.Property<string>("Noidungbinhluan")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NOIDUNGBINHLUAN");

                    b.Property<DateTime?>("Thoigianbinhluan")
                        .HasColumnType("datetime")
                        .HasColumnName("THOIGIANBINHLUAN");

                    b.HasKey("Id")
                        .HasName("PK__BINHLUAN__3214EC271A4E82D3");

                    b.HasIndex(new[] { "Idkhachhang" }, "IX_BINHLUAN_IDKHACHHANG");

                    b.HasIndex(new[] { "Idsanpham" }, "IX_BINHLUAN_IDSANPHAM");

                    b.ToTable("BINHLUAN", (string)null);
                });

            modelBuilder.Entity("ShopDienThoai.Domain.Entities.Chitiethoadon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Dongia")
                        .HasColumnType("int")
                        .HasColumnName("DONGIA");

                    b.Property<int?>("Idhoadon")
                        .HasColumnType("int")
                        .HasColumnName("IDHOADON");

                    b.Property<int?>("Idsanpham")
                        .HasColumnType("int")
                        .HasColumnName("IDSANPHAM");

                    b.Property<int?>("Soluong")
                        .HasColumnType("int")
                        .HasColumnName("SOLUONG");

                    b.Property<int?>("Thanhtien")
                        .HasColumnType("int")
                        .HasColumnName("THANHTIEN");

                    b.HasKey("Id")
                        .HasName("PK__CHITIETH__3214EC27200E78CA");

                    b.HasIndex(new[] { "Idhoadon" }, "IX_CHITIETHOADON_IDHOADON");

                    b.HasIndex(new[] { "Idsanpham" }, "IX_CHITIETHOADON_IDSANPHAM");

                    b.ToTable("CHITIETHOADON", (string)null);
                });

            modelBuilder.Entity("ShopDienThoai.Domain.Entities.Chucvunhanvien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Tenchucvu")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TENCHUCVU");

                    b.HasKey("Id")
                        .HasName("PK__CHUCVUNH__3214EC27466B620A");

                    b.ToTable("CHUCVUNHANVIEN", (string)null);
                });

            modelBuilder.Entity("ShopDienThoai.Domain.Entities.Hoadon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Diachigiaohang")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("DIACHIGIAOHANG");

                    b.Property<int?>("Idkhachhang")
                        .HasColumnType("int")
                        .HasColumnName("IDKHACHHANG");

                    b.Property<int?>("Idnhanvien")
                        .HasColumnType("int")
                        .HasColumnName("IDNHANVIEN");

                    b.Property<int?>("Idphuongthuc")
                        .HasColumnType("int")
                        .HasColumnName("IDPHUONGTHUC");

                    b.Property<int?>("Idtinhtrang")
                        .HasColumnType("int")
                        .HasColumnName("IDTINHTRANG");

                    b.Property<DateTime?>("Ngaydathang")
                        .HasColumnType("datetime")
                        .HasColumnName("NGAYDATHANG");

                    b.Property<DateTime?>("Ngaygiaohang")
                        .HasColumnType("datetime")
                        .HasColumnName("NGAYGIAOHANG");

                    b.HasKey("Id")
                        .HasName("PK__HOADON__3214EC27266796F4");

                    b.HasIndex(new[] { "Idkhachhang" }, "IX_HOADON_IDKHACHHANG");

                    b.HasIndex(new[] { "Idnhanvien" }, "IX_HOADON_IDNHANVIEN");

                    b.HasIndex(new[] { "Idphuongthuc" }, "IX_HOADON_IDPHUONGTHUC");

                    b.HasIndex(new[] { "Idtinhtrang" }, "IX_HOADON_IDTINHTRANG");

                    b.ToTable("HOADON", (string)null);
                });

            modelBuilder.Entity("ShopDienThoai.Domain.Entities.Imagenhanvien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Idnhanvien")
                        .HasColumnType("int")
                        .HasColumnName("IDNHANVIEN");

                    b.Property<byte[]>("Imagestaff")
                        .HasColumnType("image")
                        .HasColumnName("IMAGESTAFF");

                    b.HasKey("Id")
                        .HasName("PK__IMAGENHA");

                    b.HasIndex(new[] { "Idnhanvien" }, "IX_IMAGENHANVIEN_IDNHANVIEN");

                    b.ToTable("IMAGENHANVIEN", (string)null);
                });

            modelBuilder.Entity("ShopDienThoai.Domain.Entities.Imagesanpham", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Idsanpham")
                        .HasColumnType("int")
                        .HasColumnName("IDSANPHAM");

                    b.Property<byte[]>("Imagesanpham1")
                        .HasColumnType("image")
                        .HasColumnName("IMAGESANPHAM");

                    b.HasKey("Id")
                        .HasName("PK__IMAGESAN__3214EC27A7A453DC");

                    b.HasIndex("Idsanpham");

                    b.ToTable("IMAGESANPHAM", (string)null);
                });

            modelBuilder.Entity("ShopDienThoai.Domain.Entities.Khachhang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Diachi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("DIACHI");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("Makhachhang")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("MAKHACHHANG");

                    b.Property<string>("Sdt")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("SDT");

                    b.Property<string>("Tenkhachhang")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TENKHACHHANG");

                    b.HasKey("Id")
                        .HasName("PK__KHACHHAN__3214EC27E16D1A0B");

                    b.ToTable("KHACHHANG", (string)null);
                });

            modelBuilder.Entity("ShopDienThoai.Domain.Entities.Loaisanpham", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Tenloaisanpham")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TENLOAISANPHAM");

                    b.HasKey("Id")
                        .HasName("PK__LOAISANP__3214EC273E162916");

                    b.ToTable("LOAISANPHAM", (string)null);
                });

            modelBuilder.Entity("ShopDienThoai.Domain.Entities.Nhanvien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Chucvuid")
                        .HasColumnType("int")
                        .HasColumnName("CHUCVUID");

                    b.Property<string>("Diachi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("DIACHI");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("EMAIL");

                    b.Property<bool?>("Gioitinh")
                        .HasColumnType("bit")
                        .HasColumnName("GIOITINH");

                    b.Property<string>("Hoten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("HOTEN");

                    b.Property<string>("Manhanvien")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("MANHANVIEN");

                    b.Property<DateTime?>("Ngaysinh")
                        .HasColumnType("datetime")
                        .HasColumnName("NGAYSINH");

                    b.Property<string>("Sdt")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("SDT");

                    b.HasKey("Id")
                        .HasName("PK__NHANVIEN__3214EC27E2664FA2");

                    b.HasIndex(new[] { "Chucvuid" }, "IX_NHANVIEN_CHUCVUID");

                    b.ToTable("NHANVIEN", (string)null);
                });

            modelBuilder.Entity("ShopDienThoai.Domain.Entities.Phuongthucthanhtoan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Tenphuongthuc")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TENPHUONGTHUC");

                    b.HasKey("Id")
                        .HasName("PK__PHUONGTH__3214EC27BC1E2B2C");

                    b.ToTable("PHUONGTHUCTHANHTOAN", (string)null);
                });

            modelBuilder.Entity("ShopDienThoai.Domain.Entities.Sanpham", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Baohanh")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("BAOHANH");

                    b.Property<string>("Bonhoram")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("BONHORAM");

                    b.Property<string>("Bonhotrong")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("BONHOTRONG");

                    b.Property<string>("Dungluongpin")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("DUNGLUONGPIN");

                    b.Property<int?>("Giaban")
                        .HasColumnType("int")
                        .HasColumnName("GIABAN");

                    b.Property<string>("Hedieuhanh")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("HEDIEUHANH");

                    b.Property<string>("Kichthuocmanhinh")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("KICHTHUOCMANHINH");

                    b.Property<int?>("Loaisanphamid")
                        .HasColumnType("int")
                        .HasColumnName("LOAISANPHAMID");

                    b.Property<string>("Masanpham")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("MASANPHAM");

                    b.Property<string>("Mausac")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("MAUSAC");

                    b.Property<string>("Mota")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MOTA");

                    b.Property<int?>("Soluongton")
                        .HasColumnType("int")
                        .HasColumnName("SOLUONGTON");

                    b.Property<string>("Tensanpham")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TENSANPHAM");

                    b.Property<string>("Trongluong")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("TRONGLUONG");

                    b.HasKey("Id")
                        .HasName("PK__SANPHAM__3214EC27B7205ED5");

                    b.HasIndex(new[] { "Loaisanphamid" }, "IX_SANPHAM_LOAISANPHAMID");

                    b.ToTable("SANPHAM", (string)null);
                });

            modelBuilder.Entity("ShopDienThoai.Domain.Entities.Tinhtrang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Tentinhtrang")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TENTINHTRANG");

                    b.HasKey("Id")
                        .HasName("PK__TINHTRAN__3214EC27DB0DC927");

                    b.ToTable("TINHTRANG", (string)null);
                });

            modelBuilder.Entity("ShopDienThoai.Domain.Entities.Avartarkhachhang", b =>
                {
                    b.HasOne("ShopDienThoai.Domain.Entities.Khachhang", "IdkhachhangNavigation")
                        .WithMany("Avartarkhachhangs")
                        .HasForeignKey("Idkhachhang")
                        .HasConstraintName("FK__AVARTARKH__IDKHA__7A672E12");

                    b.Navigation("IdkhachhangNavigation");
                });

            modelBuilder.Entity("ShopDienThoai.Domain.Entities.Binhluan", b =>
                {
                    b.HasOne("ShopDienThoai.Domain.Entities.Khachhang", "IdkhachhangNavigation")
                        .WithMany("Binhluans")
                        .HasForeignKey("Idkhachhang")
                        .HasConstraintName("FK__BINHLUAN__IDKHAC__5070F446");

                    b.HasOne("ShopDienThoai.Domain.Entities.Sanpham", "IdsanphamNavigation")
                        .WithMany("Binhluans")
                        .HasForeignKey("Idsanpham")
                        .HasConstraintName("FK__BINHLUAN__IDSANP__5165187F");

                    b.Navigation("IdkhachhangNavigation");

                    b.Navigation("IdsanphamNavigation");
                });

            modelBuilder.Entity("ShopDienThoai.Domain.Entities.Chitiethoadon", b =>
                {
                    b.HasOne("ShopDienThoai.Domain.Entities.Hoadon", "IdhoadonNavigation")
                        .WithMany("Chitiethoadons")
                        .HasForeignKey("Idhoadon")
                        .HasConstraintName("FK__CHITIETHO__IDHOA__4CA06362");

                    b.HasOne("ShopDienThoai.Domain.Entities.Sanpham", "IdsanphamNavigation")
                        .WithMany("Chitiethoadons")
                        .HasForeignKey("Idsanpham")
                        .HasConstraintName("FK__CHITIETHO__IDSAN__4D94879B");

                    b.Navigation("IdhoadonNavigation");

                    b.Navigation("IdsanphamNavigation");
                });

            modelBuilder.Entity("ShopDienThoai.Domain.Entities.Hoadon", b =>
                {
                    b.HasOne("ShopDienThoai.Domain.Entities.Khachhang", "IdkhachhangNavigation")
                        .WithMany("Hoadons")
                        .HasForeignKey("Idkhachhang")
                        .HasConstraintName("FK__HOADON__IDKHACHH__46E78A0C");

                    b.HasOne("ShopDienThoai.Domain.Entities.Nhanvien", "IdnhanvienNavigation")
                        .WithMany("Hoadons")
                        .HasForeignKey("Idnhanvien")
                        .HasConstraintName("FK__HOADON__IDNHANVI__47DBAE45");

                    b.HasOne("ShopDienThoai.Domain.Entities.Phuongthucthanhtoan", "IdphuongthucNavigation")
                        .WithMany("Hoadons")
                        .HasForeignKey("Idphuongthuc")
                        .HasConstraintName("FK__HOADON__IDPHUONG__48CFD27E");

                    b.HasOne("ShopDienThoai.Domain.Entities.Tinhtrang", "IdtinhtrangNavigation")
                        .WithMany("Hoadons")
                        .HasForeignKey("Idtinhtrang")
                        .HasConstraintName("FK__HOADON__IDTINHTR__49C3F6B7");

                    b.Navigation("IdkhachhangNavigation");

                    b.Navigation("IdnhanvienNavigation");

                    b.Navigation("IdphuongthucNavigation");

                    b.Navigation("IdtinhtrangNavigation");
                });

            modelBuilder.Entity("ShopDienThoai.Domain.Entities.Imagenhanvien", b =>
                {
                    b.HasOne("ShopDienThoai.Domain.Entities.Nhanvien", "IdnhanvienNavigation")
                        .WithMany("Imagenhanviens")
                        .HasForeignKey("Idnhanvien")
                        .HasConstraintName("FK__IMAGENHAN__IDNHA");

                    b.Navigation("IdnhanvienNavigation");
                });

            modelBuilder.Entity("ShopDienThoai.Domain.Entities.Imagesanpham", b =>
                {
                    b.HasOne("ShopDienThoai.Domain.Entities.Sanpham", "IdsanphamNavigation")
                        .WithMany("Imagesanphams")
                        .HasForeignKey("Idsanpham")
                        .HasConstraintName("FK__IMAGESANP__IDSAN__778AC167");

                    b.Navigation("IdsanphamNavigation");
                });

            modelBuilder.Entity("ShopDienThoai.Domain.Entities.Nhanvien", b =>
                {
                    b.HasOne("ShopDienThoai.Domain.Entities.Chucvunhanvien", "Chucvu")
                        .WithMany("Nhanviens")
                        .HasForeignKey("Chucvuid")
                        .HasConstraintName("FK__NHANVIEN__CHUCVU__3E52440B");

                    b.Navigation("Chucvu");
                });

            modelBuilder.Entity("ShopDienThoai.Domain.Entities.Sanpham", b =>
                {
                    b.HasOne("ShopDienThoai.Domain.Entities.Loaisanpham", "Loaisanpham")
                        .WithMany("Sanphams")
                        .HasForeignKey("Loaisanphamid")
                        .HasConstraintName("FK__SANPHAM__LOAISAN__398D8EEE");

                    b.Navigation("Loaisanpham");
                });

            modelBuilder.Entity("ShopDienThoai.Domain.Entities.Chucvunhanvien", b =>
                {
                    b.Navigation("Nhanviens");
                });

            modelBuilder.Entity("ShopDienThoai.Domain.Entities.Hoadon", b =>
                {
                    b.Navigation("Chitiethoadons");
                });

            modelBuilder.Entity("ShopDienThoai.Domain.Entities.Khachhang", b =>
                {
                    b.Navigation("Avartarkhachhangs");

                    b.Navigation("Binhluans");

                    b.Navigation("Hoadons");
                });

            modelBuilder.Entity("ShopDienThoai.Domain.Entities.Loaisanpham", b =>
                {
                    b.Navigation("Sanphams");
                });

            modelBuilder.Entity("ShopDienThoai.Domain.Entities.Nhanvien", b =>
                {
                    b.Navigation("Hoadons");

                    b.Navigation("Imagenhanviens");
                });

            modelBuilder.Entity("ShopDienThoai.Domain.Entities.Phuongthucthanhtoan", b =>
                {
                    b.Navigation("Hoadons");
                });

            modelBuilder.Entity("ShopDienThoai.Domain.Entities.Sanpham", b =>
                {
                    b.Navigation("Binhluans");

                    b.Navigation("Chitiethoadons");

                    b.Navigation("Imagesanphams");
                });

            modelBuilder.Entity("ShopDienThoai.Domain.Entities.Tinhtrang", b =>
                {
                    b.Navigation("Hoadons");
                });
#pragma warning restore 612, 618
        }
    }
}
