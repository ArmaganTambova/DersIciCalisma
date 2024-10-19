KullaniciAdlari = ["Poyraz26", "Cemre", "ArmaganT", "ZümraKoparan", "NisaNUR"]
Parolalar = ["PyrzSlh2008", "cemre0910", "armagan1864", "Zümraa0804", "NisaaNr"]
Bakiyeler = [250, 850, 275]

AdminKullaniciAdleri = ["ArmaganTAMBOVA", "PoyrazSALİH", "CemreNAZ"]
AdminParolalar = ["ArmaganTambova1864", "PyrzSLH2008", "CEMRE0910"]

Kutuphaneler = ["God Of War", "Valorant"]
KutKullaniciAdleri = ["ArmaganT", "Cemre"]

Oyunlar = ["The Last Of Us " , "God Of War" , "Valorant" , "Dying Light" , "Uncharted" , "Resident Evil" , "Call Of Duty" , "Fortnite" , "A Way Out" , "Tomb Raider" , "Grand Theft Auto" , "Devour" , "Among Us" , "Outlast" , "Crysis"]
Fiyatlar = [599, 197, 40, 32, 59, 349, 30, 471, 99, 34, 99, 125, 39, 50, 10]

def OyunListele():
    i = 0
    d = 0
    for Oyun in Oyunlar:
        print(str(d + 1) + ") " + Oyun + " " + str(Fiyatlar[i]) + " TL")
        i += 1
        d += 1

def Sistem():
    i = 0
    k = 0
    ik = 0
    kk = 0
    ika = 0
    ikak = 0
    ia = 0
    ka = 0
    YeniB = 0
    YeniBB = 0
    secimO = 0
    b = 0
    donus1 = "0"
    donus2 = "0"
    donus3 = "0"
    donusad = "Q"
    donusadad = "Q"
    donusparola = "Q"
    donusadparola = "Q"
    secenekend = "Q"
    
    while secenekend != "q":
        if donus2 == "1":
            secimB = "1"
        else:
            print("1) Oturum Aç")
            print("2) Kaydol")
            print("3) Yönetici Girişi")
            secimB = input("Lütfen Seçim Yapınız")
        while secimB ==  "1":
            if donus1 == "1":
                KullaniciA = donusad
                Parolaa = donusparola
                i = 0
                k = 0
                ik = 0
                kk = 0
                b = 0
            else:
                i = 0
                k = 0
                b = 0
                KullaniciA = input("Lütfen Kullanıcı Adınızı Giriniz")
                Parolaa = input("Lütfen Şifrenizi Giriniz")
            while i < len(KullaniciAdlari):
                if KullaniciA == KullaniciAdlari[i]:
                    if Parolaa == Parolalar[i]:
                        donusad = KullaniciA
                        donusparola =  Parolaa
                        if donus1 != "1":
                            print("Hoşgeldin " + KullaniciA)
                            print("1) Oyun Al")
                            print("2) Kütüphaneye Bak")
                            secimBB = input("Lütfen Seçim Yapınız")
                        else:
                            secimBB = "1"
                        while secimBB == "1":
                            print("Bakiyeniz " + str(Bakiyeler[i]))
                            OyunListele()
                            secimO = int(input("Lütfen Almak İstediğiniz Oyunu Seçiniz"))
                            if (secimO - 1) < 0 or (secimO - 1) >= len(Oyunlar):
                                print("Geçerli Bir Seçenek Girmediniz")
                                secimBB = "1"
                            else:
                                if Fiyatlar[secimO - 1] >= Bakiyeler[i]:
                                    print("Bakiyeniz Yetersiz")
                                    secimBB = "1"
                                else:
                                    YeniB = Bakiyeler[i] - Fiyatlar[secimO - 1]
                                    Bakiyeler.pop(i)
                                    Bakiyeler.insert(i, YeniB)
                                    print(Oyunlar[secimO - 1] + " Adlı Oyun Kütüphanenize Eklendi")
                                    Kutuphaneler.append(Oyunlar[secimO - 1])
                                    KutKullaniciAdleri.append(KullaniciA)
                                    print("Yeni Bakiyeniz = " + str(Bakiyeler[i]))
                                    print("1) Başka Oyun Al")
                                    print("2) Kütüphaneye Bak")
                                    print("3) Çıkış Yap")
                                    secimOK = input("Lütfen Bir Seçim Yapınız")
                                    if secimOK == "1":
                                        secimBB = "1"
                                    elif secimOK == "2":
                                        secimBB = "2"
                                    elif secimOK == "3":
                                        print("Oturum Kapatıldı")
                                        donus1 = "Q"
                                        secimBB = "Q"
                                    else:
                                        print("Geçerli Bir Seçenek Girmediğiniz İçin Oturum Kapatıldı")
                                        donus1 = "Q"
                                        secimBB = "Q"
                        while secimBB == "2":
                            while ik < len(Kutuphaneler):
                                if KullaniciA == KutKullaniciAdleri[ik]:
                                    print(Kutuphaneler[ik])
                                else:
                                    kk += 1
                                ik += 1
                                if kk >=len(Kutuphaneler):
                                    print("Kütüphanenizde Oyun Bulunmamaktadır")
                            print("1) Oyun Al")
                            print("2) Çıkış Yap")
                            secimK = input("Lütfen Seçim Yapınız")
                            if secimK == "1":
                                secimBB = "1"
                                donus1 = "1"
                            elif secimK == "2":
                                print("Oturum Kapatıldı")
                                donus1 = "Q"
                                secimBB = "Q"
                            else:
                                print("Geçerli Bir Seçenek Girmediğiniz İçin Oturum Kapatıldı")
                                donus1 = "Q"
                                secimBB = "Q"
                        if donus1 == "1":
                            secimB = "1"
                        else:
                            if secimBB == "Q":
                                secimB =  "Q"
                                secenekend = "q"
                            elif secimBB != "1" or secimBB != "2":
                                print("Geçerli Bir Seçenek Girmediğiniz İçin Oturum Kapatıldı")
                                secimB = "Q"
                    else:
                        print("Şifre Yanlış")
                        print("Lütfen Tekrar Deneyiniz")
                        b = 1
                        secimB = "Q"
                else:
                    k += 1
                i += 1
                if k >= len(KullaniciAdlari):
                    print("Kullanıcı Adı Sisteme Kayıtlı Değil")
                    print("Lütfen Tekrar Deneyiniz")
                    b = 1
                    secimB = "Q"

        while secimB == "2":
            YeniKullaniciAdi = input("Lütfen Kullanıcı Adını Belirleyiniz")
            YeniParola = input("Lütfen Parolanızı Belirleyiniz")
            ika = 0
            ikak = 0
            while ika < len(KullaniciAdlari):
                if YeniKullaniciAdi == KullaniciAdlari[ika]:
                    print("Kullanıcı Adı Önceden Alınmış")
                    print("Lütfen Başka Bir Kullanıcı Adı Kullanıp Tekrar Deneyiniz")
                    ikak = 0
                    secimB = "2"
                else:
                    ikak += 1
                ika += 1
            if ikak >= len(KullaniciAdlari):
                YeniBB = 0
                KullaniciAdlari.append(YeniKullaniciAdi)
                Parolalar.append(YeniParola)
                Bakiyeler.append(YeniBB)
                print("Kayıt İşlemi Tamamlanmıştır")
                print("Oturum Açma Sayfasına Yönlendiriliyorsunuz")
                donus2 = "1"
                secimB = "1"

        while secimB == "3":
            if donus3 == "1":
                KullaniciA = donusadad
                Parolaa = donusadparola
                ia = 0
                ik = 0
                b = 0
            else:
                ia = 0
                ik = 0
                b = 0
                KullaniciA = input("Lütfen Kullanıcı Adınızı Giriniz")
                Parolaa = input("Lütfen Şifrenizi Giriniz")
            while ia < len(AdminKullaniciAdleri):
                if KullaniciA == AdminKullaniciAdleri[ia]:
                    if Parolaa == AdminParolalar[ia]:
                        donusadad = KullaniciA
                        donusadparola = Parolaa
                        if donus3 == "1":
                            secimA = "1"
                            donus3 = "0"
                        else:
                            print("Hoşgeldin Admin " + KullaniciA)
                            print("1) Oyun Ekle")
                            print("2) Fiyat Güncelle")
                            secimA = input("Lütfen Seçim Yapınız")
                        while secimA == "1":
                            YeniOyun = input("Lütfen Eklemek İstediğiniz Oyunun Adını Giriniz")
                            YeniFiyat = int(input(YeniOyun + " Adlı Oyunun Fiyatını Belirleyiniz"))
                            Oyunlar.append(YeniOyun)
                            Fiyatlar.append(YeniFiyat)
                            print(YeniOyun + " Adlı Oyun " + str(YeniFiyat) + " TL İle Sisteme Eklendi")
                            print("1) Oyunları Listele")
                            print("2) Fiyat Güncelle")
                            print("3) Çıkış Yap")
                            secimAA = input("Lütfen Seçim Yapınız")
                            if secimAA == "1":
                                OyunListele()
                                print("1) Başka Oyun Ekle")
                                print("2) Fiyat Güncelle")
                                print("3) Çıkış Yap")
                                secimAAA = input("Lüfen Seçim Yapınız")
                                if secimAAA == "1":
                                    secimA = "1"
                                elif secimAAA == "2":
                                    secimA = "2"
                                elif secimAAA == "3":
                                    print("Oturum Kapatıldı")
                                    b = 1
                                    donus3 = "0"
                                    secimA = "Q"
                                else:
                                    print("Geçerli Bir Seçenek Girmediğiniz İçin Oturum Kapatıldı")
                                    secimA = "Q"
                                    donus3 = "0"
                            elif secimAA == "2":
                                secimA = "2"
                            elif secimAA == "3":
                                print("Oturum Kapatıldı")
                                b = 1
                                donus3 = "0"
                                secimA = "Q"
                            else:
                                print("Geçerli Bir Seçenek Girmediğiniz İçin Oturum Kapatıldı")
                                secimA = "Q"
                        while secimA == "2":
                            OyunListele()
                            GüncelleOyun = int(input("Lütfen Fiyatını Güncellemek İstediğiniz Oyunu Giriniz"))
                            print(Oyunlar[GüncelleOyun - 1] + " " + str(Fiyatlar[GüncelleOyun - 1]) + " TL")
                            GüncelleFiyat = int(input("Lütfen Oyunun Fiyatını Kaç TL Olarak Güncellemek İstediğinizi Giriniz"))
                            Fiyatlar.pop(GüncelleOyun - 1)
                            Fiyatlar.insert((GüncelleOyun - 1), GüncelleFiyat)
                            print(Oyunlar[GüncelleOyun - 1] + " Adlı Oyunun Fiyatı " + str(Fiyatlar[GüncelleOyun - 1]) + " TL Olarak Değiştirilmiştir")
                            print("1) Fiyat Güncelle")
                            print("2) Oyun Ekle")
                            print("3) Çıkış Yap")
                            secimAAAA = input("Lütfen Seçim Yapınız")
                            if secimAAAA == "1":
                                secimA = "2"
                            elif secimAAAA == "2":
                                secimA = "1"
                                donus3 = "1"
                            elif secimAAAA == "3":
                                print("Oturum Kapatıldı")
                                secimA = "Q"
                                donus3 = "0"
                            else:
                                print("Geçerli Bir Seçenek Girmediğiniz İçin Oturum Kapatıldı")
                                secimA = "Q"
                                donus3 = "0"
                        if donus3 == "1":
                            secimA = "1"
                        else:
                            if secimA == "Q":
                                secimB = "Q"
                            elif secimA != "1" or secimA != "2":
                                print("Geçerli Bir Seçenek Girmediğiniz İçin Oturum Kapatıldı")
                                secimB = "Q"
                    else:
                        print("Şifre Yanlış")
                        print("Lütfen Tekrar Deneyiniz")
                        b = 1
                        secimB = "Q"
                else:
                    ka += 1
                ia += 1
                if ka >= len(AdminKullaniciAdleri):
                    print("Kullanıcı Adı Sisteme Kayıtlı Değil")
                    print("Lütfen Tekrar Deneyiniz")
                    b = 1
                    secimB = "Q"
        if donus2 == "1":
            secimB = "1"
        else:
            if b != 0:
                secenekend = "Q"
            else:
                if secimB == "Q":
                    print("İyi Günler Dileriz")
                    secenekend =  "q"
                elif secimB != "1" or secimB != "2" or secimB != "3":
                    print("Geçerli Bir Seçenek Girmediniz")
                    secenekend = "q"