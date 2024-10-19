import tkinter as tk
import turtle

def KareCiz():
    Uzunluk = int(Uzunluk_ENTRY.get())
    if Uzunluk >= 50 and Uzunluk <= 250:
        Bildirim_LABEL.config(text="Çiziliyor...", fg="green")
        turtle.clearscreen()
        Ok = turtle.Turtle()
        Ok.pensize(3)
        for i in range(4):
            Ok.forward(Uzunluk)
            Ok.left(90)
        Ok.hideturtle()
        Ok.screen.mainloop()
    elif Uzunluk > 250:
        Bildirim_LABEL.config(text="Uzunluk 250 Pixelden Fazla Olamaz", fg="red")
    else:
        Bildirim_LABEL.config(text="Uzunluk 50 Pixelden Kısa Olamaz", fg="red")

def UcgenCiz():
    Uzunluk = int(Uzunluk_ENTRY.get())
    if Uzunluk >= 50 and Uzunluk <= 250:
        Bildirim_LABEL.config(text="Çiziliyor...", fg="green")
        turtle.clearscreen()
        Ok = turtle.Turtle()
        Ok.pensize(3)
        for i in range(3):
            Ok.forward(Uzunluk)
            Ok.left(120)
        Ok.hideturtle()
        Ok.screen.mainloop()
    elif Uzunluk > 250:
        Bildirim_LABEL.config(text="Uzunluk 250 Pixelden Fazla Olamaz", fg="red")
    else:
        Bildirim_LABEL.config(text="Uzunluk 50 Pixelden Kısa Olamaz", fg="red")

def DaireCiz():
    Yaricap = int(Uzunluk_ENTRY.get())
    if Yaricap >= 50 and Yaricap <= 250:
        Bildirim_LABEL.config(text="Çiziliyor...", fg="green")
        turtle.clearscreen()
        Ok = turtle.Turtle()
        Ok.begin_fill()
        Ok.fillcolor("red")
        Ok.circle(Yaricap)
        Ok.end_fill()
        Ok.hideturtle()
        Ok.screen.mainloop()
    elif Yaricap > 250:
        Bildirim_LABEL.config(text="Yarıçap 250den Fazla Olamaz", fg="red")
    else:
        Bildirim_LABEL.config(text="Yarıçap 50den Az Olamaz", fg="red")

Window = tk.Tk()
Window.title('Seçim Yapınız')
Window.geometry('560x175')
Window.tk_setPalette('#373735')

Kare_BUTTON = tk.Button(text="Kare Çiz", font="Arial 14", fg="black", bg="white", borderwidth=1, command=KareCiz)
Kare_BUTTON.place(x=10, y=10, width=150, height=25)

Ucgen_BUTTON = tk.Button(text="Üçgen Çiz", font="Arial 14", fg="black", bg="white", borderwidth=1, command=UcgenCiz)
Ucgen_BUTTON.place(x=10, y=50, width=150, height=25)

Daire_BUTTON = tk.Button(text="Daire Çiz", font="Arial 14", fg="black", bg="white", borderwidth=1, command=DaireCiz)
Daire_BUTTON.place(x=10, y=90, width=150, height=25)

Uzunluk_LABEL = tk.Label(text="Uzunluk / Yarıçap:", font="Arial 14", fg="white")
Uzunluk_LABEL.place(x=175, y=10)
Uzunluk_ENTRY = tk.Entry(font="Arial 14", fg="black", bg="white")
Uzunluk_ENTRY.place(x=350, y=10, width=200, height=25)

Bildirim_LABEL = tk.Label(text="...", font="Arial 14", fg="white")
Bildirim_LABEL.place(x=10, y=150)
Window.mainloop()