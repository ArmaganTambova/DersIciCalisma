import turtle

# Ekranı Ayarlama
Ekran = turtle.Screen()
Ekran.bgcolor("Lightgreen")

# Çerçeve Çizdirme
Cerceve = turtle.Turtle()
Cerceve.speed(5)
Cerceve.penup()
Cerceve.setposition(-300, -300) # Kalemin Pozisyonunu Ayarla
Cerceve.pendown()
Cerceve.pensize(3)
for i in range(4):
    Cerceve.forward(600)
    Cerceve.left(90)
Cerceve.hideturtle()

# Oyuncu Oluşturma
Oyuncu = turtle.Turtle()
Oyuncu.color("purple")
Oyuncu.shape("triangle")

# Hareket Verme
Hiz = 1

# Döndürme Metodları
def Soladon():
    Oyuncu.left(30)

def Sagadon():
    Oyuncu.right(30)

def HiziArttir():
    global Hiz
    if Hiz <= 0:
        Ekran.bgcolor("Red")
        Hiz += 1
    elif Hiz >= 1:
        Ekran.bgcolor("Lightgreen")
        Hiz += 1
    else:
        Ekran.bgcolor("Lightgreen")
        Hiz += 1

def HiziAzalt():
    global Hiz
    if Hiz == 1:
        Ekran.bgcolor("Red")
        Hiz -= 1
    else:
        Hiz -= 1

def Durdur():
    global Hiz
    Ekran.bgcolor("Red")
    Hiz = 0

# Klavye Kontrolleri
turtle.listen() # Olayları Dinler
turtle.onkey(Soladon, "Left") # Klavyeden Butona Basıldığında Sola Dönme
turtle.onkey(Sagadon, "Right") # Klavyeden Butona Basıldığında Sağa Dönme
turtle.onkey(HiziArttir, "Up") # Klavyeden Butona Basıldığında Hızı Arttırma Dönme
turtle.onkey(HiziAzalt, "Down") # Klavyeden Butona Basıldığında Hızı Azaltma Dönme
turtle.onkey(Durdur, "Control_L") # Klavyeden Butona Basıldığında Oyuncuyu Durdurma Dönme

while True:
    Oyuncu.forward(Hiz)
    # Duvardan Sekme
    if Oyuncu.xcor() > 300 or Oyuncu.xcor() < -300:
        Oyuncu.right(120)
    if Oyuncu.ycor() > 300 or Oyuncu.ycor() < -300:
        Oyuncu.right(120)
Ekran.mainloop()