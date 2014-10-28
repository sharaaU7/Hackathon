CREATE TABLE CreditCard
(
Id INT IDENTITY PRIMARY KEY
, Name Varchar(255)
, Vendor Varchar(50)
, CVV Varchar(5)
, Address1 Varchar(3000)
, ZipCode Varchar(8)
, FirstName Varchar(255)
, LastName Varchar(255)
, Expiration DateTime
, CreditCardNumber Varchar(255)
, PaypalId Varchar(50)
, UserId VARCHAR(50)
)