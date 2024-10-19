USE Kutuphane

-- Kutuphane Veritaban�ndaki Kitaplar� Ve Yazarlar�n� Listeleyiniz
SELECT B.BookName, A.AuthorName, A.AuthorSurname FROM BooksAndAuthors AS BA JOIN Books AS B ON BA.BookID = B.ID JOIN Authors AS A ON BA.AuthorID = A.ID

-- Kitaplar�n T�r Ad� ve Yay�n Evi Ad� Bilgilieriyle Yazd�r�n�z
SELECT B.ID, B.Barkod, B.BookNumber AS [Book Number], B.BookName AS [Book Name], PH.PublishingHouseName AS [Publishing House], G.GenreName AS [Genre], L.BookLanguage AS [Language] FROM Books AS B JOIN Genres AS G ON B.GenreID = G.ID JOIN PublishingHouses AS PH ON B.PublishingHouseID = PH.ID JOIN Languages AS L ON B.LanguageID = L.ID
