Sayilar = [5, 3, -2, 10, 11, 22, -8, 25, 12, 3]
print("Dizinin Eleman Sayısı = " + str(len(Sayilar)))
print("Dizinin Elemanları;")
for Sayi in Sayilar:
    print(Sayi)
# --------------------------------------------------------
print("Dizinin Negatif Elemanları;")
for Sayi in Sayilar:
    if Sayi < 0:
        print(Sayi)
# --------------------------------------------------------
print("Dizinin Pozitif Sayılarının Toplamı;")
Toplam = 0
for Sayi in Sayilar:
    if Sayi >= 0:
        Toplam += Sayi
print(Toplam)
# --------------------------------------------------------
Urunler = []
i = 0
while i < 5:
    Veri = input("Lütfen " + str((i + 1)) + ". Kırtasiye Ürününüzü Giriniz")
    Urunler.append(Veri)
    i += 1
print("Girilen Ürünler;")
for Urun in Urunler:
    print(Urun)
# --------------------------------------------------------
Urunler1 = []
Fiyatlar = []
Secenek = "e"
d = 0
while Secenek == "e":
    Esya = input("Lütfen " + str((d + 1)) + ". Kırtasiye Ürününüzü Giriniz")
    Fiyat = float(input("Lütfen " + Esya + " Adlı Ürünün Fiyatını Giriniz"))
    Urunler1.append(Esya)
    Fiyatlar.append(Fiyat)
    i += 1
    Secenek = input("Ürün Eklemeye Devam Etmek İster Misiniz? e/h")
print("Girilen Ürünler;")
k = 0
for Urun in Urunler1:
    print(Urun + " " + str(Fiyatlar[k]) + " TL")
    k += 1