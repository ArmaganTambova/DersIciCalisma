import tkinter as tk

KDV = ["KDV Dahil", "KDV Dahil Değil"]
Sayilar = ["1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "."]

def SKontrol():
    Bildirim_LBL.place(x=75, y=310)
    Bildirim_LBL.config(text="...", font="Arial 14", fg="white")
    Fiyat = Fiyat_Entry.get()
    if Fiyat != "":
        i = 0
        k = 0
        while i < len(Fiyat):
            if Sayilar.__contains__(Fiyat[i]):
                k += 1
            i += 1
        if k == len(Fiyat):
            Bildirim_LBL.place(x=75, y=310)
            Bildirim_LBL.config(text="Hesaplanıyor...", font="Arial 14", fg="green")
            Hesapla(Fiyat)
        else:
            Bildirim_LBL.place(x=345, y=10)
            Bildirim_LBL.config(text="Sadece Sayı Giriniz", font="Arial 10", fg="red")
    else:
        Bildirim_LBL.place(x=345, y=10)
        Bildirim_LBL.config(text="Bu Alan Boş Bırakılamaz", font="Arial 10", fg="red")

def Hesapla(Fiyat):
    Fiyat_Entry.delete(0, tk.END)
    Fiyat = float(Fiyat)
    Kdv = Fiyat * (20 / 100)
    if Secim.get() == "KDV Dahil":
        FiyatBilgi_LBL.config(text="Fiyat = " + str(Fiyat))
        KDVBilgi_LBL.config(text="KDV = " + str(Kdv))
        KDVDahilBilgi_LBL.config(text="KDV Dahil = " + str((Fiyat + Kdv)))
    elif Secim.get() == "KDV Dahil Değil":
        FiyatBilgi_LBL.config(text="Fiyat = " + str(Fiyat))
        KDVBilgi_LBL.config(text="KDV = " + str(Kdv))
        KDVDahilBilgi_LBL.config(text="KDV Dahil Değil = " + str((Fiyat - Kdv)))
    else:
        Bildirim_LBL.place(x=75, y=310)
        Bildirim_LBL.config(text="Belirlenemeyen Bir Sebepten İşleminiz Gerçekleşemiyor", font="Arial 14", fg="red")

Pencere = tk.Tk()
Pencere.geometry('500x350')
Pencere.tk_setPalette("#373735")
Pencere.title('KDV Hesaplama')

Fiyat_LBL = tk.Label(text="Fiyat:", font="Arial 14", fg="white")
Fiyat_LBL.place(x=10, y=10)
Fiyat_Entry = tk.Entry(font="Arial 14", bg="white", fg="black")
Fiyat_Entry.place(x=75, y=10, width=250, height=25)

Secim = tk.StringVar()
Secim.set(KDV[0])
KDV_OP = tk.OptionMenu(Pencere, Secim, *KDV)
KDV_OP.place(x=75, y=60, width=250, height=25)

Hesapla_BUTTON = tk.Button(text="Hesapla", bg="white", fg="black", borderwidth=4, command=SKontrol)
Hesapla_BUTTON.place(x=75, y=110, width=250, height=25)

FiyatBilgi_LBL = tk.Label(text="Fiyat", font="Arial 14", bg="white", fg="black")
FiyatBilgi_LBL.place(x=75, y=160, width=250, height=25)

KDVBilgi_LBL = tk.Label(text="KDV", font="Arial 14", bg="white", fg="black")
KDVBilgi_LBL.place(x=75, y=210, width=250, height=25)

KDVDahilBilgi_LBL = tk.Label(text="KDV Dahil", font="Arial 14", bg="white", fg="black")
KDVDahilBilgi_LBL.place(x=75, y=260, width=250, height=25)

Bildirim_LBL = tk.Label(text="...", font="Arial 14", fg="white")
Bildirim_LBL.place(x=75, y=310)
Pencere.mainloop()