# İsim, Soyad, Kimlik Numarası, Doğum Tarihi, Kullanıcı Adı, Şifre Al
# İsim min 3 karakter
# Soyisim min 3 karakter
# Kullanıcı adı min 3, max 15 karakter
# Şifre min 8 karakter
# Yaş 12'den büyük olacak
# Yukarıdaki tüm bilgiler doğru girilene kadar kontrol edilmeye devam edilecek

import VeriKontrol as Veri

isimonay = False
while isimonay == False:
    isim = input("İsminizi Giriniz")
    isimonay = Veri.IsimKontrol(isim)
    if isimonay == True:
        print("İsim Onaylandı")
    else:
        print("İsim 3 Karakterden Küçük Olamaz. Lütfen Tekrar Deneyiniz")

soyadonay = False
while soyadonay == False:
    soyad = input("Soyadınızı Giriniz")
    soyadonay = Veri.SoyadKontrol(soyad)
    if soyadonay == True:
        print("Soyad Onaylandı")
    else:
        print("Soyad 3 Karakterden Küçük Olamaz. Lütfen Tekrar İsim Giriniz")

yasonay = False
while yasonay == False:
    dogumtarihi = input("Lütfen Doğum Tarihinizi Gün.Ay.Yıl Şeklinde Yazınız")
    yasonay = Veri.YasKontrol(dogumtarihi)
    if yasonay == True:
        print("Yaş Onaylandı")
    else:
        print("Yaşınız 12'den Küçük Olamaz")

kullaniciadionay = False
while kullaniciadionay == False:
    KullaniciAdi = input("Lütfen Kullanıcı Adınızı Giriniz")
    kullaniciadionay = Veri.KullaniciAdiKontrol(KullaniciAdi)
    if kullaniciadionay == True:
        print("Kullanıcı Adı Onaylandı")
    else:
        print("Kullanıcı Adınız 3 Karakterden Az 15 Karakterden Fazla Olamaz. Lütfen Tekrar Deneyiniz")

sifreonay = False
while sifreonay == False:
    Sifre = input("Lütfen Şifrenizi Giriniz")
    sifreonay = Veri.SifreKontrol(Sifre)
    if sifreonay == True:
        print("Şifre Onaylandı")
    else:
        print("Şifreniz 8 Karakterden Az Olamaz. Lütfen Tekrar Deneyiniz")

mailonay = False
while mailonay == False:
    Gmail = input("Lütfen Gmail Adresini Giriniz")
    mailonay = Veri.MailKontrol(Gmail)
    if mailonay == True:
        print("Gmail Adresiniz Onaylandı")
    else:
        print("Gmail Adresinizde @ ve . Sembolleri Bulunmalıdır. Lütfen Tekrar Deneyiniz")

parolaonay = False
while parolaonay == False:
    Sifre = input("Lütfen Şifrenizi Giriniz")
    parolaonay = Veri.MailSifreKontrol(Sifre)
    if parolaonay == True:
        print("Şifreniz Onaylandı")
    else:
        print("Şifrenizin İçerisinde ?, !, . ve * Sembollerinden En Az Birisi Bulunmalıdır")