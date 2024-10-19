import Geometri as Geo

print("*-*-*-*Kare Alan Hesaplama*-*-*-*")
KareOnay = False
while KareOnay == False:
    KareKenar = int(input("Lütfen Karenizin Bir Kenarını Giriniz = "))
    if KareKenar <= 0:
        print("Geçerli Bir Değer Girmediniz")
        KareOnay = False
    else:
        KareAlan = Geo.KareAlanHesaplama(KareKenar)
        print("Karenizin Alanı = " + str(KareAlan))
        print("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*")
        KareOnay = True

print("*-*-*-*Üçgen Alan Hesaplama*-*-*-*")
UcgenOnay = False
while UcgenOnay == False:
    UcgenTaban = int(input("Lütfen Üçgeninizin Taban Uzunluğunu Giriniz = "))
    UcgenYukseklik = int(input("Lütfen Üçgeninizin Yüksekliğini Giriniz = "))
    UcgenAlan = Geo.UcgenAlanHesaplama(UcgenTaban, UcgenYukseklik)
    if UcgenTaban <= 0 or UcgenYukseklik <= 0:
        print("Üçgenin Taban Veya Yükseklik Değeri 0 Veya 0'dan Küçük Olamaz")
        UcgenOnay = False
    else:
        print("Üçgeninizin Alanı = " + str(UcgenAlan))
        print("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*")
        UcgenOnay = True

print("*-*-*-*Dikdörtgen Alan Hesaplama*-*-*-*")
DikdortgenOnay = False
while DikdortgenOnay == False:
    DikdortgenUzun = int(input("Lütfen Dikdörtgeninizin Uzun Kenarını Giriniz = "))
    DikdortgenKisa = int(input("Lütfen Dikdörtgeninizin Kısa Kenarını Giriniz = "))
    if DikdortgenKisa > DikdortgenUzun:
        print("Kısa Kenar Uzun Kenardan Uzun Olamaz")
        DikdortgenOnay = False
    else:
        DikdortgenAlan = DikdortgenUzun * DikdortgenKisa
        print("Dikdörtgeninizin Alanı = " + str(DikdortgenAlan))
        print("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*")
        DikdortgenOnay = True

print("*-*-*-*Daire Alan Hesaplama*-*-*-*")
DaireOnay = False
while DaireOnay == False:
    DaireYaricap = int(input("Lütfen Dairenizin Yarıçapını Giriniz = "))
    if DaireYaricap <= 0:
        print("Geçerli Bir Değer Giriniz")
        DaireOnay = False
    else:
        DaireAlan = Geo.DaireAlanHesaplama(DaireYaricap)
        print("Dairenizin Alanı = " + str(DaireAlan))
        print("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*")
        DaireOnay = True

print("*-*-*-*Küre Hacim Hesaplama*-*-*-*")
KureOnay = False
while KureOnay == False:
    KureYaricap = int(input("Lütfen Kürenizin Yarıçapını Giriniz = "))
    if KureYaricap <= 0:
        print("Geçerli Bir Değer Giriniz")
        KureOnay = False
    else:
        KureAlan = Geo.KureHacimHesaplama(KureYaricap)
        print("Kürenizin Hacmi = " + str(KureAlan))
        print("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*")
        KureOnay = True

print("*-*-*-*Silindir Hacim Hesaplama*-*-*-*")
SilindirOnay = False
while SilindirOnay == False:
    SilindirYaricap = int(input("Lütfen Silindirinizin Yarıçapını Giriniz = "))
    SilindirYukseklik = int(input("Lütfen Silindirinizin Yüksekliğini Giriniz = "))
    if SilindirYaricap <= 0 or SilindirYukseklik <= 0:
        print("Geçerli Bir Değer Giriniz")
        SilindirOnay = False
    else:
        SilindirHacim = Geo.SilindirHacimHesaplama(SilindirYaricap, SilindirYukseklik)
        print("Silindirinizin Hacmi = " + str(SilindirHacim))
        print("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*")
        SilindirOnay = True

print("*-*-*-*Küp Hacim Hesaplama*-*-*-*")
KupOnay = False
while KupOnay == False:
    KupKenar = int(input("Lütfen Küpünüzün Bir Kenarını Giriniz = "))
    if KupKenar <= 0:
        print("Geçerli Bir Değer Giriniz")
        KupOnay = False
    else:
        KupAlan = Geo.KupHacimHesaplama(KupKenar)
        print("Küpünüzün Hacmi = " + str(KupAlan))
        KupOnay = True