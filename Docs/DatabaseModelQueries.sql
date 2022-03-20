--create database Banking
/*
create table AccountFields(
ReferenceID int identity(1,1) not null,
Title	varchar(5) not null,
FirstName	varchar(20) not null,
LastName	varchar(20) not null,
Mobileno	varchar(20) not null,
MiddleName	varchar(20) ,
emailID	varchar(40) not null,
AadhaarCardNumber varchar(20) not null,
DOB	date not null,
ResidentialAddressLine1	varchar(120),
ResidentialAddressLine2	varchar(120),
ResidentialLandmark	varchar(120),
ResidentialState	varchar(120) not null,
ResidentialCity	varchar(120) not null,
ResidentialPincode	varchar(120) not null,
PermanentAddressLine1	varchar(120),
PermanentAddressLine2	varchar(120),
PermanentLandmark	varchar(120),
PermanentState	varchar(120) not null,
PermanentCity	varchar(120) not null,
PermanentPincode	varchar(120) not null,
Occupationdetails	varchar(120),
OccupationType	varchar(120) ,
Sourceofincome	money ,
GrossAnnualIncome	int ,
)
Create Table NetBankingCredentials
( 	
UserID int primary key not null,
NetBankingPassword	varchar(20) not null,
TransactionPassword	varchar(20) not null
)
create table DebitCardCredentials
(
DebitCardNumber int primary key not null,
DebitCardExpiry date not null ,
DebitCardCVV int not null
)
create table CreditCardCredentials
(
CreditCardNumber int primary key not null,
CreditCardExpiry date not null,
CreditCardCVV int not null
)
--drop table TransactionDetails
Create table ModeOfTransaction
(	
ModeID int primary key not null,
Modes	int not null,
MaturityInstruction varchar
)
create table TransactionDetails
(	
TransactionReferenceID 	varchar(20) primary key not null,
AccountNumber varchar(20)  not null,
RecipientAccountNumber varchar(20) not null,
Name varchar(50) not null,
Nickname varchar(50),
Transactionamount	money,
TransactionDate	datetime,
ModeID int not null,
Remark	varchar(120)
)
alter table AccountFields add constraint fkey_Accno foreign key(AccountNumber) references  TransactionDetails(AccountNumber)
alter table AccountFields add constraint fkey_CreditcardAccDetails foreign key(CreditcardNumber) references  CreditcardCredentials(CreditcardNumber)
alter table AccountFields add constraint fkey_DebitcardAccDetails foreign key(DebitcardNumber) references  DebitcardCredentials(DebitcardNumber)
alter table AccountFields add constraint fkey_UserID foreign key(UserID) references  NetBankingCredentials(UserID)
alter table NetBankingCredentials add constraint fkey_Net_Accno foreign key(AccountNumber) references  AccountFields(AccountNumber)
alter table TransactionDetails add constraint fkey_modeID foreign key(ModeID) references  ModeOfTransaction(ModeID)
alter table TransactionDetails add TransactionReferenceID varchar(20) Primary key not null	
alter table AccountFields add AccountNumber varchar(20) primary key not null	
alter table AccountFields add Status varchar(20) not null	
alter table AccountFields add AccountBalance decimal(18,2) not null

Create table AdminDetails
(
AdminID int primary key,
AdminPassword varchar(10)
)*/
create table PayeeDetails(
PayeeID int primary key identity(600100,1),
PayeeName varchar(30),
PayeeAccountNumber bigint,
NickName varchar(30),
CustomerID int
)
 alter table PayeeDetails add constraint fkey_CusID foreign key(CustomerID) references AccountFields(CustomerID)
 alter table TransactionDetails add constraint fkey_PayID foreign key(PayeeID) references PayeeDetails(PayeeID)
 alter table TransactionDetails add PayeeID int