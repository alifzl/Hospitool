USE [Hospitool]
GO
/****** Object:  StoredProcedure [dbo].[ViewFullDoctorNames]    Script Date: 5/12/2017 10:41:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[ViewFullDoctorNames]
AS
SELECT DoctorName + DoctorSurname as Fullname FROM Doctors
