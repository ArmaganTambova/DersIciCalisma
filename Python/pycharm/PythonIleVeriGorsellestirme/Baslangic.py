# Bu Dersimizde Python'ın Veri Görselleştirme Araçlarından Olan matplotlib Kütüphanesini İnceleyeceğiz
# Veri Görselleştirme:
# Sayısal Olarak Belirtilen Verilerin Raporlama Yapılırken Anlaşılması Zor Olabilir
# Verileri Görsel Olarak Grafiksel Şekilde Hazırlamak Veri Görselleştirme Olarak Adlandırılabilir
# Başka Bir İfadeyle "Veri Görselleştirme: Elimizdeki Soyut Verilerin Görsel Hale Getirilerek Somutlaştırılması Ve Bundan Bir Ön Bilgi Elde Edilmesi İşidir"
# Veri Görselleştirme Yapılırken Dikkat Edilmesi Gereken Bazı Husular Şunlardır:
# 1- Renklerin Uyumlu Olması
# 2- Sade Ve Yalın Olması
# 3- Doğru Grafik Türünün Seçilmesi
# 4- Grafiğin Anlaşılabilir Olması
# 5- Rakamların Yerleşiminin Doğru Yapılması

# Kullanılacak Araçlar (Kütüphaneler):
# Matplotlib = Veri Görselleştirilmesinde Kullanılacak Temel Python Kütüphanesidir, 2 Ve 3 Boyutlu Çizimler Yapmamızı Sağlar
# pandas = Dosyadan (Excel) Veri Çekmemize Yarayan Kütüphanedir

# İndirilmiş Ve Kullanılmaya Hazır Kütüphanelerimizi "File=>Project:"Proje Adı"=>python Interpreter" Alanından Kontrol Edebilir Ve Yeni Kütüphaneler Ekleyebilirsiniz

import matplotlib.pyplot as plt
import pandas as pd

Veri = pd.read_excel("OgrenciNotlari.xlsx")

# Excel İçindeki Kolonların Diziye Çevrilmesi
# astype('float') Okunan Verileri Float Türüne Döndürdük
Veri['Yazılım'] = Veri['Yazılım'].astype('float')
Veri['BilgisayarBilimi'] = Veri['BilgisayarBilimi'].astype('float')

# Verileri Göster
Veri.head(5)
plt.figure(figsize=(20, 6))
# plt.figure(figsize=(20, 6))   figsize(20,6) Grafik Penceresinin Genişliğini Ve Yüksekliğini Ayarlar
# plt.title("Öğrenci Notları")  Başlığı Ayarlar
# plt.xlabel("Öğrenciler")      X Ekseninde Yazı Yazar
# plt.ylabel("Notlar")          Y Ekseninde Yazı Yazar
# plt.plot(Veri.Öğrenciler, Veri.Yazılım)
# plt.plot(Veri.Öğrenciler, Veri.BilgisayarBilimi)
plt.subplot(2, 1, 1)
plt.title("Yazılım Notları")
plt.xlabel("Öğrenciler")
plt.ylabel("Notlar")
plt.bar(Veri.Öğrenciler, Veri.Yazılım)
plt.subplot(2, 1, 2)
plt.title("Bilgisayar Bilimi Notları")
plt.xlabel("Öğrenciler")
plt.ylabel("Notlar")
plt.bar(Veri.Öğrenciler, Veri.BilgisayarBilimi, color='pink', width=0.1)
# plot = Çizgi Grafiği, bar = Sütün Grafiği, scatter = Nokta Grafiği, pie = Pasta Grafiği
plt.show()