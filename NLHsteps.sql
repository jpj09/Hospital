create database NLH;
GO



CREATE TABLE Beds 
(
BedNumber varchar (20)NOT NULL PRIMARY KEY,
BedType varchar(20) DEFAULT 'Ward',
Occupied varchar(20),
WardName varchar(20),

);
GO

CREATE TABLE Doctors
(
DoctorID varchar(20)NOT NULL PRIMARY KEY,
FirstName varchar (20),
LastName varchar(20),
Specialty varchar(20),

);
GO

CREATE TABLE Extras
(
PatientID varchar(20),
AdmissionRoom varchar(20),
TV varchar(20),
Phone varchar(20),
Semi_Private varchar(20),
Private_Room varchar(20),

);
GO

CREATE TABLE Extras_Rates
(
AmenityCode varchar(20) NOT NULL PRIMARY KEY,
AmenityName varchar(20),
DailyCost varchar(20),
);
GO

CREATE TABLE Patients
(
HealthNumber varchar(20) NOT NULL PRIMARY KEY,
DateOfBirth date,
LastName varchar(20),
FirstName varchar(20),
AddressPatient varchar(20),
City varchar(20),
Province varchar(2),
PostalCode varchar(20),
Phone varchar(20),
InsuranceCompany varchar(20),
InsuranceNumber varchar(20),
NextofKin varchar(20),
NextofKinRelationship varchar(20),
Doctor varchar(20),
);
GO

CREATE TABLE AdmissionRecords
(
AdmissionID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
PatientID varchar(20),
BedNumber varchar(20),
SurgerySceduled varchar(20),
AdminDate date DEFAULT getdate(),
SurgeryDate date,
DischargedDate date,
);
GO

CREATE TABLE Specialties
(
SpecialtyCode INT IDENTITY (1,1) NOT NULL,
SpecialtyName varchar(20) NOT NULL PRIMARY KEY,
);
GO

CREATE TABLE Ward
(
WardCode INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
WardName VARCHAR(20),
);
GO

CREATE TABLE Users
(
Id INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
Username nvarchar(50),
Passwrd nvarchar(50),
);
GO

INSERT INTO Users values ('paul',12345);
INSERT INTO Users values ('suzie',12345);
INSERT INTO Users values ('jack',12345);
GO

ALTER TABLE AdmissionRecords
ADD FOREIGN KEY (PatientID)
REFERENCES Patients(HealthNumber);


ALTER TABLE AdmissionRecords
ADD FOREIGN KEY (BedNumber)
REFERENCES Beds(BedNumber);

ALTER TABLE Patients
ADD FOREIGN KEY (Doctor)
REFERENCES Doctors(DoctorID);

--ALTER TABLE Patients
--ADD FOREIGN KEY (Bed)
--REFERENCES Beds(BedNumber);

ALTER TABLE Doctors
ADD FOREIGN KEY ([Specialty])
REFERENCES [dbo].[Specialties]([SpecialtyName]);

GO


--SELECT BedNumber FROM dbo.Beds WHERE Occupied = 0;


create trigger trSetBedToAvailable ON AdmissionRecords
FOR update
AS
BEGIN
IF UPDATE(DischargedDate)
DECLARE @BedNumb  VARCHAR(36)
SELECT @BedNumb = BedNumber FROM INSERTED 
UPDATE Beds SET Occupied = 0 WHERE BedNumber = @BedNumb
END
GO



