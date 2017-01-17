create database BankServices;

use BankServices;

create table TYPE_SERVICE
(
	iIdTypeService int identity (1,1) not null primary key,
	vName varchar(255) not null,
	vDescription varchar(255) not null
)

create table DEPARTMENT
(
	iIdDepartment int identity (1,1) not null primary key,
	vName varchar(100) not null unique,
	iApartment int not null
)

create table DOCUMENTS
(
	iIdDocuments int identity (1,1) not null primary key,
	vName varchar(100) not null unique
)

create table WORKER
(
	iIdWorker int identity (1,1) not null primary key,
	vSecondName varchar(100) not null,
	vFirstName varchar(100) not null,
	vThirdName varchar(100),
	iRank int not null,
	fExperience float,
	fk_iIdDep int not null,
	FOREIGN KEY (fk_iIdDep) REFERENCES 
	DEPARTMENT(iIdDepartment) ON DELETE CASCADE ON UPDATE CASCADE
)

create table SERVICE
(
	iIdService int identity (1,1) not null primary key,
	fk_iIdTypeService int not null,
	fk_iIdDoc int not null,
	fk_iIdWorker int not null,
	iPrice int not null,
	vName varchar(255) not null,
	FOREIGN KEY (fk_iIdTypeService) REFERENCES 
	TYPE_SERVICE(iIdTypeService) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (fk_iIdDoc) REFERENCES 
	DOCUMENTS(iIdDocuments) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (fk_iIdWorker) REFERENCES 
	WORKER(iIdWorker) ON DELETE CASCADE ON UPDATE CASCADE
)

create table CLIENT
(
	iIdClient int identity (1,1) not null primary key,
	vStatus varchar(50) not null,
	vAdress varchar(255) not null,
	vNameOrg varchar(255) null,
	vSecondName varchar(100) null,
	vFirstName varchar(100) null,
	vThirdName varchar(100) null,
	vDateOfIssue varchar(100) null,
	vDateBirth varchar(100) null,
	vIssuedBy varchar(100) null,
	vBatch varchar(2) null,
	iNumber int null,
	vDetails varchar(255) not null, 
	vBankDetails varchar(255) not null,
	vPhoneNumber varchar(10)
)

create table OPERATION
(
	iIdOperation int identity (1,1) not null primary key,
	fk_iIdClient int not null,
	fk_iIdService int not null,	
	vDate varchar(100) not null,
	FOREIGN KEY (fk_iIdClient) REFERENCES 
	CLIENT(iIdClient) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (fk_iIdService) REFERENCES 
	SERVICE(iIdService) ON DELETE CASCADE ON UPDATE CASCADE
)

create table LOGON
(
	iIdLogon int identity(1,1) not null primary key,
	vLogin varchar(100) not null unique,
	vPassword varchar(100) not null unique,
	iType int not null
)