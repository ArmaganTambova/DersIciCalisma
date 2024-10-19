import tkinter as tk

Adlar = []
Soyadlar = []
TelefonNumaralari = []
KimlikNumaralari = []

def BKontrol(OgrenciAdi, OgrenciSoyadi, OgrenciTelefon, OgrenciKimlik):
    if OgrenciAdi != "":
        if OgrenciSoyadi != "":
            if OgrenciTelefon != "":
                if OgrenciKimlik != "":
                    return True
                else:
                    Kontrol_LBL.place(x=830, y=175)
                    Kontrol_LBL.config(text="Bu Alan Boş Bırakılamaz", font="Arial 10", fg="red")
                    return False
            else:
                Kontrol_LBL.place(x=830, y=125)
                Kontrol_LBL.config(text="Bu Alan Boş Bırakılamaz", font="Arial 10", fg="red")
                return False
        else:
            Kontrol_LBL.place(x=830, y=75)
            Kontrol_LBL.config(text="Bu Alan Boş Bırakılamaz", font="Arial 10", fg="red")
            return False
    else:
        Kontrol_LBL.place(x=830, y=25)
        Kontrol_LBL.config(text="Bu Alan Boş Bırakılamaz", font="Arial 10", fg="red")
        return False

def Ekle():
    OgrenciAdi = OgrenciAdi_Entry.get()
    OgrenciSoyadi = OgrenciSoyadi_Entry.get()
    OgrenciTelefon = OgrenciTelefon_Entry.get()
    OgrenciKimlik = OgrenciKimlik_Entry.get()
    BoKontrol = BKontrol(OgrenciAdi, OgrenciSoyadi, OgrenciTelefon, OgrenciKimlik)
    if BoKontrol:
        TKontrol = TelefonNumaralari.__contains__(OgrenciTelefon)
        if not TKontrol:
            KKontrol = KimlikNumaralari.__contains__(OgrenciKimlik)
            if not KKontrol:
                Adlar.append(OgrenciAdi)
                Soyadlar.append(OgrenciSoyadi)
                TelefonNumaralari.append(OgrenciTelefon)
                KimlikNumaralari.append(OgrenciKimlik)
                Kontrol_LBL.place(x=300, y=225)
                Kontrol_LBL.config(text="Kayıt Başarılı", font="Arial 14", fg="green")
                Eklenecek = (OgrenciAdi + " " + OgrenciSoyadi)
                List_Listbox.insert(tk.END, Eklenecek)
                OgrenciAdi_Entry.delete(0, tk.END)
                OgrenciSoyadi_Entry.delete(0, tk.END)
                OgrenciTelefon_Entry.delete(0, tk.END)
                OgrenciKimlik_Entry.delete(0, tk.END)
            else:
                Kontrol_LBL.place(x=300, y=225)
                Kontrol_LBL.config(text="Bu Kimlik Numarası Sisteme Kayıtlı", font="Arial 14", fg="red")
        else:
            Kontrol_LBL.place(x=300, y=225)
            Kontrol_LBL.config(text="Bu Telefon Numarası Sisteme Kayıtlı", font="Arial 14", fg="red")

def Sil():
    Index = List_Listbox.curselection()
    List_Listbox.delete(tk.ACTIVE)
    Adlar.pop(Index)
    Soyadlar.pop(Index)
    TelefonNumaralari.pop(Index)
    KimlikNumaralari.pop(Index)
    Kontrol_LBL.place(x=300, y=225)
    Kontrol_LBL.config(text="Silme İşlemi Başarılı", font="Arial 14", fg="green")

def Incele():
    Goster = tk.Tk()
    Goster.geometry('650x650')
    Goster.title('Öğrenci İncele')
    Goster.tk_setPalette("#373735")

    Index = List_Listbox.curselection()

    ogrenciadi_lbl = tk.Label(Goster, text="Öğrenci Adı", font="Arial 14 bold", fg="white")
    ogrenciadi_lbl.place(x=125, y=25)
    OgrenciAd_LBL = tk.Label(Goster, text=Adlar[Index], font="Arial 14", fg="white")
    OgrenciAd_LBL.place(x=250, y=25)

    ogrencisoyadi_lbl = tk.Label(Goster, text="Öğrenci Soyadı", font="Arial 14 bold", fg="white")
    ogrencisoyadi_lbl.place(x=125, y=75)
    OgrenciSoyad_LBL = tk.Label(Goster, text=Soyadlar[Index], font="Arial 14", fg="white")
    OgrenciSoyad_LBL.place(x=250, y=25)

    ogrencitelefon_lbl = tk.Label(Goster, text="Öğrenci Telefon Numarası", font="Arial 14 bold", fg="white")
    ogrencitelefon_lbl.place(x=125, y=125)
    OgrenciTele_LBL = tk.Label(Goster, text=TelefonNumaralari[Index], font="Arial 14", fg="white")
    OgrenciTele_LBL.place(x=250, y=25)

    ogrencikimlik_lbl = tk.Label(Goster, text="Öğrenci Kimlik Numarası", font="Arial 14 bold", fg="white")
    ogrencikimlik_lbl.place(x=125, y=175)
    OgrenciKim_LBL = tk.Label(Goster, text=KimlikNumaralari[Index], font="Arial 14", fg="white")
    OgrenciKim_LBL.place(x=250, y=25)
    Goster.mainloop()

form = tk.Tk()
form.geometry('1000x450')
form.title('Kullanıcı Kayıt Formu')
form.tk_setPalette("#373735")

List_Listbox = tk.Listbox(font="Arial 14", bg="white", fg="black", borderwidth=0)
List_Listbox.place(x=10, y=10, width=250, height=430)

OgrenciAdi_LBL = tk.Label(text="Öğrenci Adı", font="Arial 14 bold", fg="white")
OgrenciAdi_LBL.place(x=275, y=25)
OgrenciAdi_Entry = tk.Entry(font="Arial 14", bg="white", fg="black")
OgrenciAdi_Entry.place(x=550, y=25, width=250, height=25)

OgrenciSoyadi_LBL = tk.Label(text="Öğrenci Soyadı", font="Arial 14 bold", fg="white")
OgrenciSoyadi_LBL.place(x=275, y=75)
OgrenciSoyadi_Entry = tk.Entry(font="Arial 14", bg="white", fg="black")
OgrenciSoyadi_Entry.place(x=550, y=75, width=250, height=25)

OgrenciTelefon_LBL = tk.Label(text="Öğrenci Telefon Numarası", font="Arial 14 bold", fg="white")
OgrenciTelefon_LBL.place(x=275, y=125)
OgrenciTelefon_Entry = tk.Entry(font="Arial 14", bg="white", fg="black")
OgrenciTelefon_Entry.place(x=550, y=125, width=250, height=25)

OgrenciKimlik_LBL = tk.Label(text="Öğrenci Kimlik Numarası", font="Arial 14 bold", fg="white")
OgrenciKimlik_LBL.place(x=275, y=175)
OgrenciKimlik_Entry = tk.Entry(font="Arial 14", bg="white", fg="black")
OgrenciKimlik_Entry.place(x=550, y=175, width=250, height=25)

Kontrol_LBL = tk.Label(text="...", font="Arial 14 bold", fg="white")
Kontrol_LBL.place(x=300, y=225)

Ekle_Button = tk.Button(text="Kayıt", font="Arial 14 bold", bg="white", fg="black", borderwidth=0, command=Ekle)
Ekle_Button.place(x=700, y=225, width=100, height=25)

Sil_Button = tk.Button(text="Sil", font="Arial 14 bold", bg="white", fg="black", borderwidth=0, command=Sil)
Sil_Button.place(x=700, y=275, width=100, height=25)

Incele_Button = tk.Button(text="İncele", font="Arial 14 bold", bg="white", fg="black", borderwidth=0, command=Incele)
Incele_Button.place(x=700, y=325, width=100, height=25)
form.mainloop()