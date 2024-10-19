import tkinter as tk

OyuncuAdlariA = []
OyuncuSoyadlariA = []
OyuncuNumaralariA = []
OyuncuAdlariB = []
OyuncuSoyadlariB = []
OyuncuNumaralariB = []

def BoslukKontrol(OyuncuAdi, OyuncuSoyadi, OyuncuNumarasi):
    if OyuncuAdi != "":
        if OyuncuSoyadi != "":
            if OyuncuNumarasi != "":
                return True
            else:
                Kontrol_LBL.place(x=550, y=150)
                Kontrol_LBL.config(text="Bu Alan Boş Bırakılamaz", font="Arial 10 bold", fg="red")
                return False
        else:
            Kontrol_LBL.place(x=550, y=100)
            Kontrol_LBL.config(text="Bu Alan Boş Bırakılamaz", font="Arial 10 bold", fg="red")
            return False
    else:
        Kontrol_LBL.place(x=550, y=50)
        Kontrol_LBL.config(text="Bu Alan Boş Bırakılamaz", font="Arial 10 bold", fg="red")
        return False

def OyuncuKayitA():
    OyuncuAdi = OyuncuAdi_Entry.get()
    OyuncuSoyadi = OyuncuSoyadi_Entry.get()
    OyuncuNumarasi = OyuncuNumarasi_Entry.get()
    BKontrol = BoslukKontrol(OyuncuAdi, OyuncuSoyadi, OyuncuNumarasi)
    if BKontrol:
        OyuncuKayitKontrol = OyuncuNumaralariA.__contains__(OyuncuNumarasi)
        if not OyuncuKayitKontrol:
            OyuncuAdlariA.append(OyuncuAdi)
            OyuncuSoyadlariA.append(OyuncuSoyadi)
            OyuncuNumaralariA.append(OyuncuNumarasi)
            Kontrol_LBL.place(x=50, y=250)
            Kontrol_LBL.config(text="Oyuncu Kayıt İşlemi Başarıyla Gerçekleşmiştir", font="Arial 14 bold", fg="green")
        else:
            Kontrol_LBL.place(x=50, y=250)
            Kontrol_LBL.config(text="Bu Oyuncu Numarası Daha Önce Başka Bir Oyuncu Tarafından Alınmış", font="Arial 10 bold", fg="red")
def OyuncuKayitB():
    OyuncuAdi = OyuncuAdi_Entry.get()
    OyuncuSoyadi = OyuncuSoyadi_Entry.get()
    OyuncuNumarasi = OyuncuNumarasi_Entry.get()
    BKontrol = BoslukKontrol(OyuncuAdi, OyuncuSoyadi, OyuncuNumarasi)
    if BKontrol:
        OyuncuKayitKontrol = OyuncuNumaralariB.__contains__(OyuncuNumarasi)
        if not OyuncuKayitKontrol:
            OyuncuAdlariB.append(OyuncuAdi)
            OyuncuSoyadlariB.append(OyuncuSoyadi)
            OyuncuNumaralariB.append(OyuncuNumarasi)
            Kontrol_LBL.place(x=50, y=250)
            Kontrol_LBL.config(text="Oyuncu Kayıt İşlemi Başarıyla Gerçekleşmiştir", font="Arial 14 bold", fg="green")
        else:
            Kontrol_LBL.place(x=50, y=250)
            Kontrol_LBL.config(text="Bu Oyuncu Numarası Daha Önce Başka Bir Oyuncu Tarafından Alınmış", font="Arial 10 bold", fg="red")

form = tk.Tk()
form.geometry('750x300')
form.title('Takım Oyuncu Kayıt Formu')
form.tk_setPalette("#373735")

OyuncuAdi_LBL = tk.Label(text="Oyuncu Adı", font="Arial 14 bold", fg="white")
OyuncuAdi_LBL.place(x=50, y=50)
OyuncuAdi_Entry = tk.Entry(font="Arial 14 bold", bg="white", fg="black")
OyuncuAdi_Entry.place(x=250, y=50, height=25, width=250)

OyuncuSoyadi_LBL = tk.Label(text="Oyuncu Soyadı", font="Arial 14 bold", fg="white")
OyuncuSoyadi_LBL.place(x=50, y=100)
OyuncuSoyadi_Entry = tk.Entry(font="Arial 14 bold", bg="white", fg="black")
OyuncuSoyadi_Entry.place(x=250, y=100, height=25, width=250)

OyuncuNumarasi_LBL = tk.Label(text="Oyuncu Numarası", font="Arial 14 bold", fg="white")
OyuncuNumarasi_LBL.place(x=50, y=150)
OyuncuNumarasi_Entry = tk.Entry(font="Arial 14 bold", bg="white", fg="black")
OyuncuNumarasi_Entry.place(x=250, y=150, height=25, width=250)

Kontrol_LBL = tk.Label(text="...", font="Arial 14 bold", fg="white")
Kontrol_LBL.place(x=50, y=250)

ATakimi_Button = tk.Button(text="A Takımı", font="Arial 14 bold", fg="black", bg="white", borderwidth=0, command=OyuncuKayitA)
ATakimi_Button.place(x=100, y=200, height=25, width=100)

BTakimi_Button = tk.Button(text="B Takımı", font="Arial 14 bold", fg="black", bg="white", borderwidth=0, command=OyuncuKayitB)
BTakimi_Button.place(x=400, y=200, height=25, width=100)
form.mainloop()