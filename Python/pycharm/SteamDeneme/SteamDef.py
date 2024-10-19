KullaniciAdlari = ["Poyraz26", "Cemre", "ArmaganT", "ZümraKoparan", "NisaNUR"]
Parolalar = ["PyrzSlh2008", "cemre0910", "armagan1864", "Zümraa0804", "NisaaNr"]
Bakiyeler = [250, 850, 275, 350, 250]

AdminKullaniciAdlari = ["ArmaganTAMBOVA", "PoyrazSALİH", "CemreNAZ"]
AdminParolalar = ["ArmaganTambova1864", "PyrzSLH2008", "CEMRE0910"]

Kutuphaneler = ["God Of War", "Valorant"]
KutKullaniciAdlari = ["ArmaganT", "Cemre"]

Oyunlar = ["The Last Of Us ", "God Of War", "Valorant", "Dying Light", "Uncharted", "Resident Evil", "Call Of Duty", "Fortnite", "A Way Out", "Tomb Raider", "Grand Theft Auto", "Devour", "Among Us", "Outlast", "Crysis"]
Fiyatlar = [599, 197, 40, 32, 590, 349, 30, 471, 99, 34, 99, 125, 39, 50, 75]

def Kaydol():
    secenekend = "Q"
    while secenekend != "q":
        i = 0
        k = 0
        YeniKullaniciA = input("Lütfen Kullanıcı Adınızı Belirleyiniz")
        YeniParola = input("Lütfen Kullanıcı Adınızı Belirleyiniz")
        while i < len(KullaniciAdlari):
            if KullaniciAdlari[i] == YeniKullaniciA:
                print("Bu Kullanıcı Adı Daha Önceden Alınmış")
                secenekd = input("Tekrar Denemek İster Misiniz? e/h")
                if secenekd == "e":
                    secenekend = "Q"
                elif secenekd == "h":
                    secenekend = "q"
                else:
                    print("Önceki Menüye Gönderiliyorsunuz")
                    secenekend = "q"
            else:
                k += 1
            i += 1
        if k >= len(KullaniciAdlari):
            KayitB = 0
            KullaniciAdlari.append(YeniKullaniciA)
            Parolalar.append(YeniParola)
            Bakiyeler.append(KayitB)
            print("Kayıt İşlemi Tamamlanmıştır")
            secenekend = "q"

def Kutuphane(KullaniciAdi):
    i = 0
    k = 0
    while i < len(Kutuphaneler):
        if KullaniciAdi == KutKullaniciAdlari[i]:
            print(Kutuphaneler[i])
        else:
            k += 1
        i += 1
    if k >= len(Kutuphaneler):
        print("Kütüphanenizde Oyun Bulunmamaktadır")

def ParaEkle(KullaniciAdi):
    secenekend = "Q"
    KullaniciAdi = KullaniciAdlari.index(KullaniciAdi)
    while secenekend != "q":
        YeniB = int(input("Lütfen Cüzdanınıza Eklemek İstediğiniz Bakiyeyi Giriniz"))
        if YeniB <= 0:
            print("Geçerli Bir Miktar Girmediniz")
            secenekd = input("Tekrar Denemek İster Misiniz? e/h")
            if secenekd == "e":
                secenekend = "Q"
            elif secenekd == "h":
                secenekend = "q"
            else:
                print("Önceki Menüye Gönderiliyorsunuz")
                secenekend = "q"
        else:
            YeniB = Bakiyeler[KullaniciAdi] + YeniB
            Bakiyeler.pop(KullaniciAdi)
            Bakiyeler.insert(KullaniciAdi, YeniB)
            print("İşlem Başarılı, Hesabınızın Yeni Bakiyesi " + str(Bakiyeler[KullaniciAdi]) + " TL")
            secenekend = "q"

def OyunListele():
    i = 0
    d = 0
    for Oyun in Oyunlar:
        print(str(d + 1) + ") " + Oyun + " " + str(Fiyatlar[i]) + " TL")
        i += 1
        d += 1

def OyunEkle():
    YeniOyun = input("Lütfen Eklemek İstediğiniz Oyunun Adını Giriniz")
    YeniFiyat = int(input("Lütfen " + YeniOyun + " Adlı Oyunun Fiyatını Ayarlayınız"))
    Oyunlar.append(YeniOyun)
    Fiyatlar.append(YeniFiyat)
    print(YeniOyun + " Adlı Oyun " + str(YeniFiyat) + " TL İle Sisteme Eklenmiştir")

def FiyatGuncelle():
    secenekend = "Q"
    while secenekend != "q":
        print("Lütfen Hangi Oyunu Güncellemek İstediğinizi Seçin")
        OyunListele()
        secim = int(input("Lütfen Seçim Yapınız"))
        secim = secim - 1
        if secim < 0 or secim >= len(Oyunlar):
            print("Geçerli Bir Seçenek Girmediniz")
            secenekd = input("Tekrar Denemek İster Misiniz? e/h")
            if secenekd == "e":
                secenekend = "Q"
            elif secenekd == "h":
                secenekend = "q"
            else:
                print("Önceki Menüye Gönderiliyorsunuz")
                secenekend = "q"
        else:
            print(Oyunlar[secim] + " " + str(Fiyatlar[secim]) + " TL")
            YeniFiyat = int(input("Oyunun Fiyatını Kaç TL Olarak Güncellemek İstediğinizi Giriniz"))
            Fiyatlar.pop(secim)
            Fiyatlar.insert(secim, YeniFiyat)
            print(Oyunlar[secim] + " " + str(Fiyatlar[secim]) + " TL Olarak Güncellenmiştir")
            secenekend = "q"

def OyunAl(KullaniciAdi):
    secenekend = "Q"
    KullaniciAdi = KullaniciAdlari.index(KullaniciAdi)
    while secenekend != "q":
        print("Bakiyeniz " + str(Bakiyeler[KullaniciAdi]) + " TL")
        OyunListele()
        secimO = int(input("Lütfen Seçim Yapınız"))
        secimO = secimO - 1
        if secimO < 0 or secimO >= len(Oyunlar):
            print("Geçerli Bir Seçenek Girmediniz")
            secenekd = input("Tekrar Denemek İster Misiniz? e/h")
            if secenekd == "e":
                secenekend = "Q"
            elif secenekd == "h":
                secenekend = "q"
            else:
                print("Önceki Menüye Gönderiliyorsunuz")
                secenekend = "q"
        elif Fiyatlar[secimO] > Bakiyeler[KullaniciAdi]:
            print("Bakiyeniz Yetersiz")
            secenekd = input("Tekrar Denemek İster Misiniz? e/h")
            if secenekd == "e":
                secenekend = "Q"
            elif secenekd == "h":
                secenekend = "q"
            else:
                print("Önceki Menüye Gönderiliyorsunuz")
                secenekend = "q"
        else:
            i = 0
            k = 0
            while i < len(Kutuphaneler):
                if Oyunlar[secimO] == Kutuphaneler[i]:
                    if KullaniciAdlari[KullaniciAdi] == KutKullaniciAdlari[i]:
                        print("Bu Oyun Zaten Kütüphanenizde Bulunmkatadır")
                        secenekd = input("Tekrar Denemek İster Misiniz? e/h")
                        if secenekd == "e":
                            secenekend = "Q"
                        elif secenekd == "h":
                            secenekend = "q"
                        else:
                            print("Önceki Menüye Gönderiliyorsunuz")
                            secenekend = "q"
                else:
                    k += 1
                i += 1
            if k >= len(Kutuphaneler):
                Kutuphaneler.append(Oyunlar[secimO])
                KutKullaniciAdlari.append(KullaniciAdlari[KullaniciAdi])
                YeniB = Bakiyeler[KullaniciAdi] - Fiyatlar[secimO]
                Bakiyeler.pop(KullaniciAdi)
                Bakiyeler.insert(KullaniciAdi, YeniB)
                print(Oyunlar[secimO] + " Adlı Oyun Kütüphanenize Eklenmiştir")
                print("Yeni Bakiyeniz " + str(Bakiyeler[KullaniciAdi]) + " TL")
                secenekend = "q"

def Sistem():
    import time
    secenekend = "Q"
    secenekendB = "Q"
    secenekendA = "Q"

    while secenekend != "q":
        print("1) Oturum Aç")
        print("2) Kaydol")
        print("3) Yönetici Girişi")
        secim = input("Lütfen Seçim Yapınız")
        if secim == "1":
            i = 0
            k = 0
            KullaniciAdi = input("Lütfen Kullanıcı Adınızı Giriniz")
            Parola = input("Lütfen Parolanızı Giriniz")
            while i < len(KullaniciAdlari):
                if KullaniciAdi == KullaniciAdlari[i]:
                    if Parola == Parolalar[i]:
                        print("Hoşgeldiniz " + KullaniciAdi)
                        print("Bakiyeniz " + str(Bakiyeler[i]) + " TL")
                        while secenekendB != "q":
                            print("1) Oyun Al")
                            print("2) Kütüphaneye Bak")
                            print("3) Cüzdana Para Ekle")
                            print("4) Çıkış Yap")
                            secimB = input("Lütfen Seçim Yapınız")
                            if secimB == "1":
                                OyunAl(KullaniciAdi)
                                secenekendB = "Q"
                            elif secimB == "2":
                                Kutuphane(KullaniciAdi)
                                secenekendB = "Q"
                            elif secimB == "3":
                                ParaEkle(KullaniciAdi)
                                secenekendB = "Q"
                            elif secimB == "4":
                                print("Oturum Kapatılıyor")
                                secenekendB = "q"
                            else:
                                print("Geçerli Bir Seçenek Girmediniz")
                                secenekendB = "Q"
                        if secenekendB == "q":
                            secenekend = "q"
                    else:
                        print("Parola Hatalı, Lütfen Daha Sonra Tekrar Deneyiniz")
                        secenekend = "Q"
                else:
                    k += 1
                i += 1
                if k >= len(KullaniciAdlari):
                    print("Kullanıcı Adınız Sisteme Kayıtlı Değil, Lütfen Daha Sonra Tekrar Deneyiniz")
                    secenekend = "Q"
        elif secim == "2":
            Kaydol()
            secenekend = "Q"
        elif secim == "3":
            ai = 0
            ak = 0
            AdKullaniciAdi = input("Lütfen Kullanıcı Adınızı Giriniz")
            AdParola = input("Lütfen Parolanızı Giriniz")
            while ai < len(AdminKullaniciAdlari):
                if AdKullaniciAdi == AdminKullaniciAdlari[ai]:
                    if AdParola == AdminParolalar[ai]:
                        print("Hoşgeldin Admin " + AdKullaniciAdi)
                        while secenekendA != "q":
                            print("1) Oyun Ekle")
                            print("2) Fiyat Güncelle")
                            print("3) Çıkış Yap")
                            secimA = input("Lütfen Seçim Yapınız")
                            if secimA == "1":
                                OyunEkle()
                                secenekendA = "Q"
                            elif secimA == "2":
                                FiyatGuncelle()
                                secenekendA = "Q"
                            elif secimA == "3":
                                print("Oturum Kapatılıyor")
                                secenekendA = "q"
                            else:
                                print("Geçerli Bir Seçenek Girmediniz")
                                secenekendA = "Q"
                        if secenekendA == "q":
                            secenekend = "q"
                    else:
                        print("Parola Hatalı, Lütfen Daha Sonra Tekrar Deneyiniz")
                        secenekend = "Q"
                else:
                    ak += 1
                ai += 1
                if ak >= len(AdminKullaniciAdlari):
                    print("Kullanıcı Adınız Sisteme Kayıtlı Değil, Lütfen Daha Sonra Tekrar Deneyiniz")
                    secenekend = "Q"
    print("...")
    time.sleep(1)
    print("İyi Günler Dileriz")