USE [DGRLSV]
GO
/****** Object:  Table [dbo].[DGRenLuyen]    Script Date: 6/9/2020 11:00:56 PM ******/
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
/****** Object:  Table [dbo].[GiangVien]    Script Date: 6/9/2020 11:00:56 PM ******/
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
/****** Object:  Table [dbo].[KetQua]    Script Date: 6/9/2020 11:00:56 PM ******/
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
/****** Object:  Table [dbo].[Khoa]    Script Date: 6/9/2020 11:00:56 PM ******/
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
/****** Object:  Table [dbo].[Lop]    Script Date: 6/9/2020 11:00:56 PM ******/
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
/****** Object:  Table [dbo].[LuaChonChiTiet]    Script Date: 6/9/2020 11:00:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LuaChonChiTiet](
	[MaLC] [int] NOT NULL,
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
/****** Object:  Table [dbo].[NoiDungChiTiet]    Script Date: 6/9/2020 11:00:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NoiDungChiTiet](
	[MaCT] [int] NOT NULL,
	[MaTC] [int] NULL,
	[NoiDung] [nvarchar](500) NULL,
	[DiemCTMax] [int] NULL,
 CONSTRAINT [PK_NoiDungChiTiet] PRIMARY KEY CLUSTERED 
(
	[MaCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 6/9/2020 11:00:56 PM ******/
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
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 6/9/2020 11:00:56 PM ******/
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
/****** Object:  Table [dbo].[TieuChiDanhGia]    Script Date: 6/9/2020 11:00:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TieuChiDanhGia](
	[MaTC] [int] NOT NULL,
	[NoiDung] [nvarchar](500) NULL,
	[DiemTCMax] [int] NULL,
 CONSTRAINT [PK_TieuChiDanhGia] PRIMARY KEY CLUSTERED 
(
	[MaTC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ViewLuaChonChiTiet]    Script Date: 6/9/2020 11:00:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewLuaChonChiTiet]
AS
SELECT        t.MaTC, t.NoiDung AS NoiDungTC, t.DiemTCMax, n.MaCT, n.NoiDung AS NoiDungCT, n.DiemCTMax, l.MaLC, l.MoTa AS NoiDungLC, l.DiemMin, l.DiemMax
FROM            dbo.LuaChonChiTiet AS l LEFT OUTER JOIN
                         dbo.NoiDungChiTiet AS n ON l.MaCT = n.MaCT LEFT OUTER JOIN
                         dbo.TieuChiDanhGia AS t ON n.MaTC = t.MaTC
GO

INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'cntt', N'Công Nghệ Thông Tin')
GO
INSERT [dbo].[LuaChonChiTiet] ([MaLC], [MaCT], [MoTa], [DiemMin], [DiemMax]) VALUES (1, 1, N'Có đi học chuyên cần, đúng giờ, nghiêm túc trong giờ học', 0, 4)
GO
INSERT [dbo].[LuaChonChiTiet] ([MaLC], [MaCT], [MoTa], [DiemMin], [DiemMax]) VALUES (2, 2, N'Có đăng ký, thực hiện, báo cáo đề tài nghiên cứu khoa học đúng tiến độ hoặc có đăng ký, tham dự các cuộc thi học thuật cấp Khoa trở lên.', 0, 2)
GO
INSERT [dbo].[LuaChonChiTiet] ([MaLC], [MaCT], [MoTa], [DiemMin], [DiemMax]) VALUES (3, 3, N'Có ý thức tham gia các câu lạc bộ, câu lạc bộ học thuật, các hoạt động học thuật, hoạt động ngoại khoá', 0, 2)
GO
INSERT [dbo].[LuaChonChiTiet] ([MaLC], [MaCT], [MoTa], [DiemMin], [DiemMax]) VALUES (4, 4, N'Bị xử lý kỷ luật trong các kỳ thi kết thúc học phần (khiển trách: -2 điểm, cảnh cáo: -4 điểm, đình chỉ thi: -6 điểm)', -6, 0)
GO
INSERT [dbo].[LuaChonChiTiet] ([MaLC], [MaCT], [MoTa], [DiemMin], [DiemMax]) VALUES (5, 5, N'Được tập thể lớp công nhận có tinh thần vượt khó, phấn đấu vươn lên trong học tập', 0, 2)
GO
INSERT [dbo].[LuaChonChiTiet] ([MaLC], [MaCT], [MoTa], [DiemMin], [DiemMax]) VALUES (6, 6, N'Kết quả học tập (Yếu kém: 0 điểm; Trung bình: 4 điểm; Khá: 6 điểm; Giỏi: 8 điểm; Xuất sắc: 10 điểm)', 0, 10)
GO
INSERT [dbo].[LuaChonChiTiet] ([MaLC], [MaCT], [MoTa], [DiemMin], [DiemMax]) VALUES (7, 7, N'Có ý thức chấp hành các văn bản chỉ đạo của ngành, của trường được thực hiện trong nhà trường (Vi phạm 01 lần bị trừ 02 điểm, từ lần vi phạm thứ hai trở đi bị trừ hết số điểm còn lại của tiêu chí)', 0, 6)
GO
INSERT [dbo].[LuaChonChiTiet] ([MaLC], [MaCT], [MoTa], [DiemMin], [DiemMax]) VALUES (8, 8, N'Có ý thức tham gia đầy đủ, đạt yêu cầu các cuộc vận động, sinh hoạt chính trị theo chủ trương, của cấp trên và nhà trường (Không tham gia 01 lần hoặc vi phạm quy định của các cuộc vận động bị trừ 02 điểm, từ lần vi phạm thứ hai trở đi bị trừ hết số điểm còn lại của tiêu chí)', 0, 4)
GO
INSERT [dbo].[LuaChonChiTiet] ([MaLC], [MaCT], [MoTa], [DiemMin], [DiemMax]) VALUES (9, 9, N'Có ý thức chấp hành nội quy, quy chế, thực hiện nội quy văn hóa học đường và các quy định của nhà trường (Vi phạm 01 lần bị trừ 02 điểm, từ lần vi phạm thứ ba trở đi bị trừ hết số điểm còn lại của tiêu chí)', 0, 10)
GO
INSERT [dbo].[LuaChonChiTiet] ([MaLC], [MaCT], [MoTa], [DiemMin], [DiemMax]) VALUES (10, 10, N'Tham gia đầy đủ, đạt yêu cầu “Tuần sinh hoạt công dân sinh viên” (đánh giá chung cho cả hai học kỳ trong năm học)', 0, 5)
GO
INSERT [dbo].[LuaChonChiTiet] ([MaLC], [MaCT], [MoTa], [DiemMin], [DiemMax]) VALUES (11, 11, N'Tham gia các hoạt động, sinh hoạt phong trào, tình nguyện do Khoa tổ chức (Vắng 01 lần (không có phép) bị trừ 02 điểm)', 0, 6)
GO
INSERT [dbo].[LuaChonChiTiet] ([MaLC], [MaCT], [MoTa], [DiemMin], [DiemMax]) VALUES (12, 12, N'Tham gia các hoạt động do Đoàn thanh niên và Hội sinh viên tổ chức (tham gia 1 hoạt động được 2 điểm)', 0, 6)
GO
INSERT [dbo].[LuaChonChiTiet] ([MaLC], [MaCT], [MoTa], [DiemMin], [DiemMax]) VALUES (13, 13, N'Có ý thức tham gia đầy đủ, nghiêm túc hoạt động rèn luyện về chính trị, xã hội, văn hóa, văn nghệ, thể thao do nhà trường tổ chức, điều động', 0, 4)
GO
INSERT [dbo].[LuaChonChiTiet] ([MaLC], [MaCT], [MoTa], [DiemMin], [DiemMax]) VALUES (14, 14, N'Có ý thức tham gia các hoạt động công ích, tình nguyện, công tác xã hội trong nhà trường', 0, 2)
GO
INSERT [dbo].[LuaChonChiTiet] ([MaLC], [MaCT], [MoTa], [DiemMin], [DiemMax]) VALUES (15, 15, N'Có ý thức tham gia các hoạt động tuyên truyền, phòng chống tội phạm và các tệ nạn xã hội trong nhà trường', 0, 2)
GO
INSERT [dbo].[LuaChonChiTiet] ([MaLC], [MaCT], [MoTa], [DiemMin], [DiemMax]) VALUES (16, 16, N'Có ý thức chấp hành, tham gia tuyên truyền các chủ trương của Đảng, chính sách, pháp luật của Nhà nước (Vi phạm 01 lần bị trừ 02 điểm, từ lần vi phạm thứ hai trở đi bị trừ hết số điểm còn lại của tiêu chí)', 0, 4)
GO
INSERT [dbo].[LuaChonChiTiet] ([MaLC], [MaCT], [MoTa], [DiemMin], [DiemMax]) VALUES (17, 17, N'Có tham gia bảo hiểm y tế (bắt buộc) theo Luật bảo hiểm y tế (thực hiện đầy đủ: 10 điểm; không thực hiện: 0 điểm)', 0, 10)
GO
INSERT [dbo].[LuaChonChiTiet] ([MaLC], [MaCT], [MoTa], [DiemMin], [DiemMax]) VALUES (18, 18, N'Có ý thức chấp hành, tham gia tuyên truyền các quy định về bảo đảm an toàn giao thông và “văn hóa giao thông” (Vi phạm 01 lần bị trừ 02 điểm, từ lần vi phạm thứ hai trở đi bị trừ hết số điểm còn lại của tiêu chí)', 0, 5)
GO
INSERT [dbo].[LuaChonChiTiet] ([MaLC], [MaCT], [MoTa], [DiemMin], [DiemMax]) VALUES (19, 19, N'Có ý thức tham gia các hoạt động xã hội có thành tích được ghi nhận, biểu dương, khen thưởng', 0, 4)
GO
INSERT [dbo].[LuaChonChiTiet] ([MaLC], [MaCT], [MoTa], [DiemMin], [DiemMax]) VALUES (20, 20, N'Có tinh thần chia sẻ, giúp đỡ người gặp khó khăn, hoạn nạn', 0, 2)
GO
INSERT [dbo].[LuaChonChiTiet] ([MaLC], [MaCT], [MoTa], [DiemMin], [DiemMax]) VALUES (21, 21, N'Có ý thức, uy tín và hoàn thành tốt nhiệm vụ quản lý lớp, các tổ chức Đảng, Đoàn Thanh niên, Hội Sinh viên, tổ chức khác trong nhà trường', 0, 3)
GO
INSERT [dbo].[LuaChonChiTiet] ([MaLC], [MaCT], [MoTa], [DiemMin], [DiemMax]) VALUES (22, 22, N'Có kỹ năng tổ chức, quản lý lớp, các tổ chức Đảng, Đoàn Thanh niên, Hội Sinh viên và các tổ chức khác trong nhà trường', 0, 2)
GO
INSERT [dbo].[LuaChonChiTiet] ([MaLC], [MaCT], [MoTa], [DiemMin], [DiemMax]) VALUES (23, 23, N'Hỗ trợ và tham gia tích cực các hoạt động chung của tập thể lớp, khoa, trường, tham gia ban tự quản khu nội trú', 0, 3)
GO
INSERT [dbo].[LuaChonChiTiet] ([MaLC], [MaCT], [MoTa], [DiemMin], [DiemMax]) VALUES (24, 24, N'Đạt thành tích trong học tập, rèn luyện (được tặng bằng khen, giấy khen, chứng nhận, thư khen của các cấp)', 0, 2)
GO
INSERT [dbo].[NoiDungChiTiet] ([MaCT], [MaTC], [NoiDung], [DiemCTMax]) VALUES (1, 1, N'Có đi học chuyên cần, đúng giờ, nghiêm túc trong giờ học', 4)
GO
INSERT [dbo].[NoiDungChiTiet] ([MaCT], [MaTC], [NoiDung], [DiemCTMax]) VALUES (2, 1, N'Có đăng ký, thực hiện, báo cáo đề tài nghiên cứu khoa học đúng tiến độ hoặc có đăng ký, tham dự các cuộc thi học thuật cấp Khoa trở lên', 2)
GO
INSERT [dbo].[NoiDungChiTiet] ([MaCT], [MaTC], [NoiDung], [DiemCTMax]) VALUES (3, 1, N'Có ý thức tham gia các câu lạc bộ, câu lạc bộ học thuật, các hoạt động học thuật, hoạt động ngoại khoá', 2)
GO
INSERT [dbo].[NoiDungChiTiet] ([MaCT], [MaTC], [NoiDung], [DiemCTMax]) VALUES (4, 1, N' Bị xử lý kỷ luật trong các kỳ thi kết thúc học phần (khiển trách: -2 điểm, cảnh cáo: -4 điểm, đình chỉ thi: -6 điểm)', 0)
GO
INSERT [dbo].[NoiDungChiTiet] ([MaCT], [MaTC], [NoiDung], [DiemCTMax]) VALUES (5, 1, N'Được tập thể lớp công nhận có tinh thần vượt khó, phấn đấu vươn lên trong học tập', 2)
GO
INSERT [dbo].[NoiDungChiTiet] ([MaCT], [MaTC], [NoiDung], [DiemCTMax]) VALUES (6, 1, N'Kết quả học tập (Yếu kém: 0 điểm; Trung bình: 4 điểm; Khá: 6 điểm; Giỏi: 8 điểm; Xuất sắc: 10 điểm)', 10)
GO
INSERT [dbo].[NoiDungChiTiet] ([MaCT], [MaTC], [NoiDung], [DiemCTMax]) VALUES (7, 2, N' Có ý thức chấp hành các văn bản chỉ đạo của ngành, của trường được thực hiện trong nhà trường (Vi phạm 01 lần bị trừ 02 điểm, từ lần vi phạm thứ hai trở đi bị trừ hết số điểm còn lại của tiêu chí)', 6)
GO
INSERT [dbo].[NoiDungChiTiet] ([MaCT], [MaTC], [NoiDung], [DiemCTMax]) VALUES (8, 2, N'Có ý thức tham gia đầy đủ, đạt yêu cầu các cuộc vận động, sinh hoạt chính trị theo chủ trương, của cấp trên và nhà trường (Không tham gia 01 lần hoặc vi phạm quy định của các cuộc vận động bị trừ 02 điểm, từ lần vi phạm thứ hai trở đi bị trừ hết số điểm còn lại của tiêu chí)', 4)
GO
INSERT [dbo].[NoiDungChiTiet] ([MaCT], [MaTC], [NoiDung], [DiemCTMax]) VALUES (9, 2, N'Có ý thức chấp hành nội quy, quy chế, thực hiện nội quy văn hóa học đường và các quy định của nhà trường (Vi phạm 01 lần bị trừ 02 điểm, từ lần vi phạm thứ ba trở đi bị trừ hết số điểm còn lại của tiêu chí)', 10)
GO
INSERT [dbo].[NoiDungChiTiet] ([MaCT], [MaTC], [NoiDung], [DiemCTMax]) VALUES (10, 2, N'Tham gia đầy đủ, đạt yêu cầu “Tuần sinh hoạt công dân sinh viên” (đánh giá chung cho cả hai học kỳ trong năm học)', 5)
GO
INSERT [dbo].[NoiDungChiTiet] ([MaCT], [MaTC], [NoiDung], [DiemCTMax]) VALUES (11, 3, N'Tham gia các hoạt động, sinh hoạt phong trào, tình nguyện do Khoa tổ chức (Vắng 01 lần (không có phép) bị trừ 02 điểm)', 6)
GO
INSERT [dbo].[NoiDungChiTiet] ([MaCT], [MaTC], [NoiDung], [DiemCTMax]) VALUES (12, 3, N'Tham gia các hoạt động do Đoàn thanh niên và Hội sinh viên tổ chức (tham gia 1 hoạt động được 2 điểm)', 6)
GO
INSERT [dbo].[NoiDungChiTiet] ([MaCT], [MaTC], [NoiDung], [DiemCTMax]) VALUES (13, 3, N'Có ý thức tham gia đầy đủ, nghiêm túc hoạt động rèn luyện về chính trị, xã hội, văn hóa, văn nghệ, thể thao do nhà trường tổ chức, điều động', 4)
GO
INSERT [dbo].[NoiDungChiTiet] ([MaCT], [MaTC], [NoiDung], [DiemCTMax]) VALUES (14, 3, N'Có ý thức tham gia các hoạt động công ích, tình nguyện, công tác xã hội trong nhà trường', 2)
GO
INSERT [dbo].[NoiDungChiTiet] ([MaCT], [MaTC], [NoiDung], [DiemCTMax]) VALUES (15, 3, N'Có ý thức tham gia các hoạt động tuyên truyền, phòng chống tội phạm và các tệ nạn xã hội trong nhà trường', 2)
GO
INSERT [dbo].[NoiDungChiTiet] ([MaCT], [MaTC], [NoiDung], [DiemCTMax]) VALUES (16, 4, N'Có ý thức chấp hành, tham gia tuyên truyền các chủ trương của Đảng, chính sách, pháp luật của Nhà nước (Vi phạm 01 lần bị trừ 02 điểm, từ lần vi phạm thứ hai trở đi bị trừ hết số điểm còn lại của tiêu chí)', 4)
GO
INSERT [dbo].[NoiDungChiTiet] ([MaCT], [MaTC], [NoiDung], [DiemCTMax]) VALUES (17, 4, N'Có tham gia bảo hiểm y tế (bắt buộc) theo Luật bảo hiểm y tế (thực hiện đầy đủ: 10 điểm; không thực hiện: 0 điểm)', 10)
GO
INSERT [dbo].[NoiDungChiTiet] ([MaCT], [MaTC], [NoiDung], [DiemCTMax]) VALUES (18, 4, N'Có ý thức chấp hành, tham gia tuyên truyền các quy định về bảo đảm an toàn giao thông và “văn hóa giao thông” (Vi phạm 01 lần bị trừ 02 điểm, từ lần vi phạm thứ hai trở đi bị trừ hết số điểm còn lại của tiêu chí)', 5)
GO
INSERT [dbo].[NoiDungChiTiet] ([MaCT], [MaTC], [NoiDung], [DiemCTMax]) VALUES (19, 4, N'Có ý thức tham gia các hoạt động xã hội có thành tích được ghi nhận, biểu dương, khen thưởng', 4)
GO
INSERT [dbo].[NoiDungChiTiet] ([MaCT], [MaTC], [NoiDung], [DiemCTMax]) VALUES (20, 4, N'Có tinh thần chia sẻ, giúp đỡ người gặp khó khăn, hoạn nạn', 2)
GO
INSERT [dbo].[NoiDungChiTiet] ([MaCT], [MaTC], [NoiDung], [DiemCTMax]) VALUES (21, 5, N' Có ý thức, uy tín và hoàn thành tốt nhiệm vụ quản lý lớp, các tổ chức Đảng, Đoàn Thanh niên, Hội Sinh viên, tổ chức khác trong nhà trường', 3)
GO
INSERT [dbo].[NoiDungChiTiet] ([MaCT], [MaTC], [NoiDung], [DiemCTMax]) VALUES (22, 5, N'Có kỹ năng tổ chức, quản lý lớp, các tổ chức Đảng, Đoàn Thanh niên, Hội Sinh viên và các tổ chức khác trong nhà trường', 2)
GO
INSERT [dbo].[NoiDungChiTiet] ([MaCT], [MaTC], [NoiDung], [DiemCTMax]) VALUES (23, 5, N'Hỗ trợ và tham gia tích cực các hoạt động chung của tập thể lớp, khoa, trường, tham gia ban tự quản khu nội trú', 3)
GO
INSERT [dbo].[NoiDungChiTiet] ([MaCT], [MaTC], [NoiDung], [DiemCTMax]) VALUES (24, 5, N'Đạt thành tích trong học tập, rèn luyện (được tặng bằng khen, giấy khen, chứng nhận, thư khen của các cấp)', 2)
GO
INSERT [dbo].[TaiKhoan] ([Username], [Password], [ChucVu]) VALUES (N'admin', N'1', N'admin')
GO
INSERT [dbo].[TieuChiDanhGia] ([MaTC], [NoiDung], [DiemTCMax]) VALUES (1, N'Đánh giá ý thức tham gia học tập', 20)
GO
INSERT [dbo].[TieuChiDanhGia] ([MaTC], [NoiDung], [DiemTCMax]) VALUES (2, N'Đánh giá về ý thức chấp hành nội quy, quy chế, quy định trong nhà trường', 20)
GO
INSERT [dbo].[TieuChiDanhGia] ([MaTC], [NoiDung], [DiemTCMax]) VALUES (3, N'Đánh giá ý thức và kết quả tham gia các hoạt động chính trị - xã hội, văn hóa, văn nghệ, thể thao, phòng chống các tệ nạn xã hội', 20)
GO
INSERT [dbo].[TieuChiDanhGia] ([MaTC], [NoiDung], [DiemTCMax]) VALUES (4, N'Đánh giá về ý thức công dân trong quân hệ cộng đồng', 25)
GO
INSERT [dbo].[TieuChiDanhGia] ([MaTC], [NoiDung], [DiemTCMax]) VALUES (5, N'Đánh giá ý thức và kết quả tham gia công tác cán bộ, các đoàn thể, tổ chức trong cơ sở giáo dục đại học hoặc người học đạt được thành tích đặc biệt trong học tập, rèn luyện', 10)
GO
