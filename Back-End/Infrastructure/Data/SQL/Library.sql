-->------- Config Database -------<--

CREATE DATABASE Library;
GO
USE Library;
GO


-->------- Create tables -------<--

CREATE TABLE Books
(
    Id INT PRIMARY KEY ,
    Title NVARCHAR(100) ,
    AutherID INT , 
    PublishDate DATETIME , 
    PublisherId INT , 
    Price DECIMAL , 
    [Edition] FLOAT , 
    TopicId INT , 
    IsActive BOOLEAN
)


CREATE TABLE Members
(
    Id INT PRIMARY KEY ,
    FullName NVARCHAR(40) ,
    BirthDate DATETIME
)


CREATE TABLE Authers
(
    Id INT PRIMARY KEY ,
    FullName NVARCHAR(40)
)



CREATE TABLE Publishers
(
    Id INT PRIMARY KEY ,
    [Name] NVARCHAR(30) 
)



CREATE TABLE Lends
(
    Id INT PRIMARY KEY ,
    OwnerId INT ,
    StartDate DATETIME ,
    EndDate DATETIME ,
    IsActive BOOLEAN ,
    FOREIGN KEY (OwnerId) REFERENCES Members(Id)
)


CREATE TABLE BookLend
(
    Id INT PRIMARY KEY , 
    LendId INT ,
    BookId INT,
    FOREIGN KEY (LendId) REFERENCES Lend(Id),
    FOREIGN KEY (BookId) REFERENCES Books(Id)
)






-->------- Book Section -------<--

CREATE PROCEDURE GetBook
(
    @bookId INT 
)
AS
BEGIN 
    SELECT * FROM Books WHERE Id = bookId;
END


CREATE PROCEDURE GetALlBooks
AS
BEGIN
    SELECT * FROM Books
END


CREATE PROCEDURE FindBooksByAuther
(
    @autherId INT
)
AS
BEGIN
    SELECT * FROM Books WHERE AutherID = autherId;
END


CREATE PROCEDURE FindBooksByTopic
(
    @topicId INT
)
AS 
BEGIN 
    SELECT * FROM Books WHERE TopicId = topicId;
END



CREATE PROCEDURE FindBooksByPublisher
(
    @publisherId INT
)
AS 
BEGIN 
    SELECT * FROM Books WHERE PublisherId = publisherId;
END



CREATE PROCEDURE AddBook
(
    @title NVARCHAR(100)
    @autherId INT
    @publishDate DATETIME 
    @publisherId INT 
    @price DECIMAL
    @edition FLOAT 
    @topicId INT
)
AS
BEGIN
    INSERT INTO Books VALUES (@title,@autherId,@publishDate,@publisherId,@price,@edition,@topicId);
END



CREATE PROCEDURE DeleteBook
(
    @bookId INT
)
AS
BEGIN
    DELETE FROM Books WHERE Id = bookId;
END



CREATE PROCEDURE DeactiveBook
(
    @bookId INT
)
AS
BEGIN 
    UPDATE Books SET IsActive = FALSE WHERE Id = bookId;
END


CREATE PROCEDURE ActiveBook
(
    @bookId INT
)
AS 
BEGIN 
    UPDATE Books SET IsActive = TRUE WHERE Id = bookId;
END


CREATE PROCEDURE UpdateBook
(
    @bookId INT
    @title NVARCHAR(100)
    @autherId INT
    @publishDate DATETIME
    @publisherId INT
    @price DECIMAL
    @Edition FLOAT
    @topicId INT
)
AS
BEGIN
    UPDATE Books SET Title = title , AutherID = autherId , PublishDate = publishDate,
    PublisherId = publisherId , Price = price , [Edition] = [edition] , TopicId = topicId 
    WHERE Id = bookId;
END




-->------- Member Section -------<--

CREATE PROCEDURE Register
(
    @fullName NVARCHAR(30)
    @birthDate DATETIME
)
AS 
BEGIN 
    INSERT INTO Members VALUES(fullName,birthDate);
END


CREATE PROCEDURE FindMember
(
    @id INT
)
AS 
BEGIN
    SELECT * FROM Members WHERE Id = id;
END


CREATE PROCEDURE DeleteMember
(
    @id INT
)
AS 
BEGIN
    DELETE FROM Members WHERE Id = id;
END


CREATE PROCEDURE UpdateMember
(
    @id INT
    @fullName NVARCHAR(40)
    @birthDate DATETIME
)
AS 
BEGIN
    UPDATE Members SET FullName = fullName , BirthDate = birthDate WHERE Id = id;
END


-->------- Lend Section -------<--


CREATE PROCEDURE CreateLend
(
    @ownerId INT,
    @startDate DATETIME,
    @endDate DATETIME,
    @isActive BOOLEAN
)
AS
BEGIN
    INSERT INTO Lends VALUES (OwnerId=ownerId,StartDate=startDate,EndDate=EndDate,IsActive=isActive);
END


CREATE PROCEDURE CreateLendBooks
(
    @bookId INT,
    @lendId INT
)
AS 
BEGIN
    INSERT INTO BookLend VALUES (BookId=bookId,LendId=lendId);
END


