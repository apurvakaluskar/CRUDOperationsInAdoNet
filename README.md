This application uses a Windows Form in .Net 5.0 for performing CRUD operations in a Movies Database.

The SQL commands to create the database are as mentioned below:

CREATE TABLE Movie (
	Id INT NOT NULL IDENTITY,
	Name NVARCHAR(100) NULL,
	ReleaseYear INT NULL,
	Genre NVARCHAR(50) NULL,
	Rating NUMERIC(2,1) NULL
);

-- Create
INSERT INTO Movie VALUES ('Zindagi Na Milegi Dobara', 2011, 'Drama', 8.2);
INSERT INTO Movie VALUES ('Band Baaja Baarat', 2010, 'Comedy', 7.2);
INSERT INTO Movie VALUES ('3 Idiots', 2009, 'Comedy', 8.4);
INSERT INTO Movie VALUES ('Harry Potter and the Deathly Hallows: Part 1', 2010, 'Adventure', 7.7);
INSERT INTO Movie VALUES ('Harry Potter and the Deathly Hallows: Part 2', 2011, 'Adventure', 8.1);
INSERT INTO Movie VALUES ('Cast Away', 2000, 'Adventure', 7.8);
INSERT INTO Movie VALUES ('The Pursuit of Happyness', 2006, 'Drama', 8.1);
INSERT INTO Movie VALUES ('The Karate Kid', 2010, 'Drama', 7.3);
INSERT INTO Movie VALUES ('Ae Dil Hai Mushkil', 2016, 'Romance', 5.8);
INSERT INTO Movie VALUES ('Bajirao Mastani', 2015, 'Periodic Drama', 7.2);

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
