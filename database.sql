USE [master]
GO
/****** Object:  Database [ShopCayCanh]    Script Date: 6/12/2017 1:50:30 PM ******/
CREATE DATABASE [ShopCayCanh]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ShopCayCanh', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\ShopCayCanh.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ShopCayCanh_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\ShopCayCanh_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ShopCayCanh] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ShopCayCanh].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ShopCayCanh] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ShopCayCanh] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ShopCayCanh] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ShopCayCanh] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ShopCayCanh] SET ARITHABORT OFF 
GO
ALTER DATABASE [ShopCayCanh] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ShopCayCanh] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ShopCayCanh] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ShopCayCanh] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ShopCayCanh] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ShopCayCanh] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ShopCayCanh] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ShopCayCanh] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ShopCayCanh] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ShopCayCanh] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ShopCayCanh] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ShopCayCanh] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ShopCayCanh] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ShopCayCanh] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ShopCayCanh] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ShopCayCanh] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ShopCayCanh] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ShopCayCanh] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ShopCayCanh] SET  MULTI_USER 
GO
ALTER DATABASE [ShopCayCanh] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ShopCayCanh] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ShopCayCanh] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ShopCayCanh] SET TARGET_RECOVERY_TIME = 0 SECONDS 
--GO
--ALTER DATABASE [ShopCayCanh] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ShopCayCanh]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 6/12/2017 1:50:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[PassWord] [nvarchar](50) NULL,
	[FullName] [nvarchar](100) NULL,
	[IDNumber] [nvarchar](30) NULL,
	[BirthDay] [nvarchar](10) NULL,
	[Address] [nvarchar](50) NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bill]    Script Date: 6/12/2017 1:50:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[BillId] [int] IDENTITY(1,1) NOT NULL,
	[TimeChanged] [datetime] NULL,
	[TotalCost] [int] NULL,
	[UserId] [int] NULL,
	[CustomerId] [nvarchar](50) NULL,
	[CustomerName] [nvarchar](100) NULL,
	[CustomerAddress] [nvarchar](100) NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[BillId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BillDetail]    Script Date: 6/12/2017 1:50:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillDetail](
	[BillId] [int] NOT NULL,
	[TreeId] [int] NOT NULL,
	[Quantity] [int] NULL,
	[Cost] [int] NULL,
 CONSTRAINT [PK_BillDetail] PRIMARY KEY CLUSTERED 
(
	[BillId] ASC,
	[TreeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Category]    Script Date: 6/12/2017 1:50:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CatId] [int] IDENTITY(1,1) NOT NULL,
	[CatName] [nvarchar](50) NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CatId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Import]    Script Date: 6/12/2017 1:50:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Import](
	[ImportId] [int] IDENTITY(1,1) NOT NULL,
	[TimeChanged] [datetime] NULL,
	[TotalCost] [int] NULL,
	[ProviderId] [int] NULL,
	[UserId] [int] NULL,
 CONSTRAINT [PK_Import_1] PRIMARY KEY CLUSTERED 
(
	[ImportId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ImportDetail]    Script Date: 6/12/2017 1:50:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ImportDetail](
	[ImportId] [int] NOT NULL,
	[TreeId] [int] NOT NULL,
	[Quantity] [int] NULL,
	[Cost] [int] NULL,
 CONSTRAINT [PK_ImportDetail] PRIMARY KEY CLUSTERED 
(
	[ImportId] ASC,
	[TreeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Provider]    Script Date: 6/12/2017 1:50:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provider](
	[ProviderId] [int] IDENTITY(1,1) NOT NULL,
	[ProviderName] [nvarchar](100) NULL,
	[Address] [nvarchar](150) NULL,
	[Phone] [nvarchar](20) NULL,
	[Email] [nvarchar](100) NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_Provider] PRIMARY KEY CLUSTERED 
(
	[ProviderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tree]    Script Date: 6/12/2017 1:50:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tree](
	[TreeId] [int] IDENTITY(1,1) NOT NULL,
	[TreeName] [nvarchar](100) NULL,
	[CatId] [int] NULL,
	[Cost] [int] NULL,
	[Quantity] [int] NULL,
	[Description] [ntext] NULL,
	[Image] [ntext] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_Tree] PRIMARY KEY CLUSTERED 
(
	[TreeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([UserId], [UserName], [PassWord], [FullName], [IDNumber], [BirthDay], [Address], [Status]) VALUES (1, N'1', N'1', N'Vu Khuong Duy', N'188470435', N'5/23/1999', N'thanh liem - ha nam', 1)
INSERT [dbo].[Account] ([UserId], [UserName], [PassWord], [FullName], [IDNumber], [BirthDay], [Address], [Status]) VALUES (2, N'admin', N'1', N'Vu Hoang Ha', N'188 470 435', N'9/10/1995', N'Thanh Liem - Ha Nam', 1)
INSERT [dbo].[Account] ([UserId], [UserName], [PassWord], [FullName], [IDNumber], [BirthDay], [Address], [Status]) VALUES (3, N'ahihi', N'1', N'1', N'1', N'6/11/2017', N'1', 0)
INSERT [dbo].[Account] ([UserId], [UserName], [PassWord], [FullName], [IDNumber], [BirthDay], [Address], [Status]) VALUES (4, N'1212', N'12', N'12', N'12', N'6/11/2017', N'2', 0)
INSERT [dbo].[Account] ([UserId], [UserName], [PassWord], [FullName], [IDNumber], [BirthDay], [Address], [Status]) VALUES (5, N'a', N'a', N'a', N'a', N'6/11/2017', N'a', 0)
SET IDENTITY_INSERT [dbo].[Account] OFF
SET IDENTITY_INSERT [dbo].[Bill] ON 

INSERT [dbo].[Bill] ([BillId], [TimeChanged], [TotalCost], [UserId], [CustomerId], [CustomerName], [CustomerAddress]) VALUES (1, CAST(N'2017-06-11 07:58:23.747' AS DateTime), 1200000, 1, N'188 470 435', N'Vũ Hoàng Hà', N'15, Ngõ 397, đường Phạm Văn Đồng, Quận Bắc Từ Liêm, Hà Nội')
SET IDENTITY_INSERT [dbo].[Bill] OFF
INSERT [dbo].[BillDetail] ([BillId], [TreeId], [Quantity], [Cost]) VALUES (1, 1, 10, 120000)
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CatId], [CatName], [Status]) VALUES (1, N'CÂY ĐỂ BÀN', 1)
INSERT [dbo].[Category] ([CatId], [CatName], [Status]) VALUES (2, N'CÂY ĐỂ SẢNH', 1)
INSERT [dbo].[Category] ([CatId], [CatName], [Status]) VALUES (3, N'CÂY TRỒNG VƯỜN', 1)
INSERT [dbo].[Category] ([CatId], [CatName], [Status]) VALUES (4, N'CÂY HOA', 1)
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Import] ON 

INSERT [dbo].[Import] ([ImportId], [TimeChanged], [TotalCost], [ProviderId], [UserId]) VALUES (1, CAST(N'2017-06-11 07:49:49.270' AS DateTime), 26000000, 2, 1)
INSERT [dbo].[Import] ([ImportId], [TimeChanged], [TotalCost], [ProviderId], [UserId]) VALUES (2, CAST(N'2017-06-11 07:53:36.803' AS DateTime), 3000000, 1, 1)
SET IDENTITY_INSERT [dbo].[Import] OFF
INSERT [dbo].[ImportDetail] ([ImportId], [TreeId], [Quantity], [Cost]) VALUES (1, 1, 100, 120000)
INSERT [dbo].[ImportDetail] ([ImportId], [TreeId], [Quantity], [Cost]) VALUES (1, 2, 50, 100000)
INSERT [dbo].[ImportDetail] ([ImportId], [TreeId], [Quantity], [Cost]) VALUES (1, 3, 10, 50000)
INSERT [dbo].[ImportDetail] ([ImportId], [TreeId], [Quantity], [Cost]) VALUES (1, 4, 50, 100000)
INSERT [dbo].[ImportDetail] ([ImportId], [TreeId], [Quantity], [Cost]) VALUES (1, 5, 50, 70000)
INSERT [dbo].[ImportDetail] ([ImportId], [TreeId], [Quantity], [Cost]) VALUES (2, 1, 10, 100000)
INSERT [dbo].[ImportDetail] ([ImportId], [TreeId], [Quantity], [Cost]) VALUES (2, 12, 20, 100000)
SET IDENTITY_INSERT [dbo].[Provider] ON 

INSERT [dbo].[Provider] ([ProviderId], [ProviderName], [Address], [Phone], [Email], [Status]) VALUES (1, N'CÔNG TY CỔ PHẦN GIỐNG CÂY TRỒNG', N'Số 234 - Láng Hạ - Cầu Giấy - Hà Nội', N'0983 495 465', N'giongcaytrong@gmail.com', 1)
INSERT [dbo].[Provider] ([ProviderId], [ProviderName], [Address], [Phone], [Email], [Status]) VALUES (2, N'CÔNG TY GIỐNG CÂY TRỒNG HÀ NỘI', N'136 Hồ Tùng Mậu, Quận Cầu Giấy, Hà Nội', N'04 3764 3447', N'caytronghanoi@gmail.com', 1)
INSERT [dbo].[Provider] ([ProviderId], [ProviderName], [Address], [Phone], [Email], [Status]) VALUES (3, N'CÔNG TY TNHH GIỐNG CÂY TRỒNG HOÀNG NÔNG', N'143 Đường Lê Lợi , TP Phủ Lý, Hà Nam', N'04 5578 5588', N'caytronghoangnong@gmail.com', 1)
INSERT [dbo].[Provider] ([ProviderId], [ProviderName], [Address], [Phone], [Email], [Status]) VALUES (4, N'CÔNG TY CỔ PHẦN GIỐNG CÂY TRỒNG HÀ TÂY', N'142 đường Chiến Thắng, huyện Thường Tín, Hà Nội', N'04 5588 6666', N'caytronghatay@gmail.com', 1)
SET IDENTITY_INSERT [dbo].[Provider] OFF
SET IDENTITY_INSERT [dbo].[Tree] ON 

INSERT [dbo].[Tree] ([TreeId], [TreeName], [CatId], [Cost], [Quantity], [Description], [Image], [Status]) VALUES (1, N'THIẾT MỘC LAN KHÚC', 2, 120000, 100, N'', NULL, 1)
INSERT [dbo].[Tree] ([TreeId], [TreeName], [CatId], [Cost], [Quantity], [Description], [Image], [Status]) VALUES (2, N'CÂY VẠN NIÊN THANH', 2, 200000, 50, N'Cây Vạn Niên Thanh sống lâu năm mà vẫn xanh tốt, vào mùa đông lá không héo úa nên được coi là loài cây cát tường, ưa chuộng và sử dụng rộng rãi, dùng Vạn Niên Thanh trong ngày lễ tết là ngụ ý sung túc tốt đẹp, trong việc hôn nhân là cầu chúc như ý, trong lễ mùng thọ là để chúc sống lâu.', NULL, 1)
INSERT [dbo].[Tree] ([TreeId], [TreeName], [CatId], [Cost], [Quantity], [Description], [Image], [Status]) VALUES (3, N'CÂY ĐẠI PHÚ GIA', 1, 150000, 10, N'Cây đại phú gia trổ bông, mùi hương rất nồng giống như mùi sâm, bông của cây đại phú gia mầu trắng được bao bọc bởi ống giống như chiếc lá non mới, cây Đại Phú Gia hiện nay là loại cây đang được yêu thích trên thị trường cây văn phòng, nhà ở, biệt thự và sân vườn. ', NULL, 1)
INSERT [dbo].[Tree] ([TreeId], [TreeName], [CatId], [Cost], [Quantity], [Description], [Image], [Status]) VALUES (4, N'CÂY NGŨ GIA BÌ', 2, 200000, 50, N'Cây Ngũ Gia Bì là loại cây nội thất được nhiều người tìm trồng hiện nay, không vì cây quý hiếm mà giá trị thiết thực cây mang lại thì không thể chối cải, ngoài làm cảnh, cây còn nhiều công dụng khác như chửa bệnh, cải thiện môi trường, đuổi muỗi.', NULL, 1)
INSERT [dbo].[Tree] ([TreeId], [TreeName], [CatId], [Cost], [Quantity], [Description], [Image], [Status]) VALUES (5, N'CÂY TRÚC NHẬT', 1, 120000, 50, N'Cây Trúc Nhật có dáng mảnh mai, sang trọng, cây có tác dụng thanh lọc không khí, tạo không gian thoáng mát. Ngoài ra, theo ý nghĩa phong thủy cây Trúc Nhật còn có tác dụng trừ tà, đêm lại tốt lành cho gia đình.', NULL, 1)
INSERT [dbo].[Tree] ([TreeId], [TreeName], [CatId], [Cost], [Quantity], [Description], [Image], [Status]) VALUES (6, N'CÂY TRẦU BÀ ĐẾ VƯƠNG ĐỎ', 2, 150000, 0, N'Cây Trầu Bà Đế Vương Đỏ có khả năng hấp thụ rất nhiều loại khí độc và chất độc thải ra như khói thuốc, xăng xe, bức xạ máy tính, điện thoại, chất làm lạnh trong phòng máy lạnh, các khí benzen… bởi vậy không ngoa khi xếp Trầu bà đế vương đỏ vào loại vô địch trong hấp thụ các độc tố trong các loại cây nội thất.', NULL, 1)
INSERT [dbo].[Tree] ([TreeId], [TreeName], [CatId], [Cost], [Quantity], [Description], [Image], [Status]) VALUES (7, N'CÂY HỒNG MÔN', 1, 120000, 0, N'Nhẹ nhàng, thanh thoát và tinh tế chính là vẻ đẹp của Cây Hồng Môn, bạn nên kết hợp Cây Hồng Môn với những chậu thủy tinh đầy màu sắc sẽ là điểm nhấn tuyệt vời cho không gian sống.', NULL, 1)
INSERT [dbo].[Tree] ([TreeId], [TreeName], [CatId], [Cost], [Quantity], [Description], [Image], [Status]) VALUES (8, N'CÂY CAU HAWAI', 2, 150000, 0, N'Cây Câu Hawai thân cao mảnh mai, mang lại vẻ ấn tượng cùng cảm giác thư thái, mát lành. Cây có tán xum xuê bắt mắt, ngoài khả năng hấp thụ độc tố họa học, thanh lọc không khí cây còn có ý nghĩa giúp xua tan những điều không may, mang lại phú quý thịnh vượng.', NULL, 1)
INSERT [dbo].[Tree] ([TreeId], [TreeName], [CatId], [Cost], [Quantity], [Description], [Image], [Status]) VALUES (9, N'CÂY KIM PHÁT TÀI', 2, 200000, 0, N'Cây Kim Phát Tài hay còn gọi là Cây Kim Tiền, phát tài thể hiện sự phú quý, giàu sang và tiền bạc, mang đến nhiều tài lộc và may mắn cho gia chủ, đặc biệt khi cây nở hoa sẽ mang lại nhiều lộc và may mắn nhất.', NULL, 1)
INSERT [dbo].[Tree] ([TreeId], [TreeName], [CatId], [Cost], [Quantity], [Description], [Image], [Status]) VALUES (10, N'CÂY PHÁT TÀI NÚI', 3, 2500000, 0, N'Cây Phát Tài Núi hay còn gọi là cây phất dụ huyết rồng, cây nở hoa rất đẹp, là loại cây cảnh thích hợp trong trang trí sân vườn, hoa viên hay cũng có thể trồng trong chậu làm cây nội  thất.', NULL, 1)
INSERT [dbo].[Tree] ([TreeId], [TreeName], [CatId], [Cost], [Quantity], [Description], [Image], [Status]) VALUES (11, N'CÂY KIM NGÂN', 1, 200000, 0, N'Cây kim ngân là một trong những loại cây nội thất đẹp, cây được trồng trong chậu trang trí tại bàn làm việc, phòng khách, khách sạn, văn phòng, cây mang ý nghĩa may mắn, thịnh vượng, đêm lại tài lộc cho gia chủ nên được nhiều người tìm mua.', NULL, 1)
INSERT [dbo].[Tree] ([TreeId], [TreeName], [CatId], [Cost], [Quantity], [Description], [Image], [Status]) VALUES (12, N'CÂY PHÚC LỘC THỌ', 1, 150000, 20, N'Cây phúc lộc thọ là một trong những cây mang ý nghĩa đêm đến may mắn, tài lộc nên được nhiều người tìm mua về trồng làm cây trang trí nội thất, sân vườn, hoặc làm quà tặng ý nghĩa, cây còn có một số tên gọi khác như phước lộc thọ hay lộc xoan.', NULL, 1)
INSERT [dbo].[Tree] ([TreeId], [TreeName], [CatId], [Cost], [Quantity], [Description], [Image], [Status]) VALUES (13, N'CÂY VẠN LỘC', 1, 200000, 0, N'Cây Vạn Lộc tượng trưng cho sự may mắn, mang đến thịnh vượng cho gia chủ, phát tài phát lộc, là món quà ý nghĩa trao tặng nhau, cây còn có tác dụng thanh lọc không khí, tạo không gian trong lành thoáng mát.', NULL, 1)
INSERT [dbo].[Tree] ([TreeId], [TreeName], [CatId], [Cost], [Quantity], [Description], [Image], [Status]) VALUES (14, N'CÂY BẠCH MÃ HOÀNG TỬ', 1, 150000, 0, N'Cây bạch mã hoàng tử là loại cây thân thảo mọc thành bụi, mang dóc vóc của một chàng trai lịch lãm và phong độ, ngoài ra cây còn có nghĩa là tiến nhanh, thuận buồm xuôi gió trong công việc cũng như trong cuộc sống. Cây có tác dụng thanh lọc và điều hòa không khí, tốt cho sức khỏe.', NULL, 1)
INSERT [dbo].[Tree] ([TreeId], [TreeName], [CatId], [Cost], [Quantity], [Description], [Image], [Status]) VALUES (15, N'CÂY DẠ LAN THANH', 1, 200000, 0, N'Cây Dạ Lan Thanh mang đến không gian sống tươi mát, là một loại cây kiểng đẹp nên thường được dùng làm trang trí nội thất, cây Dạ Lan Thanh ngụ ý sung túc tốt đẹp, trong việc hôn nhân là cầu chúc như ý, trong lễ mùng thọ là để chúc sống lâu.', NULL, 1)
INSERT [dbo].[Tree] ([TreeId], [TreeName], [CatId], [Cost], [Quantity], [Description], [Image], [Status]) VALUES (16, N'CÂY DỨA CẢNH NẾN', 1, 250000, 0, N'Cây dứa cảnh nến là cây cảnh đẹp, lá bắc có màu cam, đỏ, vàng xếp lên nhau tạo hình ngôi sao giống bông hoa rất đẹp, cây được trồng trang trí nội thất, cây dể bàn, ngoại thất.', NULL, 1)
INSERT [dbo].[Tree] ([TreeId], [TreeName], [CatId], [Cost], [Quantity], [Description], [Image], [Status]) VALUES (17, N'CÂY TRÚC BÁCH HỢP', 1, 150000, 0, N'Cây Trúc Bách Hợp thường được trồng chậu làm cảnh trang trí văn phòng, sảnh, hành lang, phòng khách hay sân vườn, có khả năng điều hòa không khí và độ ẩm cho không gian khép kín, ngoài ra Trúc Bách Hợp mang lại may mắn cho gia chủ', NULL, 1)
INSERT [dbo].[Tree] ([TreeId], [TreeName], [CatId], [Cost], [Quantity], [Description], [Image], [Status]) VALUES (18, N'CÂY ĐUÔI CÔNG', 1, 45000, 0, N'Cây đuôi công có lá trông rất đẹp, hình thù trông giống với đuôi công, cây dể chăm sóc, sinh trưởng tốt, thường được trồng làm cây nội thất, trồng viền, mua làm quà tặng, cây mang ý nghĩa thịnh vượn, may mắn.', NULL, 1)
INSERT [dbo].[Tree] ([TreeId], [TreeName], [CatId], [Cost], [Quantity], [Description], [Image], [Status]) VALUES (19, N'CÂY NGỌC NGÂN', 2, 80000, 0, N'Cây Ngọc Ngân là loại cây dành cho tình yêu, món quà ý nghĩa để dành tặng riêng cho người yêu, ngoài ra cây còn làm không gian xanh tươi, tạo sự cân bằng giữa thiên nhiên và con người.', NULL, 1)
INSERT [dbo].[Tree] ([TreeId], [TreeName], [CatId], [Cost], [Quantity], [Description], [Image], [Status]) VALUES (20, N'HOA HỒNG LEO', 4, 400000, 0, N'Hoa hồng leo thường có các màu hồng cánh sen, hồng phấn nhạt, hoa hồng đỏ, hoa hồng leo trắng, hoa hồng leo màu cam, hoa hồng leo màu đỏ…', NULL, 1)
INSERT [dbo].[Tree] ([TreeId], [TreeName], [CatId], [Cost], [Quantity], [Description], [Image], [Status]) VALUES (21, N'DẠ YẾN THẢO CHẬU GHÉP', 4, 1000000, 0, N'Hoa dạ yên thảo rũ thích ánh nắng và khí hậu nhiệt đới. Tuy nhiên cần tưới nước thường xuyên với lượng vừa phải để giữ ẩm cho cây và giúp hoa luôn tươi sắc. Dã yên thảo rũ có tốc độ sinh trưởng nhanh, cây có hoa liên tục, hết đợt này đến đợt khác, dễ tìm các loại giống, dễ trồng và dễ chăm sóc
Cây cảnh dạ yên thảo rất nhạy cảm với flo, vì thế có thể dùng để giám sát chất lượng không khí.', NULL, 1)
INSERT [dbo].[Tree] ([TreeId], [TreeName], [CatId], [Cost], [Quantity], [Description], [Image], [Status]) VALUES (22, N'HOA THANH TÚ', 4, 500000, 0, N'Thanh Tú là loài thân cỏ, phân nhiều cành nhánh, trên thân và cành nhánh có lớp lông trắng mịn bao phủ. Lá đơn, mọc cách so le, dạng trái xoan nhỏ, cũng có phủ lớp lông mịn. Hoa thanh tú mọc ra từ nách lá, cánh tràng có màu xanh lam biếc với 5 cánh dính thành ống loe rộng trên 1 mặt phẳng, nhụy vươn lên từ tâm điểm hình ngôi sao màu trắng.', NULL, 1)
INSERT [dbo].[Tree] ([TreeId], [TreeName], [CatId], [Cost], [Quantity], [Description], [Image], [Status]) VALUES (23, N'CHẬU HOA LAN Ý', 4, 400000, 0, N'Cây Lan Ý khi trồng trong chậu thủy tinh được dùng để trang trí tủ, kệ, bàn làm việc, bàn học tập, quầy tiếp tân, bàn trà…

Lan Ý rất ưa bóng râm hoặc nơi không có ánh sáng trực tiếp. Cây cần nước nhiều để sinh trưởng tốt nên cần phải cung cấp đầy đủ nước cho cây. Nếu là cây trong nước thì cần thay nước 4-6 ngày/ lần.', NULL, 1)
INSERT [dbo].[Tree] ([TreeId], [TreeName], [CatId], [Cost], [Quantity], [Description], [Image], [Status]) VALUES (24, N'HOA HỒNG TỈ MUỘI', 4, 500000, 0, N'Hoa hồng tỷ muội mang ý nghĩa như tên của nó. Nếu bạn được ai đó tặng  những đóa hoa hồng tỉ muội, như thế bạn nên hiểu rằng người đó coi mình  như người thân - anh em hoặc chị em.', NULL, 1)
SET IDENTITY_INSERT [dbo].[Tree] OFF
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[Account] ([UserId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_User]
GO
ALTER TABLE [dbo].[BillDetail]  WITH CHECK ADD  CONSTRAINT [FK_BillDetail_Bill] FOREIGN KEY([BillId])
REFERENCES [dbo].[Bill] ([BillId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BillDetail] CHECK CONSTRAINT [FK_BillDetail_Bill]
GO
ALTER TABLE [dbo].[BillDetail]  WITH CHECK ADD  CONSTRAINT [FK_BillDetail_Tree] FOREIGN KEY([TreeId])
REFERENCES [dbo].[Tree] ([TreeId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BillDetail] CHECK CONSTRAINT [FK_BillDetail_Tree]
GO
ALTER TABLE [dbo].[Import]  WITH CHECK ADD  CONSTRAINT [FK_Import_Provider] FOREIGN KEY([ProviderId])
REFERENCES [dbo].[Provider] ([ProviderId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Import] CHECK CONSTRAINT [FK_Import_Provider]
GO
ALTER TABLE [dbo].[Import]  WITH CHECK ADD  CONSTRAINT [FK_Import_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[Account] ([UserId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Import] CHECK CONSTRAINT [FK_Import_User]
GO
ALTER TABLE [dbo].[ImportDetail]  WITH CHECK ADD  CONSTRAINT [FK_ImportDetail_Import] FOREIGN KEY([ImportId])
REFERENCES [dbo].[Import] ([ImportId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ImportDetail] CHECK CONSTRAINT [FK_ImportDetail_Import]
GO
ALTER TABLE [dbo].[ImportDetail]  WITH CHECK ADD  CONSTRAINT [FK_ImportDetail_Tree] FOREIGN KEY([TreeId])
REFERENCES [dbo].[Tree] ([TreeId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ImportDetail] CHECK CONSTRAINT [FK_ImportDetail_Tree]
GO
ALTER TABLE [dbo].[Tree]  WITH CHECK ADD  CONSTRAINT [FK_Tree_Category] FOREIGN KEY([CatId])
REFERENCES [dbo].[Category] ([CatId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tree] CHECK CONSTRAINT [FK_Tree_Category]
GO
USE [master]
GO
ALTER DATABASE [ShopCayCanh] SET  READ_WRITE 
GO
