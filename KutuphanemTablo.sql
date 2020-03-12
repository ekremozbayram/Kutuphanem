CREATE TABLE YayineviTBL (Id INT, Ad NVARCHAR(100) PRIMARY KEY (Id))

CREATE TABLE KitapTBL (Barkod INT, Ad NVARCHAR(100), Yazar NVARCHAR(100), BasimYili INT, Yayinevi INT 
	PRIMARY KEY(Barkod) FOREIGN KEY (Yayinevi) REFERENCES YayineviTBL(Id))