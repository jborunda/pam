SET IDENTITY_INSERT [dbo].[BureauTypes] ON 

INSERT [dbo].[BureauTypes] ([BureauTypeId], [Code], [DisplayCode]) VALUES (1, N'ADULT', N'Adult')
INSERT [dbo].[BureauTypes] ([BureauTypeId], [Code], [DisplayCode]) VALUES (2, N'JUVENILE', N'Juvenile')
INSERT [dbo].[BureauTypes] ([BureauTypeId], [Code], [DisplayCode]) VALUES (3, N'ADULTJUVENILE', N'Adult and Juvenile')
SET IDENTITY_INSERT [dbo].[BureauTypes] OFF
SET IDENTITY_INSERT [dbo].[Bureaus] ON 

INSERT [dbo].[Bureaus] ([BureauId], [Code], [Description], [BureauTypeId], [DisplayOrder]) VALUES (1, N'ISB', N'Information Systems Bureau', NULL, 11)
INSERT [dbo].[Bureaus] ([BureauId], [Code], [Description], [BureauTypeId], [DisplayOrder]) VALUES (4, N'EXECUTIVE', N'Executives, Assistants', NULL, 1)
INSERT [dbo].[Bureaus] ([BureauId], [Code], [Description], [BureauTypeId], [DisplayOrder]) VALUES (5, N'AFSB', N'Adult Field Services Bureau', NULL, 8)
INSERT [dbo].[Bureaus] ([BureauId], [Code], [Description], [BureauTypeId], [DisplayOrder]) VALUES (6, N'ASB', N'Administrative Services Bureau', NULL, 7)
INSERT [dbo].[Bureaus] ([BureauId], [Code], [Description], [BureauTypeId], [DisplayOrder]) VALUES (7, N'DSB', N'Detention Services Bureau', 2, NULL)
INSERT [dbo].[Bureaus] ([BureauId], [Code], [Description], [BureauTypeId], [DisplayOrder]) VALUES (8, N'JFSB / JSSB', N'Juvenile Field / Special Services Bureau', NULL, 12)
INSERT [dbo].[Bureaus] ([BureauId], [Code], [Description], [BureauTypeId], [DisplayOrder]) VALUES (9, N'DSB / IDC', N'Intake, Detention and Control', NULL, NULL)
INSERT [dbo].[Bureaus] ([BureauId], [Code], [Description], [BureauTypeId], [DisplayOrder]) VALUES (10, N'MSB', N'Management Service Bureau', NULL, 13)
INSERT [dbo].[Bureaus] ([BureauId], [Code], [Description], [BureauTypeId], [DisplayOrder]) VALUES (11, N'PSB', N'Placement Services Bureau', 2, NULL)
INSERT [dbo].[Bureaus] ([BureauId], [Code], [Description], [BureauTypeId], [DisplayOrder]) VALUES (12, N'QASB', N'Quality Assurance Service Bureau', NULL, 16)
INSERT [dbo].[Bureaus] ([BureauId], [Code], [Description], [BureauTypeId], [DisplayOrder]) VALUES (13, N'RTSB', N'Residential Treatment Services Bureau', 2, 17)
INSERT [dbo].[Bureaus] ([BureauId], [Code], [Description], [BureauTypeId], [DisplayOrder]) VALUES (21, N'OTHER', N'Other County Department or Contractor', NULL, NULL)
INSERT [dbo].[Bureaus] ([BureauId], [Code], [Description], [BureauTypeId], [DisplayOrder]) VALUES (39, N'OTHER', N'Other', NULL, 18)
INSERT [dbo].[Bureaus] ([BureauId], [Code], [Description], [BureauTypeId], [DisplayOrder]) VALUES (40, N'PSB', N'Professional Standards Bureau', NULL, 15)
SET IDENTITY_INSERT [dbo].[Bureaus] OFF
