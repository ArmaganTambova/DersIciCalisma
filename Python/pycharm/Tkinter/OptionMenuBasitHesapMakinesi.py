import tkinter as tk

Islemler = ["Toplama", "Çıkartma", "Çarpma", "Bölme"]
Sayilar = ["1", "2", "3", "4", "5", "6", "7", "8", "9", "0"]

def SayiKontrol():
    Sayi1 = Sayi1_Entry.get()
    Sayi2 = Sayi2_Entry.get()
    Bi = 0
    BiK = 0
    Ki = 0
    KiK = 0
    if Sayi1 != "":
        if Sayi2 != "":
            while Bi < len(Sayi1):
                if Sayilar.__contains__(Sayi1[Bi]):
                    BiK += 1
                Bi += 1
            if BiK == len(Sayi1):
                while Ki < len(Sayi2):
                    if Sayilar.__contains__(Sayi2[Ki]):
                        KiK += 1
                    Ki += 1
                if KiK == len(Sayi2):
                    Bildirim_LBL.place(x=10, y=210)
                    Bildirim_LBL.config(text="...", font="Arial 14", fg="white")
                    D = True
                else:
                    Bildirim_LBL.place(x=350, y=50)
                    Bildirim_LBL.config(text="Lütfen Sadece Sayı Giriniz", font="Arial 14", fg="red")
                    D = False
            else:
                Bildirim_LBL.place(x=350, y=10)
                Bildirim_LBL.config(text="Lütfen Sadece Sayı Giriniz", font="Arial 14", fg="red")
                D = False
            if D:
                Islem(Sayi1, Sayi2)
            else:
                Bildirim_LBL.place(x=10, y=210)
                Bildirim_LBL.config(text="İşleminiz Gerçekleşememektedir", font="Arial 14", fg="red")
        else:
            Bildirim_LBL.place(x=350, y=50)
            Bildirim_LBL.config(text="Bu Alan Boş Bırakılamaz", font="Arial 14", fg="red")
    else:
        Bildirim_LBL.place(x=350, y=10)
        Bildirim_LBL.config(text="Bu Alan Boş Bırakılamaz", font="Arial 14", fg="red")

def Islem(Sayi1, Sayi2):
    Sayi1 = int(Sayi1)
    Sayi2 = int(Sayi2)
    if Secili.get() == "Toplama":
        Sonuc = Sayi1 + Sayi2
        Sonuc_LBL.config(text="Sonuç = " + str(Sonuc))
    elif Secili.get() == "Çıkartma":
        Sonuc = Sayi1 - Sayi2
        Sonuc_LBL.config(text="Sonuç = " + str(Sonuc))
    elif Secili.get() == "Çarpma":
        Sonuc = Sayi1 * Sayi2
        Sonuc_LBL.config(text="Sonuç = " + str(Sonuc))
    elif Secili.get() == "Bölme":
        Sonuc = Sayi1 / Sayi2
        Sonuc_LBL.config(text="Sonuç = " + str(Sonuc))
    else:
        Bildirim_LBL.place(x=10, y=210)
        Bildirim_LBL.config(text="Belirlenemeyen Bir Sebepten Dolayı İşleminiz Gerçekleşememektedir", font="Arial 14", fg="red")

Pencere = tk.Tk()
Pencere.geometry('570x250')
Pencere.title('Basit Hesap Makinesi')
Pencere.tk_setPalette("#373735")

Sayi1_LBL = tk.Label(text="Sayı 1:", font="Arial 14", fg="white")
Sayi1_LBL.place(x=10, y=10)
Sayi1_Entry = tk.Entry(font="Arial 14", bg="white", fg="black")
Sayi1_Entry.place(x=75, y=10, width=250, height=25)

Sayi2_LBL = tk.Label(text="Sayı 2:", font="Arial 14", fg="white")
Sayi2_LBL.place(x=10, y=50)
Sayi2_Entry = tk.Entry(font="Arial 14", bg="white", fg="black")
Sayi2_Entry.place(x=75, y=50, width=250, height=25)

Islem_LBL = tk.Label(text="İşlem Seçiniz:", font="Arial 14", fg="white")
Islem_LBL.place(x=10, y=90)
Secili = tk.StringVar()
Secili.set(Islemler[0])
Islemler_OP = tk.OptionMenu(Pencere, Secili, *Islemler)
Islemler_OP.place(x=145, y=90, width=150, height=25)

Hesapla_BUTTON = tk.Button(text="Hesapla", font="Arial 14", bg="white", fg="black", borderwidth=0, command=SayiKontrol)
Hesapla_BUTTON.place(x=145, y=130, width=150, height=25)

Sonuc_LBL = tk.Label(text="Sonuç", font="Arial 14", fg="white")
Sonuc_LBL.place(x=10, y=170)

Bildirim_LBL = tk.Label(text="...", font="Arial 14", fg="white")
Bildirim_LBL.place(x=10, y=210)
Pencere.mainloop()