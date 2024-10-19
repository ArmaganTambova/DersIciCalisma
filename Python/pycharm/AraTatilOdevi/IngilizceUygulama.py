import Ingilizce as Sozluk

secenekend = False
while secenekend == False:
    print("1) İngilizceden Türkçeye")
    print("2) Türkçeden İngilizceye")
    print("3) Renkler")
    print("4) Derslerle Alakalı Oyun")
    print("5) Çıkış Yap")
    secim = input("Lütfen Seçim Yapınız")
    if secim == "1":
        Soz = input("Lütfen Türkçe Karşılığını Öğrenmek İstediğiniz Almanca Kelimeyi Giriniz")
        Sozluk.IngilizcedenTurkce(Soz)
        secenekend = False
    elif secim == "2":
        Soz = input("Lütfen Almanca Karşılığını Öğrenmek İstediğiniz Türkçe Kelimeyi Giriniz")
        Sozluk.TurkcedenIngilizce(Soz)
        secenekend = False
    else:
        print("Geçerli Bir Seçenek Girmediniz")
        secenekend = True
print("Görüşürüz")