Turkce = ["Masa", "Sandalye", "Bıçak", "Kaşık", "Çatal", "Kitap", "Bardak", "Sözlük", "Klavye", "Ekran", "Bilgisayar", "Otobüs Durağı", "Kalem", "Tükenmez Kalem", "Kalemlik"]
Ingilizce = ["Table", "Chair", "Knife", "Spoon", "Fork", "Book", "Glass", "Dictionary", "Keyboard", "Screen", "Computer", "Bus Stop", "Pencil", "Pen", "Pencilcase"]

RenklerIngilizce = ["Red", "Blue", "Green", "Gray", "Black", "Yellow", "White", "Orange"]
RenklerTurkce = ["Kırmızı", "Mavi", "Yeşil", "Gri", "Siyah", "Sarı", "Beyaz", "Turuncu"]

def IngilizcedenTurkce(IngilizceKelime):
    i = 0
    k = 0
    while i < len(Turkce):
        if IngilizceKelime == Ingilizce[i]:
            print(IngilizceKelime + " = " + Turkce[i])
        else:
            k += 1
        i += 1
        if k >= len(Turkce):
            print("Bu Kelimenin Türkçe Karşılığı Bulunamadı")

def TurkcedenIngilizce(TurkceKelime):
    i = 0
    k = 0
    while i < len(Turkce):
        if TurkceKelime == Turkce[i]:
            print(TurkceKelime + " = " + Ingilizce[i])
        else:
            k += 1
        i += 1
        if k >= len(Turkce):
            print("Bu Kelimenin İngilizce Karşılığı Bulunamadı")

def Renkler():
    i = 0
    for RenklerIn in RenklerIngilizce:
        print(RenklerIn + " = " + RenklerTurkce[i])
        i += 1