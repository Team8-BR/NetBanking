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
--drop table NetBankingCredentials
Create table ModeOfTransaction
(	
ModeID int primary key not null,
Modes	int not null,
MaturityInstruction varchar
)
create table TransactionDetails
(	
TransactionReferenceID	varchar(20) not null,
AccountNumber varchar(20) primary key not null,
RecipientAccountNumber varchar(20) not null,
Name varchar(50) not null,
Nickname varchar(50),
Transactionamount	money,
TransactionDate	datetime,
ModeID int not null,
Remark	varchar(120)
)
alter table NetBankingCredentials add constraint fkey_Net_Accno foreign key(AccountNumber) references  TransactionDetails(AccountNumber)
alter table NetBankingCredentials add AccountNumber	varchar(20) not null	

Create table AdminDetails
(
AdminID int primary key,
AdminPassword varchar(10)
)*/

create proc TransactionHistory
@TransactionReferenceID varchar(20),
@AccountNumber varchar(20),
@RecipientAccountNumber varchar(20),
@Name varchar(50),
@Transactionamount	money,
@TransactionDate	datetime,
@ModeID int,
@Remark	varchar(120)
as
begin
select TransactionReferenceID,AccountNumber,RecipientAccountNumber,Name,Transactionamount,TransactionDate,ModeID,Remark from
TransactionDetails where AccountNumber=@AccountNumber
end
create proc InternetBanking
@UserID int,
@NetbankingPassword int,
@TransactionPassword int,
@AccountNumber varchar
as
begin
select UserID,NetbankingPassword,TransactionPassword,AccountNumber from NetBankingCredentials 
where AccountNumber=@AccountNumber
end
create proc AccountDetails
@AccountNumber varchar,
@Title	varchar(5),
@FirstName	varchar(20),
@LastName	varchar(20),
@Mobileno	varchar(20),
@emailID	varchar(40),
@DOB date,
@PermanentAddressLine1	varchar(120),
@PermanentAddressLine2	varchar(120),
@PermanentLandmark	varchar(120),
@PermanentState	varchar(120),
@PermanentCity	varchar(120),
@PermanentPincode	varchar(120)
as
begin
select Title,FirstName,LastName,Mobileno,emailID,DOB,PermanentAddressLine1,PermanentAddressLine2,PermanentLandmark,PermanentState,
PermanentCity,PermanentPincode from AccountFields where AccountNumber = @AccountNumber
end