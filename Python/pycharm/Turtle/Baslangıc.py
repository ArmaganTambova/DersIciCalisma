import turtle

ok = turtle.Turtle()
ok.color("red", "yellow") # Çizginin ve Okun Rengini Ayarlar
# ok.pensize(3)

for i in range(4):
    ok.forward(100)
    ok.left(90)

ok.penup() # Kalemi Kaldır
ok.forward(200)
ok.pendown() # Kalemi Yerleştir

for i in range(3):
    ok.forward(100)
    ok.left(120)
turtle.mainloop()
# turtle.forward() Fonksiyonu İleriye Doğru Parantez İçerisine Yazılan Pixel Değerine Çizgi Çizer
# turtle.backward() Fonksiyonu Geriye Doğru Parantez İçerisine Yazılan Pixel Değerine Çizgi Çizer
# turtle.left() Fonksiyonu Sola Doğru Parantez İçerisine Yazılan Açı Değeri Kadar Döner
# turtle.right() Fonksiyonu Sağa Doğru Parantez İçerisine Yazılan Açı Değeri Kadar Döner
# turtle.pensize() Fonksiyonu Çizme İşlemini Yapan Kalemin Kalınlığını Ayarlar