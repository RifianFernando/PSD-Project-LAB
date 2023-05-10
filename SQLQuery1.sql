create table TransactionHeader(
TransactionID INT PRIMARY KEY IDENTITY(2000000, 1) NOT NULL,
TransactionDate date NOT NULL,
CustomerID INT NOT NULL,

FOREIGN KEY (CustomerID) REFERENCES Customer (CustomerID) ON UPDATE CASCADE ON DELETE CASCADE
)