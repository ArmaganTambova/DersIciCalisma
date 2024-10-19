# Değişkenler

sayi = 12
# 12 Sayısal Veri Olarak Kullanılmaktadır
# sayi Değişkeninin Türü int(integer) olmuştur
print(sayi)

isim = "Alp"
# "Alp" Metinsel Veri Olarak Kullanılmaktadır
# isim Değişkeninin Türü string Olmuştur
print(isim)

harclik = 80.99
# 80.99 Ondalık Bir Sayıdır
# harclik Değişkeninin Türü float Olmuştur
print(harclik)

veri = input("İsminizi Giriniz = ")
print("İsminiz = " + veri)
# Programlamada Tüm Veri Girişlerinin Türü string'dir

dogumyili = int(input("Doğum Yılınızı Giriniz = "))
yas = 2023 - dogumyili
print("Yaşınız = " + str(yas))
if yas >= 15:
    print("Yaş Değeri Uygundur")
else:
    print("Yaş Değeri Uygun Değildir")
# İf Çalışır İse Else Çalışmaz, İf Çalışmaz İse Else Çalışır

sayi1 = int(input("Lütfen İlk Sayıyı Giriniz = "))
sayi2 = int(input("Lütfen İkinci Sayıyı Giriniz = "))
toplam = sayi1 + sayi2
print("Cevabınız = " + str(toplam))