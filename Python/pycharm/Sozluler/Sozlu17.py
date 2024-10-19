KullaniciAdi = "admin"
Sifre = "1234"

KullaniciAdiV = input("Lütfen Kullanıcı Adınızı Giriniz")
SifreV = input("Lütfen Şifrenizi Giriniz")
if KullaniciAdiV == KullaniciAdi:
    if SifreV == Sifre:
        print("Giriş Başarılı")
    else:
        print("Giriş Başarısız")
else:
    print("Giriş Başarısız")