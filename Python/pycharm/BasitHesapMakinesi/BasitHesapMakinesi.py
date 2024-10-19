Sayi1 = int(input("Lütfen İlk Sayıyı Giriniz"))
Sayi2 = int(input("Lütfen İkinci Sayıyı Giriniz"))

Toplam = Sayi1 + Sayi2
Cikarma = Sayi1 - Sayi2
Carpma = Sayi1 * Sayi2
Bolme = Sayi1 / Sayi2

print("Toplam = " + str(Toplam))
print("Çıkartma = " + str(Cikarma))
print("Çarpma = " + str(Carpma))
print("Bölme = " + str(Bolme))

if Sayi1 > Sayi2:
    print(str(Sayi1) + " > " + str(Sayi2))
else:
    print(str(Sayi2) + " > " + str(Sayi1))

if Sayi1 % 2 == 0:
    print(str(Sayi1) + " Çifttir")
else:
    print(str(Sayi1) + " Tekdir")
if Sayi2 % 2 == 0:
    print(str(Sayi2) + " Çifttir")
else:
    print(str(Sayi2) + " Tekdir")