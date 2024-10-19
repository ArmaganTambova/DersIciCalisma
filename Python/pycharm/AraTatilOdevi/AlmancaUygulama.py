import Almanca as Sozluk

secenekend = False
while secenekend == False:
    print("1) Almancadan Türkçeye")
    print("2) Türkçeden Almancaya")
    print("3) Almanca Artikel Ara")
    print("4) Renkler")
    print("5) Derslerle Alakalı Oyun")
    print("6) Çıkış Yap")
    secim = input("Lütfen Seçim Yapınız")
    if secim == "1":
        Soz = input("Lütfen Türkçe Karşılığını Öğrenmek İstediğiniz Almanca Kelimeyi Giriniz")
        Sozluk.AlmancadanTurkce(Soz)
        secenekend = False
    elif secim == "2":
        Soz = input("Lütfen Almanca Karşılığını Öğrenmek İstediğiniz Türkçe Kelimeyi Giriniz")
        Sozluk.TurkcedenAlmanca(Soz)
        secenekend = False
    elif secim == "3":
        Soz = input("Lütfen Artikelini Aratmak İstediğiniz Almanca Kelimeyi Giriniz")
        Sozluk.AlmancaArtikelAra(Soz)
        secenekend = False
    elif secim == "4":
        Sozluk.Renkler()
        secenekend = False
    elif secim == "5":
        Sozluk.DerslerOyun()
        secenekend = False
    elif secim == "6":
        secenekend = True
    else:
        print("Geçerli Bir Seçenek Girmediniz")
        secenekend = True
print("Görüşürüz")