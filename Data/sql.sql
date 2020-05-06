USE [DGRLSV]
GO
/****** Object:  Table [dbo].[DGRenLuyen]    Script Date: 5/6/2020 8:32:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DGRenLuyen](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NamHoc] [int] NOT NULL,
	[MaHK] [nvarchar](10) NOT NULL,
	[MSSV] [nvarchar](250) NOT NULL,
	[MaLC] [int] NOT NULL,
	[DiemSVDG] [int] NULL,
	[DiemLT] [int] NULL,
	[DiemCVHT] [int] NULL,
 CONSTRAINT [PK_DGRenLuyen_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiangVien]    Script Date: 5/6/2020 8:32:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiangVien](
	[MaGV] [nvarchar](250) NOT NULL,
	[TenGV] [nvarchar](250) NULL,
	[MaKhoa] [nvarchar](250) NULL,
	[TenTaiKhoan] [nvarchar](250) NULL,
 CONSTRAINT [PK_GiangVien] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KetQua]    Script Date: 5/6/2020 8:32:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KetQua](
	[MSSV] [nvarchar](250) NOT NULL,
	[NamHoc] [int] NOT NULL,
	[MaHK] [nvarchar](10) NOT NULL,
	[TongDiemSV] [int] NULL,
	[TongDiemLT] [int] NULL,
	[TongDiemCVHT] [int] NULL,
	[XepLoai] [nvarchar](250) NULL,
 CONSTRAINT [PK_KetQua] PRIMARY KEY CLUSTERED 
(
	[MSSV] ASC,
	[NamHoc] ASC,
	[MaHK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 5/6/2020 8:32:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [nvarchar](250) NOT NULL,
	[TenKhoa] [nvarchar](250) NULL,
 CONSTRAINT [PK_Khoa] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 5/6/2020 8:32:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [nvarchar](250) NOT NULL,
	[TenLop] [nvarchar](250) NULL,
	[MaKhoa] [nvarchar](250) NULL,
	[MaGV] [nvarchar](250) NULL,
	[MaLT] [nvarchar](250) NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LuaChonChiTiet]    Script Date: 5/6/2020 8:32:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LuaChonChiTiet](
	[MaLC] [int] IDENTITY(1,1) NOT NULL,
	[MaCT] [int] NULL,
	[MoTa] [nvarchar](500) NULL,
	[DiemMin] [int] NULL,
	[DiemMax] [int] NULL,
 CONSTRAINT [PK_LuaChonChiTiet_1] PRIMARY KEY CLUSTERED 
(
	[MaLC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NoiDungChiTiet]    Script Date: 5/6/2020 8:32:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NoiDungChiTiet](
	[MaCT] [int] IDENTITY(1,1) NOT NULL,
	[MaTC] [int] NULL,
	[NoiDung] [nvarchar](500) NULL,
	[DiemCTMax] [int] NULL,
 CONSTRAINT [PK_NoiDungChiTiet] PRIMARY KEY CLUSTERED 
(
	[MaCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 5/6/2020 8:32:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MSSV] [nvarchar](250) NOT NULL,
	[HoTen] [nvarchar](250) NULL,
	[NgaySinh] [date] NULL,
	[QueQuan] [nvarchar](500) NULL,
	[MaLop] [nvarchar](250) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[MSSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 5/6/2020 8:32:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[Username] [nvarchar](250) NOT NULL,
	[Password] [nvarchar](250) NULL,
	[ChucVu] [nvarchar](250) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TieuChiDanhGia]    Script Date: 5/6/2020 8:32:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TieuChiDanhGia](
	[MaTC] [int] IDENTITY(1,1) NOT NULL,
	[NoiDung] [nvarchar](500) NULL,
	[DiemTCMax] [int] NULL,
 CONSTRAINT [PK_TieuChiDanhGia] PRIMARY KEY CLUSTERED 
(
	[MaTC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[GiangVien] ([MaGV], [TenGV], [MaKhoa], [TenTaiKhoan]) VALUES (N'Vinh', N'Vinh 2', N'tn', N'vinh')
GO
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'cntt', N'Công Nghệ Thông Tin')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'tn', N'Toán Tin')
GO
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa], [MaGV], [MaLT]) VALUES (N'CTK37', N'CTK37', N'cntt', N'Vinh', NULL)
GO
INSERT [dbo].[SinhVien] ([MSSV], [HoTen], [NgaySinh], [QueQuan], [MaLop]) VALUES (N'1312667', N'Vinh', CAST(N'1995-01-01' AS Date), N'Lâm Đồng', N'CTK37')
GO
SET IDENTITY_INSERT [dbo].[TieuChiDanhGia] ON 

INSERT [dbo].[TieuChiDanhGia] ([MaTC], [NoiDung], [DiemTCMax]) VALUES (1, N'hihi', 10)
SET IDENTITY_INSERT [dbo].[TieuChiDanhGia] OFF
GO
