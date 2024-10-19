import turtle

def CokgenCiz(Uzunluk, KenarSayisi):
    if KenarSayisi <= 2:
        Kalem.right(90)
        Kalem.forward(100)
        Kalem.backward(100)
        Kalem.left(90)
        i = 0
        while i <= 180:
            Kalem.forward(1)
            Kalem.right(1.1)
            i += 1

    else:
        for i in range(KenarSayisi):
            Aci = 360 / KenarSayisi
            Kalem.forward(Uzunluk)
            Kalem.left(Aci)

Kalem = turtle.Turtle()
Kalem.speed(0)
Kalem.screen.bgcolor("black")
Kalem.color("red", "white")
CokgenCiz(100, 2)

turtle.mainloop()