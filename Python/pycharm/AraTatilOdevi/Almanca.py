Turkce = ["Gelmek", "Günaydın", "İkamet Etmek", "Yaşamak", "Cetvel"]
Almanca = ["Kommen", "Guten Tag", "Wohnen", "Leben", "Lineal"]
AlmancaArtikel = ["Artikeli Yok", "Artikeli Yok",  "Artikeli Yok", "Artikeli Yok", "das"]

RenklerAlmanca = ["Rot", "Blau", "Grün", "Grau", "Schwarz", "Gelb", "Weiß", "Orange"]
RenklerTurkce = ["Kırmızı", "Mavi", "Yeşil", "Gri", "Siyah", "Sarı", "Beyaz", "Turuncu"]

AlmancaDersler = ["Englisch", "Deutsch", "Chemie", "Physik", "Sport", "Kumst", "Musik", "Religion", "Mathematik", "Biologie", "Erdkunde", "Geschichte"]
TurkceDersler = ["İngilizce", "Almanca", "Kimya", "Fizik", "Beden Eğitimi", "Görsel Sanatlar", "Müzik", "Din Kültürü ve Ahlak Bilgisi", "Matematik", "Biyoloji", "Coğrafya", "Tarih"]

def AlmancadanTurkce(AlmancaKelime):
    i = 0
    k = 0
    while i < len(Turkce):
        if AlmancaKelime == Almanca[i]:
            print(AlmancaKelime + " = " + Turkce[i])
        else:
            k += 1
        i += 1
        if k >= len(Turkce):
            print("Bu Kelimenin Almanca Karşılığı Bulunamadı")

def TurkcedenAlmanca(TukceKelime):
    i = 0
    k = 0
    while i < len(Almanca):
        if TukceKelime == Turkce[i]:
            print(TukceKelime + " = " + Almanca[i])
        else:
            k += 1
        i += 1
        if k >= len(Almanca):
            print("Bu Kelimenin Türkçe Karşılığı Bulunamadı")

def AlmancaArtikelAra(AlmancaKelime):
    i = 0
    k = 0
    while i < len(Almanca):
        if AlmancaKelime == Almanca[i]:
            if AlmancaArtikel[i] == "Artikeli Yok, Fiil":
                print(AlmancaKelime + " = Artikeli Bulunmamaktadır")
            else:
                print(AlmancaKelime + ": Artikeli = " + AlmancaArtikel[i])
        else:
            k += 1
        i += 1
        if k >= len(Almanca):
            print("Girdiğiniz Almanca Kelime Sözlüğümüzde Bulunmamaktadır")

def Renkler():
    i = 0
    for RenklerAl in RenklerAlmanca:
        print(RenklerAl + " = " + RenklerTurkce[i])
        i += 1

def DerslerOyun():
    i = 0
    Puan = 100
    y = 0
    while i < len(AlmancaDersler):
        secenekend = False
        if Puan > 0:
            print("Puanın = " + str(Puan))
            print(str((i + 1)) + ") " + AlmancaDersler[i])
            while secenekend == False:
                if Puan <= 0:
                    print("Puanın = " + str(Puan))
                    print("Oyunu Kaybettin")
                    secenekend = True
                else:
                    Cevap = input("Bu Kelimenin Türkçe Karşılığını Giriniz")
                    if Cevap == TurkceDersler[i]:
                        print("Doğru Cevap Helal Sana")
                        secenekend = True
                    else:
                        print("Yanlışşş Tekrar Dene")
                        Puan -= 10
                        y += 1
                        secenekend = False
        else:
            i = len(AlmancaDersler)
        i += 1
    if i >= len(AlmancaDersler) and Puan > 0:
        if Puan != 100:
            print("Puanın = " + str(Puan))
            print(str(y) + " Tane Yanlış Cevap Verdin")
        else:
            print("Puanın = " + str(Puan))
            print("Hiç Yanlış Cevap Vermedin")
    print("Oyun Bitti. Daha Sonra Görüşürüz")