SET IDENTITY_INSERT [dbo].[DaysTaken] ON
INSERT INTO [dbo].[DaysTaken] ([DTId], [EmpId], [EmployeesEmpId], [Type], [VacationType], [CDay]) VALUES (1, 1, NULL, N'Summer', N'Summer', N'2020-10-27 00:00:00')
INSERT INTO [dbo].[DaysTaken] ([DTId], [EmpId], [EmployeesEmpId], [Type], [VacationType], [CDay]) VALUES (2, 1, NULL, N'winter', N'winter', N'2020-07-23 00:00:00')
SET IDENTITY_INSERT [dbo].[DaysTaken] OFF


SET IDENTITY_INSERT [dbo].[Department] ON
INSERT INTO [dbo].[Department] ([DeptId], [DeptName]) VALUES (1, N'hamilton')
INSERT INTO [dbo].[Department] ([DeptId], [DeptName]) VALUES (2, N'Auckland')
INSERT INTO [dbo].[Department] ([DeptId], [DeptName]) VALUES (3, N'wellington')
SET IDENTITY_INSERT [dbo].[Department] OFF

SET IDENTITY_INSERT [dbo].[Employee] ON
INSERT INTO [dbo].[Employee] ([EmpId], [FirstName], [LastName], [StartingDate], [Email], [DeptID], [DepartmentsDeptId]) VALUES (1, N'Lisa', N'Emy', N'2020-10-07 00:00:00', N'vrandhawa648@gmail.com', 1, NULL)
INSERT INTO [dbo].[Employee] ([EmpId], [FirstName], [LastName], [StartingDate], [Email], [DeptID], [DepartmentsDeptId]) VALUES (2, N'Emmy', N'Liyu', N'2020-10-30 00:00:00', N'Arjunpari33@gmail.com', 2, NULL)
INSERT INTO [dbo].[Employee] ([EmpId], [FirstName], [LastName], [StartingDate], [Email], [DeptID], [DepartmentsDeptId]) VALUES (3, N'Manik', N'Arora', N'2021-01-01 00:00:00', N'ahmedyass234@gmail.com', 3, NULL)
SET IDENTITY_INSERT [dbo].[Employee] OFF


SET IDENTITY_INSERT [dbo].[RequestDate] ON
INSERT INTO [dbo].[RequestDate] ([RDId], [EmpId], [EmployeesEmpId], [Type], [VacationType], [CDay]) VALUES (1, 2, NULL, N'manager', N'summer', N'2020-12-07 00:00:00')
INSERT INTO [dbo].[RequestDate] ([RDId], [EmpId], [EmployeesEmpId], [Type], [VacationType], [CDay]) VALUES (2, 1, NULL, N'Worker', N'Winter', N'2020-04-29 00:00:00')
SET IDENTITY_INSERT [dbo].[RequestDate] OFF
