import tkinter as tk
Ilceler = ["Alpu", "Beylikova", "Çifteler", "Günyüzü", "Han", "İnönü", "Mahmudiye", "Mihalgazi", "Mihalıççık", "Tepebaşı", "Sarıcakaya", "Seyitgazi", "Sivrihisar", "Odunpazarı"]

def SecilenGetir():
    Ekran_LBL.config(text="Seçilen = " + Secili.get())

pencere = tk.Tk()
pencere.geometry('350x250')
pencere.title('Option Menü Kullanımı')
pencere.tk_setPalette("#373735")

Ilce_LBL = tk.Label(text="İlçeler")
Ilce_LBL.place(x=10, y=15)

Secili = tk.StringVar()
# Secili.set("Odunpazarı")
Secili.set(Ilceler[0])
Ilceler_OP = tk.OptionMenu(pencere, Secili, *Ilceler)
Ilceler_OP.place(x=50, y=15, height=25)

Getir_BUTTON = tk.Button(text="Getir", command=SecilenGetir)
Getir_BUTTON.place(x=175, y=15, width=50, height=25)

Ekran_LBL = tk.Label(text="Seçilen")
Ekran_LBL.place(x=10, y=50)
pencere.mainloop()