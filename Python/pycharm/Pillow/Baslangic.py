# Pillow nedir?
# Pillow Modülü Python İçin Geliştirilen, Görüntü İşleme Yetenekleri Sağlayan Açık Kaynak Kodlu Bir Kütüphanedir
import ImageFilter
# import Pillow

from PIL import Image
Resim = Image.open("Resim2.jpg")
# Resim.show()

# Görüntüyü Döndürmek
# Resimi Kaç Derece Döndürmek İstiyorsak Onu Yazarız Ve Tekrardan Kaydederiz (Kaydederken İsim Değiştirilebilir)
# Resim.rotate(180).save("Rotate.jpg")

# Görüntüyü Çevirmek
# Yatay Eksende Döndür, Düşey Eksende Döndür
# Resim.transpose(Image.FLIP_LEFT_RIGHT).save("LR_Transpose.jpg")

# Küçük Resim Oluşturmak
# Resim.thumbnail((90, 60))
# Resim.save("Thumbnail.jpg")

# Renkler İle Oynamak
# R = Red
# G = Green
# B = Blue
# r,g,b = resim.split()
# Resim = Image.merge("RGB",(r,g,b))
# Resim.save("merge.jpg")

# Blur Efekti Eklemek
# Blurlu = Resim.filter(ImageFilter.BLUR)
# Blurlu.save("BLUR.jpeg")

# Yeniden Boyutlandırma
# Yeniboyut = Resim.resize((1000, 500))
# Yeniboyut.show()

# Resmin Boyutlarını Almak
Genislik, Yukseklik = Resim.size
g = Genislik / 3
y = Yukseklik / 3
print("Genişlik " + str(g) + "px")
print("Yükseklik " + str(y) + "px")

print("Tamamlandı")