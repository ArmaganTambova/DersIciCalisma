import turtle

def KareCizim(uzunluk):
    for i in range(4):
        ok.forward(uzunluk)
        ok.left(90)

def UcgenCizim(uzunluk):
    for i in range(3):
        ok.forward(uzunluk)
        ok.left(120)

def AltigenCizim(uzunluk):
    for i in range(6):
        ok.forward(uzunluk)
        ok.left(60)

ok = turtle.Turtle()
ok.color("red", "yellow")
KareCizim(200)

ok.penup()
ok.forward(200)
ok.pendown()

UcgenCizim(200)

ok.penup()
ok.forward(200)
ok.pendown()

AltigenCizim(200)
turtle.mainloop()