Turkce = ["Masa" , "Sandalye" , "Bıçak" , "Kaşık" , "Çatal" , "Kitap" , "Bardak" , "Sözlük" , "Klavye" , "Ekran" , "Bilgisayar" , "Otobüs Durağı" , "Kalem" , "Tükenmez Kalem" , "Kalemlik"]
Ingilizce = ["Table" , "Chair" , "Knife" , "Spoon" , "Fork" , "Book" , "Glass" , "Dictionary" , "Keyboard" , "Screen" , "Computer" , "Bus Stop" , "Pencil" , "Pen" , "Pencilcase"]

def ara(turkce):
    sayac = 0
    kontrol = 0
    while sayac < len(Turkce):
        if turkce == Turkce[sayac]:
            print(turkce + " = " + Ingilizce[sayac])
        else:
            kontrol += 1
        sayac += 1
        if kontrol >= len(Turkce):
            print("Arattığınız Türkçe Kelime Sözlükte Bulunamadı")