import datetime as tarih

def IsimKontrol(isim):
    if(len(isim) >= 3):
        return True
    else:
        return False

def SoyadKontrol(soyad):
    if(len(soyad) >= 3):
        return True
    else:
        return False

def YasKontrol(DogumTarihi):
    BuYil = tarih.datetime.now().year
    DogumYil = tarih.datetime.strptime(DogumTarihi, '%d.%m.%Y').year
    yas = BuYil - DogumYil
    if (yas >= 12):
        return True
    else:
        return False

def KullaniciAdiKontrol(KullaniciAdi):
    if len(KullaniciAdi) > 3 and len(KullaniciAdi) < 15:
        return True
    else:
        return False

def SifreKontrol(Sifre):
    if (len(Sifre) < 8):
        return False
    else:
        return True

def MailKontrol(Gmail):
    MailSembol = ["@", "."]
    i = 0
    k = 0
    while i < len(Gmail):
        if MailSembol.__contains__(Gmail[i]):
            k += 1
        i += 1
    if k == 2:
        return True
    else:
        return False

def MailSifreKontrol(Sifre):
    SifreSembol = ["?", "!", ".", "*"]
    i = 0
    k = 0
    while i < len(Sifre):
        if SifreSembol.__contains__(Sifre[i]):
            k += 1
        i += 1
    if k >= 1:
        return True
    else:
        return False