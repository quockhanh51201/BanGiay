CREATE DATABASE DB_BANGIAY
USE DB_BANGIAY


-- Tạo bảng Danh mục sản phẩm
CREATE TABLE DanhMucSanPham (
    MaDanhMuc INT PRIMARY KEY,
    TenDanhMuc NVARCHAR(255)
);

-- Tạo bảng Thương hiệu
CREATE TABLE LoaiSanPham (
    MaLoaiSanPham INT PRIMARY KEY,
    TenLoaiSanPham NVARCHAR(255),
	MaDanhMuc INT, 
	FOREIGN KEY (MaDanhMuc) REFERENCES DanhMucSanPham (MaDanhMuc)
);



-- Tạo bảng Sản phẩm
CREATE TABLE SanPham (
    MaSanPham INT PRIMARY KEY,
    TenSanPham NVARCHAR(255),
    MoTa NVARCHAR(MAX),
    Gia DECIMAL(10, 2),
	KichThuoc NVARCHAR(50),
	TenMauSac NVARCHAR(255),
	HinhAnh NVARCHAR(255),
    MaLoaiSanPham INT,
    FOREIGN KEY (MaLoaiSanPham) REFERENCES LoaiSanPham (MaLoaiSanPham),
   
);

-- Tạo bảng Khách hàng
CREATE TABLE KhachHang (
    MaKhachHang INT PRIMARY KEY,
    HoTenDem NVARCHAR(50),
    Ten NVARCHAR(50),
    Email NVARCHAR(100),
    SoDienThoai NVARCHAR(20),
    DiaChi NVARCHAR(255),
    ThanhPho NVARCHAR(50),
    TinhThanh NVARCHAR(50),
    MaBuuDien NVARCHAR(10)
);

-- Tạo bảng Đơn hàng
CREATE TABLE DonHang (
    MaDonHang INT PRIMARY KEY,
    MaKhachHang INT,
    NgayDatHang DATETIME,
    TrangThai NVARCHAR(50),
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang (MaKhachHang)
);

-- Tạo bảng Chi tiết đơn hàng
CREATE TABLE ChiTietDonHang (
    MaChiTietDonHang INT PRIMARY KEY,
    MaDonHang INT,
    MaSanPham INT,
    SoLuong INT,
    DonGia DECIMAL(10, 2),
    FOREIGN KEY (MaDonHang) REFERENCES DonHang (MaDonHang),
    FOREIGN KEY (MaSanPham) REFERENCES SanPham (MaSanPham)
);

-- Tạo bảng Đánh giá và Nhận xét
CREATE TABLE DanhGiaVaNhanXet (
    MaDanhGia INT PRIMARY KEY,
    MaSanPham INT,
    MaKhachHang INT,
    DiemDanhGia INT,
    BinhLuan NVARCHAR(MAX),
    FOREIGN KEY (MaSanPham) REFERENCES SanPham (MaSanPham),
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang (MaKhachHang)
);

-- Tạo bảng Lịch sử giao dịch
CREATE TABLE LichSuGiaoDich (
    MaGiaoDich INT PRIMARY KEY,
    MaDonHang INT,
    NgayGiaoDich DATETIME,
    SoTien DECIMAL(10, 2),
    FOREIGN KEY (MaDonHang) REFERENCES DonHang (MaDonHang)
);

-- Tạo bảng Tài khoản người dùng
CREATE TABLE TaiKhoanNguoiDung (
    MaTaiKhoan INT PRIMARY KEY,
    TenDangNhap NVARCHAR(50),
    MatKhau NVARCHAR(MAX), -- Lưu ý: cần mã hóa mật khẩu
    MaKhachHang INT,
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang (MaKhachHang)
);

-- Tạo bảng Địa chỉ giao hàng
CREATE TABLE DiaChiGiaoHang (
    MaDiaChi INT PRIMARY KEY,
    MaKhachHang INT,
    DiaChiGiaoHang NVARCHAR(255),
    ThanhPhoGiaoHang NVARCHAR(50),
    TinhThanhGiaoHang NVARCHAR(50),
    MaBuuDienGiaoHang NVARCHAR(10),
	SoDienThoaiNhanHang NVARCHAR(10),
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang (MaKhachHang)
);

-- Tạo bảng Giỏ hàng
CREATE TABLE GioHang (
    MaGioHang INT PRIMARY KEY,
    MaKhachHang INT,
    MaSanPham INT,
    SoLuong INT,
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang (MaKhachHang),
    FOREIGN KEY (MaSanPham) REFERENCES SanPham (MaSanPham)
);