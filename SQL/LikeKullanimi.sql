-- LIKE

-- �smi ��erisinde "ka" Olan Kitaplar
SELECT * FROM Books WHERE BookName LIKE '%ka%'

-- "a" �le Ba�layan Kitaplar
SELECT ID, BookName, Barkod FROM Books WHERE BookName LIKE 'a%'

-- �smi ��erisinde "fr" Olan Yazarlar
SELECT * FROM Authors WHERE AuthorName LIKE '%fr%'

-- �smi ��erisinde % Karakteri Olan Kitaplar
SELECT * FROM Books WHERE BookName LIKE '%/%%' ESCAPE '/'
-- / ��aretinden Sonraki Karakterin �zel Karakter Olma Durumunu G�rmezden Gel