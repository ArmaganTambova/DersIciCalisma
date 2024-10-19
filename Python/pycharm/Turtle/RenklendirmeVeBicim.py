import turtle

ok = turtle.Turtle()
ok.screen.bgcolor("black") # Pencere Arkaplan Rengini Ayarlar
ok.color("white")
ok.setheading(90) # Başlangıç Yönünü Ayarlar
ok.shape("turtle") # turtle = Tospaa, square = Kare, circle = Daire
ok.shapesize(3) # ok.shape Boyutunu Ayarlar
ok.begin_fill() # Boşluğu Doldurur
ok.circle(100) # Daire Çizer
ok.end_fill() # ok.begin_fill Çalışması İçin Gerekli
ok.hideturtle() # Tospaa'yı Sakla
turtle.mainloop()