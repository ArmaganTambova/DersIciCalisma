import Matematik as Mat
Baglaclar = ["ve", "ya da", "veya", "ise", "ancak ve ancak"]

secenekend = False
while secenekend == False:
    print("1) Mantık")
    print("2) Kesişim Kümesi Bulma")
    print("6) Çıkış Yap")
    secim = input("Lütfen Seçim Yapınız")
    if secim == "1":
        i = 0
        Sayi1 = int(input("Lütfen Birinci Sayıyı Giriniz"))
        Sayi2 = int(input("Lütfen İkinci Sayıyı Giriniz"))
        if Sayi1 != 1 or Sayi1 != 0:
            print("Lütfen Sadece 1 ve 0 Sayılarını Kullanınız")
        elif Sayi2 != 1 or Sayi2 != 0:
            print("Lütfen Sadece 1 ve 0 Sayılarını Kullanınız")
        else:
            for Baglac in Baglaclar:
                print(str((i + 1)) + ") " + Baglac)
                i += 1
            secimB = int(input("Lütfen Bağlacı Seçiniz"))
            BaglacB = Baglaclar[(secimB - 1)]
            Mat.Mantik(Sayi1, BaglacB, Sayi2)
    elif secim == "2":
        Mat.KesisimKumesiBulma()
    elif secim == "6":
        secenekend = True
    else:
        print("Geçerli Bir Seçenek Girmediniz")
        secenekend = True
    print("Görüşürüz")