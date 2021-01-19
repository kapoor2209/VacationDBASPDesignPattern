SET IDENTITY_INSERT [dbo].[DaysTaken] ON
INSERT INTO [dbo].[DaysTaken] ([DTId], [EmpId], [EmployeesEmpId], [Type], [VacationType], [CDay]) VALUES (1, 1, NULL, N'Summer', N'Summer', N'2020-10-27 00:00:00')
INSERT INTO [dbo].[DaysTaken] ([DTId], [EmpId], [EmployeesEmpId], [Type], [VacationType], [CDay]) VALUES (2, 1, NULL, N'winter', N'winter', N'2020-07-23 00:00:00')
SET IDENTITY_INSERT [dbo].[DaysTaken] OFF
