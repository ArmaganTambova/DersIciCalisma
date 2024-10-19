-- LIKE

-- Ýsmi Ýçerisinde "ka" Olan Kitaplar
SELECT * FROM Books WHERE BookName LIKE '%ka%'

-- "a" Ýle Baþlayan Kitaplar
SELECT ID, BookName, Barkod FROM Books WHERE BookName LIKE 'a%'

-- Ýsmi Ýçerisinde "fr" Olan Yazarlar
SELECT * FROM Authors WHERE AuthorName LIKE '%fr%'

-- Ýsmi Ýçerisinde % Karakteri Olan Kitaplar
SELECT * FROM Books WHERE BookName LIKE '%/%%' ESCAPE '/'
-- / Ýþaretinden Sonraki Karakterin Özel Karakter Olma Durumunu Görmezden Gel