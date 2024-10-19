Dizi = []

Sayi = 0
Onceki = 0
Toplam = 0
i = 0

Basamak = int(input("Lütfen Basamak Gir = "))

while i <= Basamak:
    if Sayi == 0:
        Sayi = 1
        Onceki = 0
    else:
        Toplam = Sayi + Onceki
        print(str(i) + str(Onceki) + " + " + str(Sayi) + " = " + str(Toplam))
        Dizi.append(Toplam)
        Onceki = Sayi
        Sayi = Toplam
    i += 1

print("****************************************")

for D in Dizi:
    Index = Dizi.index(D)

    if Index == len(Dizi) - 1:
        print(D)
    else:
        print(D, end=", ")