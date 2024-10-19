Kitaplar = ["Suç ve Ceza", "Savaş ve Barış"]
Yazarlar = ["Dostoyevski", "Tolstoy"]
YayinEvleri = ["İş Bankası Kültür Yayınları", "İş Bankası Kültür Yayınları"]
Linkler = ["https://www.dr.com.tr/kitap/suc-ve-ceza-hasan-ali-yucel-klasikleri/edebiyat/roman/dunya-klasik/urunno=0000000222780", "https://www.dr.com.tr/kitap/savas-ve-baris-2-kitap-takim/edebiyat/roman/dunya-klasik/urunno=0000000724379"]
Fiyatlar = [85, 75]

KullaniciAdlari = ["ArmaganT", "Zumra", "Cemre09", "Nisaa"]
Parolalar = ["armagan1864", "Zumraa08", "CemreNAZ", "NisaaNUR"]
Bakiyeler = [550, 250, 150, 850]

AdminKullaniciAdi = ["ArmaganTAMBOVA", "CEMRENaz"]
AdminParola = ["ArmaganTambova1864", "CemreNAZT09"]

Kutuphaneler = ["Suç ve Ceza", "Suç ve Ceza"]
KullaniciAdlariKutuphane = ["ArmaganT", "CemreNAZ"]

KitaplarYorum = ["Suç ve Ceza", "Savaş ve Barış", "Suç ve Ceza"]
KullaniciAdlariYorum = ["CemreNAZ", "ArmaganT", "ArmaganT"]
Yorumlar = ["Kitap gayet iyi", "Kitap Gayet İyi", "Kitap Gayet İyi"]

def Kaydol():
    secenekend = "Q"
    while secenekend != "q":
        i = 0
        k = 0
        YeniKullaniciA = input("Lütfen Kullanıcı Adınızı Belirleyiniz")
        YeniParola = input("Lütfen Parolanızı Belirleyiniz")
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

def CuzdanaParaEkle(KullaniciAdi):
    secenekend = "Q"
    KullaniciAdi = KullaniciAdlari.index(KullaniciAdi)

    while secenekend != "q":
        YeniB = int(input("Lütfen Cüzdanınıza Eklemek İstediğiniz Bakiyeyi Giriniz"))
        if YeniB < 0:
            print("Geçerli Bir Seçenek Girmediniz")
            secim = input("Tekrar Denemek İster Misiniz? e/h")
            if secim == "e":
                secenekend = "Q"
            elif secim == "h":
                secenekend = "q"
            else:
                print("Geçerli Bir Seçenek Girmediğiniz İçin Önceki Menüye Yönlendiriliyorsunuz")
                secenekend = "q"
        else:
            YeniB = Bakiyeler[KullaniciAdi] + YeniB
            Bakiyeler.pop(KullaniciAdi)
            Bakiyeler.insert(KullaniciAdi, YeniB)
            print("Bakiyeniz " + str(Bakiyeler[KullaniciAdi]) + " TL")
            print("İşleminiz Tamamlanmıştır Önceki Sayfaya Yönlendiriliyorsunuz")
            secenekend = "q"

def KitapListele():
    i = 0
    while i < len(Kitaplar):
        print(str((i + 1)) + ") " + Kitaplar[i] + " / " + Yazarlar[i] + " / " + YayinEvleri[i] + " / " + str(Fiyatlar[i]) + " TL")
        i += 1

def Kutuphane(KullaniciAdi):
    i = 0
    k = 0
    KullaniciAdi = KullaniciAdlari.index(KullaniciAdi)

    print("Kütüphaneniz ;")
    while i < len(Kutuphaneler):
        if KullaniciAdlari[KullaniciAdi] == KullaniciAdlariKutuphane[i]:
            print(Kutuphaneler[i])
        else:
            k += 1
        i += 1
        if k >= len(Kutuphaneler):
            print("Kütüphanenizde Kitap Bulunmamaktadır")

def KitapInceleme(Index, KullaniciAdi):
    import webbrowser as web
    import time
    secenekend = "Q"
    i = 0
    k = 0
    KullaniciAdi = KullaniciAdlari.index(KullaniciAdi)
    print(Kitaplar[Index] + " / " + Yazarlar[Index] + " / " + YayinEvleri[Index] + " / " + str(Fiyatlar[Index]) + " TL")
    print("Yorumları ;")
    print(" ")
    while i < len(KitaplarYorum):
        if Kitaplar[Index] == KitaplarYorum[i]:
            print(KullaniciAdlariYorum[i])
            print(Yorumlar[i])
            print(" ")
        else:
            k += 1
        i += 1
        if k >= len(KitaplarYorum):
            print("Bu Kitabın Yorumu Bulunmamaktadır")
    while secenekend != "q":
        print("1) Kitabı Al")
        print("2) Yorum Ekle")
        print("3) Kitabın D&R Linkine Git")
        print("4) Önceki Menüye Dön")
        secim = input("Lütfen Seçim Yapınız")
        if secim == "1":
            if Fiyatlar[Index] > Bakiyeler[KullaniciAdi]:
                print("Bakiyeniz Yetersiz")
                secenekend = "Q"
            else:
                i = 0
                k = 0
                while i < len(KullaniciAdlariKutuphane):
                    if KullaniciAdlari[KullaniciAdi] == KullaniciAdlariKutuphane[i]:
                        if Kitaplar[Index] == Kutuphaneler[i]:
                            print("Bu Kitap Kütüphanenizde Bulunmaktadır")
                        else:
                            k += 1
                    else:
                        k += 1
                    i += 1
                if k >= len(KullaniciAdlariKutuphane):
                    YeniB = Bakiyeler[KullaniciAdi] - Fiyatlar[Index]
                    Bakiyeler.pop(KullaniciAdi)
                    Bakiyeler.insert(KullaniciAdi, YeniB)
                    Kutuphaneler.append(Kitaplar[Index])
                    KullaniciAdlariKutuphane.append(KullaniciAdlari[KullaniciAdi])
                    print("Yeni Bakiyeniz " + str(Bakiyeler[KullaniciAdi]) + " TL")
                    print(Kitaplar[Index] + " Adlı Kitap Kütüphanenize Eklenmiştir")
                    secenekend = "q"
        elif secim == "2":
            YeniYorum = input("Lütfen Yorumunuzu Yazınız")
            Yorumlar.append(YeniYorum)
            KitaplarYorum.append(Kitaplar[Index])
            KullaniciAdlariYorum.append(KullaniciAdlari[KullaniciAdi])
            print("Yorumunuz Başarıyla Eklenmiştir")
            secenekend = "q"
        elif secim == "3":
            print("Siteye Yönlendiriliyorsunuz")
            time.sleep(0.5)
            web.open(Linkler[Index])
            time.sleep(2)
        elif secim == "4":
            print("Önceki Menüye Yönlendiriliyorsunuz")
            secenekend = "q"
        else:
            print("Geçerli Bir Seçenek Girmediniz")
            secenekend = "Q"

def FiyatGuncelle():
    KitapListele()
    secim = int(input("Lütfen Hangi Kitabın Fiyatını Güncellemek İstediğinizi Giriniz"))
    secim = secim - 1
    print(Kitaplar[secim] + " / " + str(Fiyatlar[secim]))
    YeniFiyat = int(input("Lütfen Kitabın Fiyatını Kaç TL Olarak Güncellemek İstediğinizi Giriniz"))
    if YeniFiyat < 0:
        print("Geçerli Bir Değer Girmediniz")
    else:
        Fiyatlar.pop(secim)
        Fiyatlar.insert(secim, YeniFiyat)
        print("Fiyat " + str(Fiyatlar[secim]) + " TL Olarak Güncellenmiştir")

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
                        while secenekendB != "q":
                            print("Bakiyeniz " + str(Bakiyeler[i]) + " TL")
                            print("1) Kitapları Listele")
                            print("2) Kitap Adına Göre Ara")
                            print("3) Cüzdana Para Ekle")
                            print("4) Kütüphaneye Bak")
                            print("5) Çıkış Yap")
                            secimB = input("Lütfen Seçim Yapınız")
                            if secimB == "1":
                                KitapListele()
                                secenekK = input("Kitap İncelemek İster Misiniz? e/h")
                                if secenekK == "e":
                                    secimK = int(input("Hangi Kitabı İncelemek İstediğiniz Seçiniz"))
                                    secimK = secimK - 1
                                    if secimK < 0 or secimK >= len(Kitaplar):
                                        print("Geçerli Bir Seçenek Girmediğiniz İçin Önceki Menüye Yönlendiriliyorsunuz")
                                        secenekendB = "Q"
                                    else:
                                        KitapInceleme(secimK, KullaniciAdi)
                                        secenekendB = "Q"
                                elif secenekK == "h":
                                    print("Önceki Menüye Yönlendiriliyorsunuz")
                                    secenekendB = "Q"
                                else:
                                    print("Geçerli Bir Seçenek Girmediğiniz İçin Önceki Menüye Yönlendiriliyorsunuz")
                                    secenekendB = "Q"
                            elif secimB == "2":
                                i = 0
                                k = 0
                                KitapAdi = input("Lütfen Aradığınız Kitabın Adını Giriniz")
                                while i < len(Kitaplar):
                                    if KitapAdi == Kitaplar[i]:
                                        KitapAdi = Kitaplar.index(KitapAdi)
                                        KitapInceleme(KitapAdi, KullaniciAdi)
                                        secenekendB = "Q"
                                    else:
                                        k += 1
                                    i += 1
                                    if k >= len(Kitaplar):
                                        print("Arattığınız Kitap Sistemimizde Bulunamadı")
                                        secenekendB = "Q"
                            elif secimB == "3":
                                CuzdanaParaEkle(KullaniciAdi)
                                secenekendB = "Q"
                            elif secimB == "4":
                                Kutuphane(KullaniciAdi)
                                secenekendB = "Q"
                            elif secimB == "5":
                                print("Oturum Kapatılıyor")
                                secenekendB = "q"
                            else:
                                print("Geçerli Bir Seçenek Girmediniz")
                                secenekendB = "Q"
                        if secenekendB == "q":
                            secenekend = "q"
                    else:
                        print("Parolanız Yanlış, Lütfen Tekrar Deneyiniz")
                        secenekend = "Q"
                else:
                    k += 1
                i += 1
                if k >= len(KullaniciAdlari):
                    print("Kullanıcı Adı Sisteme Kayıtlı Değil, Lütfen Tekrar Deneyiniz")
                    secenekend = "Q"
        elif secim == "2":
            Kaydol()
            secenekend = "Q"
        elif secim == "3":
            i = 0
            k = 0
            KullaniciAdi = input("Lütfen Kullanıcı Adınızı Giriniz")
            Parola = input("Lütfen Parolanızı Giriniz")
            while i < len(AdminKullaniciAdi):
                if KullaniciAdi == AdminKullaniciAdi[i]:
                    if Parola == AdminParola[i]:
                        print("Hoşgeldiniz Admin " + KullaniciAdi)
                        while secenekendA != "q":
                            print("1) Kitap Ekle")
                            print("2) Fiyat Güncelle")
                            print("3) Çıkış Yap")
                            secimA = input("Lütfen Seçim Yapınız")
                            if secimA == "1":
                                YeniKAdi = input("Lütfen Eklemek İstediğiniz Kitabın Adını Giriniz")
                                YeniKYazar = input("Lütfen " + YeniKAdi + " Adlı Kitabın Yazarını Giriniz")
                                YeniKYayinEvi = input("Lütfen " + YeniKAdi + " Adlı Kitabın Yayın Evini Giriniz")
                                YeniLink = input("Lütfen Kitabın D&R Üzerindeki Linkini Giriniz")
                                YeniKFiyati = int(input("Lütfen " + YeniKAdi + " Adlı Kitabın Fiyatını Belirleyiniz"))
                                Kitaplar.append(YeniKAdi)
                                Yazarlar.append(YeniKYazar)
                                YayinEvleri.append(YeniKYayinEvi)
                                Linkler.append(YeniLink)
                                Fiyatlar.append(YeniKFiyati)
                                print(YeniKAdi + " / " + YeniKYazar + " / " + YeniKYayinEvi + " / " + str(YeniKFiyati) + " TL")
                                print("Olarak Sisteme Kaydedilmiştir")
                                secenekendA = "Q"
                            elif secimA == "2":
                                FiyatGuncelle()
                            elif secimA == "3":
                                print("Oturum Kpatılıyor")
                                secenekendA = "q"
                            else:
                                print("Geçerli Bir Seçenek Girmediniz")
                                secenekendA = "Q"
                        if secenekendA == "q":
                            secenekend = "q"
                    else:
                        print("Şifreniz Yanlış, Lütfen Tekrar Deneyiniz")
                        secenekend = "Q"
                else:
                    k += 1
                i += 1
                if k >= len(AdminKullaniciAdi):
                    print("Kullanıcı Adı Sisteme Kayıtlı Değil, Lütfen Tekrar Deneyiniz")
                    secenekend = "Q"
        else:
            print("Geçerli Bir Seçenek Girmediniz")
            secenekend = "Q"
    print("...")
    time.sleep(1)
    print("İyi Günler Dileriz")