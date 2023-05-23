create table Customer(
	CustomerID INT PRIMARY KEY IDENTITY(1000000, 1) NOT NULL,
	CustomerName varchar(50) NOT NULL,
	CustomerEmail varchar(50) NOT NULL,
	CustomerPassword varchar(50) NOT NULL,
	CustomerGender varchar(6) NOT NULL,
	CustomerAddress varchar(100) NOT NULL,
	CustomerRole varchar (5) NOT NULL
)

create table TransactionHeader(
	TransactionID INT PRIMARY KEY IDENTITY(2000000, 1) NOT NULL,
	TransactionDate date NOT NULL,
	CustomerID INT NOT NULL,
	FOREIGN KEY (CustomerID) REFERENCES Customer (CustomerID) ON UPDATE CASCADE ON DELETE CASCADE
)
CREATE TABLE Artist (
	ArtistID INT PRIMARY KEY IDENTITY(5000000, 1) NOT NULL,
	ArtistName VARCHAR(50) NOT NULL,
	ArtistImage VARCHAR(50) NOT NULL
)


CREATE TABLE Album(
	AlbumID INT PRIMARY KEY IDENTITY(6000000, 1) NOT NULL,
	ArtistID INT NOT NULL,
	AlbumName VARCHAR(50) NOT NULL,
	AlbumImage VARCHAR(50) NOT NULL,
	AlbumPrice INT NOT NULL,
	AlbumStock INT NOT NULL,
	AlbumDescription VARCHAR(255) NOT NULL,
	FOREIGN KEY (ArtistID) REFERENCES Artist (ArtistID) ON UPDATE CASCADE ON DELETE CASCADE
) 

CREATE TABLE Cart(
	CustomerID INT NOT NULL,
	AlbumID INT NOT NULL,
	Qty INT NOT NULL,
	FOREIGN KEY (CustomerID) REFERENCES Customer (CustomerID) ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY (AlbumID) REFERENCES Album (AlbumID) ON UPDATE CASCADE ON DELETE CASCADE
)

CREATE TABLE TransactionDetail(
    TransactionID INT NOT NULL,
    AlbumID INT NOT NULL,
    Qty INT NOT NULL,
    FOREIGN KEY(TransactionID) REFERENCES TransactionHeader(TransactionID) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY(AlbumID) REFERENCES Album(AlbumID) ON UPDATE CASCADE ON DELETE CASCADE
)

-- INSERT CUSTOMER USER
INSERT INTO Customer VALUES ('Rifian', 'RifianAdmin@gmail.com', 'lipi123', 'Male', 'Kanting Lorong Street', 'Admin');
INSERT INTO Customer VALUES ('Glennix', 'GlennixAdmin@gmail.com', 'GG123', 'Male', 'Green Garden Street', 'Admin');
INSERT INTO Customer VALUES ('Dixon', 'Dixon@gmail.com', 'krastelaM', 'Male', 'PerbatasanTangsel Street', 'CST');

-- INSERT Album Detail By Artist
insert into Album values (/* INI USER ID SESUAIN SAMA TABLE, */ 'Rifian Bergadang', '638058597622333864.jfif','100000','10','lorem ipsum rifian ipsum lorem ipsum rifian dolor')

-- INSERT Transaction History By UserID
INSERT INTO TransactionHeader VALUES(
	Now()
	/* INI USER ID SESUAIN SAMA TABLE, */
);
