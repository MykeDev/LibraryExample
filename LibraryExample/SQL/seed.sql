USE [LibraryExample]
GO
SET IDENTITY_INSERT [dbo].[Autors] ON 
GO
INSERT [dbo].[Autors] ([Id], [Name], [Surname], [Description], [IsDeleted]) VALUES (1, N'J.K.', N'Rowling', N'Autorka serii Harry Potter'				,0); 
INSERT [dbo].[Autors] ([Id], [Name], [Surname], [Description], [IsDeleted]) VALUES (2, N'Stephen', N'King', N'To po prostu stefan'						,0); 
INSERT [dbo].[Autors] ([Id], [Name], [Surname], [Description], [IsDeleted]) VALUES (3, N'John Ronald Reuel', N'Tolkien', N'Autor uniwersum Śródziemia'	,0); 
INSERT [dbo].[Autors] ([Id], [Name], [Surname], [Description], [IsDeleted]) VALUES (4, N'Suzanne', N'Collins', N'Zasłynęła serią Igrzyska Śmierci'		,0); 
INSERT [dbo].[Autors] ([Id], [Name], [Surname], [Description], [IsDeleted]) VALUES (5, N'Stephenie', N'Meyer', N'Autorka sagi Zmierzch'					,0); 
INSERT [dbo].[Autors] ([Id], [Name], [Surname], [Description], [IsDeleted]) VALUES (7, N'John Ronald Reuel', N'Tolkien', N'Autor uniwersum Śródziemia'	,0); 
SET IDENTITY_INSERT [dbo].[Autors] OFF 
GO
SET IDENTITY_INSERT [dbo].[Books] ON 
GO
INSERT [dbo].[Books] ([Id], [Title], [Year], [Autors.Id], [IsDeleted]) VALUES (1, N'Harry Potter i Kamień Filozoficzny', 1997, 1, 0)
INSERT [dbo].[Books] ([Id], [Title], [Year], [Autors.Id], [IsDeleted]) VALUES (2, N'Harry Potter i Komnata Tajemnic', 1998, 1	, 0)
INSERT [dbo].[Books] ([Id], [Title], [Year], [Autors.Id], [IsDeleted]) VALUES (3, N'Harry Potter i więzień Azkabanu', 1999, 1	, 0)
INSERT [dbo].[Books] ([Id], [Title], [Year], [Autors.Id], [IsDeleted]) VALUES (4, N'Harry Potter i Czara Ognia', 2000, 1		, 0)
INSERT [dbo].[Books] ([Id], [Title], [Year], [Autors.Id], [IsDeleted]) VALUES (5, N'Harry Potter i Zakon Feniksa', 2003, 1		, 0)
INSERT [dbo].[Books] ([Id], [Title], [Year], [Autors.Id], [IsDeleted]) VALUES (6, N'Harry Potter i Książę Półkrwi', 2005, 1		, 0)
INSERT [dbo].[Books] ([Id], [Title], [Year], [Autors.Id], [IsDeleted]) VALUES (7, N'Harry Potter i Insygnia Śmierci', 2007, 1	, 0)
INSERT [dbo].[Books] ([Id], [Title], [Year], [Autors.Id], [IsDeleted]) VALUES (8, N'Miasteczko Salem', 1975, 2					, 0)
INSERT [dbo].[Books] ([Id], [Title], [Year], [Autors.Id], [IsDeleted]) VALUES (9, N'Lśnienie', 1977, 2							, 0)
INSERT [dbo].[Books] ([Id], [Title], [Year], [Autors.Id], [IsDeleted]) VALUES (10, N'Mroczna Wieża I: Roland', 1982, 2			, 0)
INSERT [dbo].[Books] ([Id], [Title], [Year], [Autors.Id], [IsDeleted]) VALUES (11, N'Smętarz dla zwierzaków', 1983, 2			, 0)
INSERT [dbo].[Books] ([Id], [Title], [Year], [Autors.Id], [IsDeleted]) VALUES (12, N'Zielona mila', 1996, 2						, 0)
INSERT [dbo].[Books] ([Id], [Title], [Year], [Autors.Id], [IsDeleted]) VALUES (13, N'Drużyna Pierścienia', 1954, 3				, 0)
INSERT [dbo].[Books] ([Id], [Title], [Year], [Autors.Id], [IsDeleted]) VALUES (14, N'Dwie wieże', 1954, 3						, 0)
INSERT [dbo].[Books] ([Id], [Title], [Year], [Autors.Id], [IsDeleted]) VALUES (15, N'Powrót króla', 1955, 3						, 0)
INSERT [dbo].[Books] ([Id], [Title], [Year], [Autors.Id], [IsDeleted]) VALUES (16, N'Hobbit, czyli tam i z powrotem', 1937, 3	, 0)
INSERT [dbo].[Books] ([Id], [Title], [Year], [Autors.Id], [IsDeleted]) VALUES (17, N'Igrzyska śmierci', 2008, 4					, 0)
INSERT [dbo].[Books] ([Id], [Title], [Year], [Autors.Id], [IsDeleted]) VALUES (18, N'W pierścieniu ognia', 2009, 4				, 0)
INSERT [dbo].[Books] ([Id], [Title], [Year], [Autors.Id], [IsDeleted]) VALUES (19, N'Kosogłos', 2010, 4							, 0)
INSERT [dbo].[Books] ([Id], [Title], [Year], [Autors.Id], [IsDeleted]) VALUES (20, N'Zmierzch', 2005, 5							, 0)
INSERT [dbo].[Books] ([Id], [Title], [Year], [Autors.Id], [IsDeleted]) VALUES (21, N'Księżyc w nowiu', 2006, 5					, 0)
INSERT [dbo].[Books] ([Id], [Title], [Year], [Autors.Id], [IsDeleted]) VALUES (22, N'Zaćmienie', 2007, 5						, 0)
INSERT [dbo].[Books] ([Id], [Title], [Year], [Autors.Id], [IsDeleted]) VALUES (23, N'Przed świtem', 2008, 5						, 0)
INSERT [dbo].[Books] ([Id], [Title], [Year], [Autors.Id], [IsDeleted]) VALUES (24, N'Intruz', 2008, 5							, 0)
INSERT [dbo].[Books] ([Id], [Title], [Year], [Autors.Id], [IsDeleted]) VALUES (25, N'Drużyna Pierścienia', 1954, 7				, 0)
INSERT [dbo].[Books] ([Id], [Title], [Year], [Autors.Id], [IsDeleted]) VALUES (26, N'Dwie wieże', 1954, 7						, 0)
INSERT [dbo].[Books] ([Id], [Title], [Year], [Autors.Id], [IsDeleted]) VALUES (27, N'Powrót królaA', 1955, 7					, 0)
INSERT [dbo].[Books] ([Id], [Title], [Year], [Autors.Id], [IsDeleted]) VALUES (28, N'Hobbit, czyli tam i z powrotem', 1937, 7	, 0)
SET IDENTITY_INSERT [dbo].[Books] OFF 
GO
SET IDENTITY_INSERT [dbo].[Clients] ON 
GO
INSERT [dbo].[Clients] ([Id], [Name], [Surname], [PhoneNumber], [AccountCreationDate], [IsDeleted]) VALUES (1, N'Piotr', N'Nowak', NULL, CAST(N'2017-05-20' AS Date)				, 0)
INSERT [dbo].[Clients] ([Id], [Name], [Surname], [PhoneNumber], [AccountCreationDate], [IsDeleted]) VALUES (2, N'Jan', N'Kowalski', N'624612642', CAST(N'2018-01-10' AS Date)		, 0)
INSERT [dbo].[Clients] ([Id], [Name], [Surname], [PhoneNumber], [AccountCreationDate], [IsDeleted]) VALUES (3, N'Grażyna', N'Baton', N'782812412', CAST(N'2018-02-02' AS Date)		, 0)
INSERT [dbo].[Clients] ([Id], [Name], [Surname], [PhoneNumber], [AccountCreationDate], [IsDeleted]) VALUES (4, N'Grzegorz', N'Zamojski', N'603203203', CAST(N'2018-02-20' AS Date)	, 0)
INSERT [dbo].[Clients] ([Id], [Name], [Surname], [PhoneNumber], [AccountCreationDate], [IsDeleted]) VALUES (5, N'Paweł', N'Kowalewski', N'521512241', CAST(N'2018-03-12' AS Date)	, 0)
INSERT [dbo].[Clients] ([Id], [Name], [Surname], [PhoneNumber], [AccountCreationDate], [IsDeleted]) VALUES (6, N'Adam', N'Pszczółka', N'621021057', CAST(N'2018-03-13' AS Date)		, 0)
INSERT [dbo].[Clients] ([Id], [Name], [Surname], [PhoneNumber], [AccountCreationDate], [IsDeleted]) VALUES (7, N'Marek', N'Zaczyk', N'982012051', CAST(N'2018-04-25' AS Date)		, 0)
INSERT [dbo].[Clients] ([Id], [Name], [Surname], [PhoneNumber], [AccountCreationDate], [IsDeleted]) VALUES (8, N'Marta', N'Godlewska', N'876124721', CAST(N'2018-04-30' AS Date)	, 0)
SET IDENTITY_INSERT [dbo].[Clients] OFF
GO
SET IDENTITY_INSERT [dbo].[Loans] ON 
GO
INSERT [dbo].[Loans] ([Id], [StartDate], [EndDate], [Books.Id], [Clients.Id], [IsDeleted]) VALUES (1, CAST(N'2019-01-20T15:24:00.000' AS DateTime), CAST(N'2019-01-25T10:24:00.000' AS DateTime), 20, 1	, 0)
INSERT [dbo].[Loans] ([Id], [StartDate], [EndDate], [Books.Id], [Clients.Id], [IsDeleted]) VALUES (2, CAST(N'2019-01-22T09:40:00.000' AS DateTime), CAST(N'2019-01-23T18:00:00.000' AS DateTime), 15, 3	, 0)
INSERT [dbo].[Loans] ([Id], [StartDate], [EndDate], [Books.Id], [Clients.Id], [IsDeleted]) VALUES (3, CAST(N'2019-01-22T09:40:00.000' AS DateTime), CAST(N'2019-01-23T18:00:00.000' AS DateTime), 15, 3	, 0)
INSERT [dbo].[Loans] ([Id], [StartDate], [EndDate], [Books.Id], [Clients.Id], [IsDeleted]) VALUES (4, CAST(N'2019-01-22T14:22:00.000' AS DateTime), CAST(N'2019-01-26T15:00:00.000' AS DateTime), 6, 5	, 0)
INSERT [dbo].[Loans] ([Id], [StartDate], [EndDate], [Books.Id], [Clients.Id], [IsDeleted]) VALUES (5, CAST(N'2019-05-23T00:00:00.000' AS DateTime), NULL, 1, 4											, 0)
INSERT [dbo].[Loans] ([Id], [StartDate], [EndDate], [Books.Id], [Clients.Id], [IsDeleted]) VALUES (6, CAST(N'2019-05-23T22:17:10.227' AS DateTime), NULL, 4, 2											, 0)
INSERT [dbo].[Loans] ([Id], [StartDate], [EndDate], [Books.Id], [Clients.Id], [IsDeleted]) VALUES (1006, CAST(N'2019-05-23T22:28:20.137' AS DateTime), NULL, 19, 7										, 0)
SET IDENTITY_INSERT [dbo].[Loans] OFF
GO
SET IDENTITY_INSERT [dbo].[Reservations] ON 
GO
INSERT [dbo].[Reservations] ([Id], [StartDate], [EndDate], [Books.Id], [Clients.Id], [Loans.Id], [IsDeleted]) VALUES (1, CAST(N'2019-05-20T18:33:00.000' AS DateTime), CAST(N'2019-05-23T00:00:00.000' AS DateTime), 1, 4, 5	, 0)
INSERT [dbo].[Reservations] ([Id], [StartDate], [EndDate], [Books.Id], [Clients.Id], [Loans.Id], [IsDeleted]) VALUES (2, CAST(N'2019-05-21T19:21:00.000' AS DateTime), CAST(N'2019-05-23T22:17:10.227' AS DateTime), 4, 2, 6	, 0)
INSERT [dbo].[Reservations] ([Id], [StartDate], [EndDate], [Books.Id], [Clients.Id], [Loans.Id], [IsDeleted]) VALUES (3, CAST(N'2019-05-22T12:20:00.000' AS DateTime), CAST(N'2019-05-23T22:43:11.230' AS DateTime), 19, 7, NULL, 0)
SET IDENTITY_INSERT [dbo].[Reservations] OFF
GO
