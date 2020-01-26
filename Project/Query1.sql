CREATE TABLE UserAccountDetails
(
   ID VARCHAR(20) PRIMARY KEY,
   MailID VARCHAR(25) UNIQUE,
   Password VARCHAR(15) NOT NULL,
   FirstName VARCHAR(20) NOT NULL, 
   SecondName VARCHAR(20) NOT NULL, 
   MobileNumber BIGINT NOT NULL,
   DateOfBirth DATE NOT NULL,
   Gender VARCHAR(10) NOT NULL,
   Role VARCHAR(10) NOT NULL
)

