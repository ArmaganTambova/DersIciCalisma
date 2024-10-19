import turtle

Kalem = turtle.Turtle()
Kalem.speed(0) # Çizme İşleminin Hızını Ayarlar
Kalem.color("green", "white")

def Daire(yaricap):
    Kalem.circle(yaricap)

def Ciz(Tur, Uzunluk, DonmeAci):
    for i in range(Tur):
        Daire(Uzunluk)
        Kalem.right(DonmeAci)

Ciz(300, 100, 13)
turtle.mainloop()