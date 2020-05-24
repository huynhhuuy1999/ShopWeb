using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Shop.Models
{
    public partial class shopContext : DbContext
    {
        public shopContext()
        {
        }

        public shopContext(DbContextOptions<shopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<Chitiethoadon> Chitiethoadon { get; set; }
        public virtual DbSet<Hinhanh> Hinhanh { get; set; }
        public virtual DbSet<Hoadon> Hoadon { get; set; }
        public virtual DbSet<Khachhang> Khachhang { get; set; }
        public virtual DbSet<Khuyenmai> Khuyenmai { get; set; }
        public virtual DbSet<Kichthuoc> Kichthuoc { get; set; }
        public virtual DbSet<Magiamgia> Magiamgia { get; set; }
        public virtual DbSet<Nhanvien> Nhanvien { get; set; }
        public virtual DbSet<Phanloai> Phanloai { get; set; }
        public virtual DbSet<Phiship> Phiship { get; set; }
        public virtual DbSet<Sanpham> Sanpham { get; set; }
        public virtual DbSet<Taikhoan> Taikhoan { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost; database=shop; user=root;pwd=123456;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("admin");

                entity.HasIndex(e => e.TaiKhoanId)
                    .HasName("FK_TaiKhoan_Admin");

                entity.Property(e => e.AdminId)
                    .HasColumnName("adminId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DiaChi).HasColumnType("varchar(100)");

                entity.Property(e => e.Email).HasColumnType("varchar(50)");

                entity.Property(e => e.HoTen).HasColumnType("varchar(50)");

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.Sdt).HasColumnType("varchar(11)");

                entity.Property(e => e.TaiKhoanId).HasColumnType("int(11)");

                entity.HasOne(d => d.TaiKhoan)
                    .WithMany(p => p.Admin)
                    .HasForeignKey(d => d.TaiKhoanId)
                    .HasConstraintName("FK_TaiKhoan_Admin");
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.ToTable("cart");

                entity.HasIndex(e => e.KichthuocId)
                    .HasName("FK_Cart_KichThuoc");

                entity.HasIndex(e => e.SanPhamId)
                    .HasName("FK_Cart_SanPham");

                entity.Property(e => e.CartId).HasColumnType("int(11)");

                entity.Property(e => e.IdSession)
                    .HasColumnName("idSession")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.KichthuocId)
                    .HasColumnName("kichthuocId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SanPhamId)
                    .HasColumnName("sanPhamId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Soluong)
                    .HasColumnName("soluong")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tongtien).HasColumnName("tongtien");

                entity.HasOne(d => d.Kichthuoc)
                    .WithMany(p => p.Cart)
                    .HasForeignKey(d => d.KichthuocId)
                    .HasConstraintName("FK_Cart_KichThuoc");

                entity.HasOne(d => d.SanPham)
                    .WithMany(p => p.Cart)
                    .HasForeignKey(d => d.SanPhamId)
                    .HasConstraintName("FK_Cart_SanPham");
            });

            modelBuilder.Entity<Chitiethoadon>(entity =>
            {
                entity.ToTable("chitiethoadon");

                entity.HasIndex(e => e.HoaDonId)
                    .HasName("FK_ChiTietHoaDon_HoaDon");

                entity.HasIndex(e => e.KichThuocId)
                    .HasName("FK_ChiTietHoaDon_KichThuoc");

                entity.HasIndex(e => e.SanPhamId)
                    .HasName("FK_ChiTietHoaDon_SanPham");

                entity.Property(e => e.ChiTietHoaDonId).HasColumnType("int(11)");

                entity.Property(e => e.HoaDonId).HasColumnType("int(11)");

                entity.Property(e => e.KichThuocId).HasColumnType("int(11)");

                entity.Property(e => e.SanPhamId).HasColumnType("int(11)");

                entity.Property(e => e.SoLuong).HasColumnType("int(11)");

                entity.Property(e => e.TongSauKm).HasColumnName("TongSauKM");

                entity.HasOne(d => d.HoaDon)
                    .WithMany(p => p.Chitiethoadon)
                    .HasForeignKey(d => d.HoaDonId)
                    .HasConstraintName("FK_ChiTietHoaDon_HoaDon");

                entity.HasOne(d => d.KichThuoc)
                    .WithMany(p => p.Chitiethoadon)
                    .HasForeignKey(d => d.KichThuocId)
                    .HasConstraintName("FK_ChiTietHoaDon_KichThuoc");

                entity.HasOne(d => d.SanPham)
                    .WithMany(p => p.Chitiethoadon)
                    .HasForeignKey(d => d.SanPhamId)
                    .HasConstraintName("FK_ChiTietHoaDon_SanPham");
            });

            modelBuilder.Entity<Hinhanh>(entity =>
            {
                entity.ToTable("hinhanh");

                entity.Property(e => e.HinhAnhId).HasColumnType("int(11)");

                entity.Property(e => e.TenFile).HasColumnType("varchar(200)");
            });

            modelBuilder.Entity<Hoadon>(entity =>
            {
                entity.ToTable("hoadon");

                entity.HasIndex(e => e.KhachHangId)
                    .HasName("FK_HoaDon_KhacHang");

                entity.HasIndex(e => e.NhanVienId)
                    .HasName("FK_HoaDon_NhanVien");

                entity.HasIndex(e => e.PhiShipId)
                    .HasName("FK_HoaDon_PhiShip");

                entity.Property(e => e.HoaDonId).HasColumnType("int(11)");

                entity.Property(e => e.KhachHangId).HasColumnType("int(11)");

                entity.Property(e => e.NgayGiao).HasColumnType("date");

                entity.Property(e => e.NgayTao).HasColumnType("date");

                entity.Property(e => e.NhanVienId).HasColumnType("int(11)");

                entity.Property(e => e.PhiShipId).HasColumnType("int(11)");

                entity.Property(e => e.Quan).HasColumnType("varchar(20)");

                entity.Property(e => e.Sdt).HasColumnType("varchar(11)");

                entity.Property(e => e.SessionId)
                    .HasColumnName("sessionId")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SoNha).HasColumnType("varchar(50)");

                entity.Property(e => e.TenNguoiNhan).HasColumnType("varchar(50)");

                entity.Property(e => e.TrangThai).HasColumnType("varchar(50)");

                entity.HasOne(d => d.KhachHang)
                    .WithMany(p => p.Hoadon)
                    .HasForeignKey(d => d.KhachHangId)
                    .HasConstraintName("FK_HoaDon_KhacHang");

                entity.HasOne(d => d.NhanVien)
                    .WithMany(p => p.Hoadon)
                    .HasForeignKey(d => d.NhanVienId)
                    .HasConstraintName("FK_HoaDon_NhanVien");

                entity.HasOne(d => d.PhiShip)
                    .WithMany(p => p.Hoadon)
                    .HasForeignKey(d => d.PhiShipId)
                    .HasConstraintName("FK_HoaDon_PhiShip");
            });

            modelBuilder.Entity<Khachhang>(entity =>
            {
                entity.ToTable("khachhang");

                entity.HasIndex(e => e.TaiKhoanId)
                    .HasName("FK_TaiKhoan_KhachHang");

                entity.Property(e => e.KhachHangId).HasColumnType("int(11)");

                entity.Property(e => e.DiaChi).HasColumnType("varchar(100)");

                entity.Property(e => e.Email).HasColumnType("varchar(50)");

                entity.Property(e => e.HoTen).HasColumnType("varchar(50)");

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.Sdt).HasColumnType("varchar(11)");

                entity.Property(e => e.TaiKhoanId).HasColumnType("int(11)");

                entity.HasOne(d => d.TaiKhoan)
                    .WithMany(p => p.Khachhang)
                    .HasForeignKey(d => d.TaiKhoanId)
                    .HasConstraintName("FK_TaiKhoan_KhachHang");
            });

            modelBuilder.Entity<Khuyenmai>(entity =>
            {
                entity.ToTable("khuyenmai");

                entity.Property(e => e.KhuyenMaiId).HasColumnType("int(11)");

                entity.Property(e => e.MoTa).HasColumnType("text");

                entity.Property(e => e.NgayBatDau).HasColumnType("date");

                entity.Property(e => e.NgayKetThuc).HasColumnType("date");

                entity.Property(e => e.TenKhuyenMai).HasColumnType("varchar(100)");

                entity.Property(e => e.TrangThai).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Kichthuoc>(entity =>
            {
                entity.ToTable("kichthuoc");

                entity.HasIndex(e => e.SanPhamId)
                    .HasName("FK_kichthuoc_SanPham");

                entity.Property(e => e.KichThuocid).HasColumnType("int(11)");

                entity.Property(e => e.SanPhamId).HasColumnType("int(11)");

                entity.Property(e => e.TenKichThuoc).HasColumnType("varchar(50)");

                entity.HasOne(d => d.SanPham)
                    .WithMany(p => p.Kichthuoc)
                    .HasForeignKey(d => d.SanPhamId)
                    .HasConstraintName("FK_kichthuoc_SanPham");
            });

            modelBuilder.Entity<Magiamgia>(entity =>
            {
                entity.ToTable("magiamgia");

                entity.Property(e => e.MaGiamGiaId).HasColumnType("int(11)");

                entity.Property(e => e.MaGiamGia1)
                    .HasColumnName("MaGiamGia")
                    .HasColumnType("varchar(10)");
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.ToTable("nhanvien");

                entity.HasIndex(e => e.TaiKhoanId)
                    .HasName("FK_TaiKhoan_NhanVien");

                entity.Property(e => e.NhanVienId).HasColumnType("int(11)");

                entity.Property(e => e.DiaChi).HasColumnType("varchar(100)");

                entity.Property(e => e.Email).HasColumnType("varchar(50)");

                entity.Property(e => e.HoTen).HasColumnType("varchar(50)");

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.Sdt).HasColumnType("varchar(11)");

                entity.Property(e => e.TaiKhoanId).HasColumnType("int(11)");

                entity.HasOne(d => d.TaiKhoan)
                    .WithMany(p => p.Nhanvien)
                    .HasForeignKey(d => d.TaiKhoanId)
                    .HasConstraintName("FK_TaiKhoan_NhanVien");
            });

            modelBuilder.Entity<Phanloai>(entity =>
            {
                entity.ToTable("phanloai");

                entity.Property(e => e.PhanLoaiId).HasColumnType("int(11)");

                entity.Property(e => e.TenLoai).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Phiship>(entity =>
            {
                entity.ToTable("phiship");

                entity.Property(e => e.PhiShipId).HasColumnType("int(11)");

                entity.Property(e => e.ChiPhi).HasColumnType("int(11)");

                entity.Property(e => e.Quan).HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.ToTable("sanpham");

                entity.HasIndex(e => e.HinhAnhId)
                    .HasName("FK_SanPham_HinhAnh");

                entity.HasIndex(e => e.KhuyenMaiId)
                    .HasName("FK_SanPham_KhuyenMai");

                entity.HasIndex(e => e.PhanLoaiId)
                    .HasName("FK_SanPham_PhanLoai");

                entity.Property(e => e.SanPhamId).HasColumnType("int(11)");

                entity.Property(e => e.HinhAnhId).HasColumnType("int(11)");

                entity.Property(e => e.KhuyenMaiId).HasColumnType("int(11)");

                entity.Property(e => e.Mota).HasColumnType("varchar(500)");

                entity.Property(e => e.PhanLoaiId).HasColumnType("int(11)");

                entity.Property(e => e.TenSanPham).HasColumnType("varchar(50)");

                entity.Property(e => e.TrangThai).HasColumnType("int(11)");

                entity.HasOne(d => d.HinhAnh)
                    .WithMany(p => p.Sanpham)
                    .HasForeignKey(d => d.HinhAnhId)
                    .HasConstraintName("FK_SanPham_HinhAnh");

                entity.HasOne(d => d.KhuyenMai)
                    .WithMany(p => p.Sanpham)
                    .HasForeignKey(d => d.KhuyenMaiId)
                    .HasConstraintName("FK_SanPham_KhuyenMai");

                entity.HasOne(d => d.PhanLoai)
                    .WithMany(p => p.Sanpham)
                    .HasForeignKey(d => d.PhanLoaiId)
                    .HasConstraintName("FK_SanPham_PhanLoai");
            });

            modelBuilder.Entity<Taikhoan>(entity =>
            {
                entity.ToTable("taikhoan");

                entity.HasIndex(e => e.Username)
                    .HasName("UQ_TAIKHOAN_USERNAME")
                    .IsUnique();

                entity.Property(e => e.TaiKhoanId).HasColumnType("int(11)");

                entity.Property(e => e.KichHoat).HasColumnType("tinyint(4)");

                entity.Property(e => e.NgayTao).HasColumnType("date");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasColumnType("varchar(50)");
            });
        }
    }
}
