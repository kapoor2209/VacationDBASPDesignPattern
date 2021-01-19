SET IDENTITY_INSERT [dbo].[RequestDate] ON
INSERT INTO [dbo].[RequestDate] ([RDId], [EmpId], [EmployeesEmpId], [Type], [VacationType], [CDay]) VALUES (1, 2, NULL, N'manager', N'summer', N'2020-12-07 00:00:00')
INSERT INTO [dbo].[RequestDate] ([RDId], [EmpId], [EmployeesEmpId], [Type], [VacationType], [CDay]) VALUES (2, 1, NULL, N'Worker', N'Winter', N'2020-04-29 00:00:00')
SET IDENTITY_INSERT [dbo].[RequestDate] OFF
