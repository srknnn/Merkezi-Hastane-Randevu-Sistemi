
------//GET Fonksiyonlarý
------GETPATÝENT
create view vW_GetPatient
AS
Select PatientID,FirstName+' '+LastName [FullName], IdentitiyNumber,Gender,DateOfBirth,Email,Password,CellPhone,HomePhone,SecurityQuestion,Answer,PlaceOfBirth,MotherName,FatherName From Patient Where Deleted=0
WITH CHECK OPTION


select*from vW_GetPatient

----GET APPOINTMENT
go
alter view vW_GetAppointment
AS
select AppointmentID,pati.PatientID,pati.FirstName + ' ' + pati.LastName [PatientFullName],doc.DoctorID,DoctorFirstName+ ' '+doc.DoctorLastName [DoctorFullName] ,AppointmentDate,AppointmentTime from Appointment apo
inner join Patient pati on pati.PatientID=apo.PatientID
inner join Doctor doc on doc.DoctorID=apo.DoctorID
    where AppointmentStatus=0
WITH CHECK OPTION 

select * from vW_GetAppointment

----------
Create view vW_GetHospitalDetails
AS
SELECT c.CityID,c.CityName,t.TownID,t.TownName,h.HospitalID,h.HospitalName,cli.ClinicBranch,cli.ClinicID,cli.EndTime,cli.StartTime,cli.TimeRange,doc.Deleted,doc.DoctorFirstName + ' ' + doc.DoctorLastName [DoctorFullName],doc.DoctorID,tit.TittleID,tit.TittleName from City c
join Town t ON t.CityID = c.CityID
join Hospital h on h.TownID = t.TownID
join HospitalClinic hc on hc.HospitalID = h.HospitalID
join Clinic cli on cli.ClinicID = hc.ClinicID
join Doctor doc on doc.ClinicID = cli.ClinicID
join Tittle tit on tit.TittleID = doc.TittleID
with check option


select * from vW_GetHospitalDetails





--GET PATIENT ID(PROC)
go
---
Create Proc sp_GetPatientID
@PatientId int
AS
BEGIN
SELECT*FROM [vW_GetPatient] where PatientID=@PatientId
END 
----
exec sp_GetPatientID 1

--GET APPOINMENT ID (PROC)

Create Proc sp_GetAppointmentID
@AppointmentID int
AS
BEGIN
SELECT *FROM vW_GetAppointment where AppointmentID=@AppointmentID
END 

exec sp_GetAppointmentID 5


---AddPatient

alter proc sp_AddPatient
@FirtsName nvarchar(50),
@LastName nvarchar(50),
@IdentityNumber bigint,
@Gender nvarchar(5),
@DateOfBirth datetime,
@Email nvarchar(50),
@Password nvarchar(50),
@CellPhone bigint,
@HomePhone bigint,
@SecurityQuestion nvarchar(50),
@Answer nvarchar(50),
@PlaceOfBirth nvarchar(50)=' ',
@MotherName nvarchar(50)=' ',
@FatherName nvarchar(50)=' ',
@Picture nvarchar(50)=' ',
@Deleted bit =0
AS
BEGIN
Insert into Patient (FirstName,LastName,IdentitiyNumber,Gender,DateOfBirth,Email,Password,CellPhone,HomePhone,SecurityQuestion,Answer,PlaceOfBirth,MotherName,FatherName,Picture,Deleted) Values(@FirtsName,@LastName,@IdentityNumber,@Gender,@DateOfBirth,@Email,@Password,@CellPhone,@HomePhone,@SecurityQuestion,@Answer,@PlaceOfBirth,@MotherName,@FatherName,@Picture,@Deleted)
END


exec sp_AddPatient 'Ferhat','Yýlmaz',560982213874,'Male','1992/04/04','ferht@gmail.com','1234566',4567976547,7359093645,'En sevdiðin Pokomon','Balbazaar','Konya',' ',' ',' ',0