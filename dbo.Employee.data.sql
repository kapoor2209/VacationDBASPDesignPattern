SET IDENTITY_INSERT [dbo].[Employee] ON
INSERT INTO [dbo].[Employee] ([EmpId], [FirstName], [LastName], [StartingDate], [Email], [DeptID], [DepartmentsDeptId]) VALUES (1, N'Lisa', N'Emy', N'2020-10-07 00:00:00', N'vrandhawa648@gmail.com', 1, NULL)
INSERT INTO [dbo].[Employee] ([EmpId], [FirstName], [LastName], [StartingDate], [Email], [DeptID], [DepartmentsDeptId]) VALUES (2, N'Emmy', N'Liyu', N'2020-10-30 00:00:00', N'Arjunpari33@gmail.com', 2, NULL)
INSERT INTO [dbo].[Employee] ([EmpId], [FirstName], [LastName], [StartingDate], [Email], [DeptID], [DepartmentsDeptId]) VALUES (3, N'Manik', N'Arora', N'2021-01-01 00:00:00', N'ahmedyass234@gmail.com', 3, NULL)
SET IDENTITY_INSERT [dbo].[Employee] OFF
