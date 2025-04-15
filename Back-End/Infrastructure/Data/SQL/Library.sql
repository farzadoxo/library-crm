-- Config

CREATE DATABASE Library;

USE Library;
GO


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


CREATE TABLE Auther
(
    Id INT PRIMARY KEY ,
    FullName NVARCHAR(40)
)



CREATE TABLE Publisher
(
    Id INT PRIMARY KEY ,
    [Name] NVARCHAR(30) 
)



CREATE TABLE Lend
(
    Id INT PRIMARY KEY ,
    OwnerId INT ,
    StartDate DATETIME ,
    EndDate DATETIME ,
    IsActive BOOLEAN ,
)


CREATE TABLE BookLend
(
    Id INT PRIMARY KEY , 
    LenId INT ,
    BookId INT
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