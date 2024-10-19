import tkinter as tk
KullaniciAdlari = ["ArmaganT"]
Sifreler = ["1234"]
EPostalar = ["armagan@gmail.com"]
Adlar = ["Armağan"]
Soyadlar = ["Tambova"]

def BKontrol(KullaniciAdi, Sifre, EPosta, Ad, Soyad):
    if KullaniciAdi != "":
        if Sifre != "":
            if EPosta != "":
                if Ad != "":
                    if Soyad != "":
                        return True
                    else:
                        Kontol_LBL.place(x=550, y=250)
                        Kontol_LBL.config(text="Bu Alan Boş Bırakılamaz", font="Arial 14 bold", fg="red")
                        return False
                else:
                    Kontol_LBL.place(x=550, y=200)
                    Kontol_LBL.config(text="Bu Alan Boş Bırakılamaz", font="Arial 14 bold", fg="red")
                    return False
            else:
                Kontol_LBL.place(x=550, y=150)
                Kontol_LBL.config(text="Bu Alan Boş Bırakılamaz", font="Arial 14 bold", fg="red")
                return False
        else:
            Kontol_LBL.place(x=550, y=100)
            Kontol_LBL.config(text="Bu Alan Boş Bırakılamaz", font="Arial 14 bold", fg="red")
            return False
    else:
        Kontol_LBL.place(x=550, y=50)
        Kontol_LBL.config(text="Bu Alan Boş Bırakılamaz", font="Arial 14 bold", fg="red")
        return False

def KKaydol():
    KullaniciAdi = KullaniciAdi_Entry.get()
    Sifre = Sifre_Entry.get()
    EPosta = EPosta_Entry.get()
    Ad = Ad_Entry.get()
    Soyad = Soyad_Entry.get()
    Bkontrol = BKontrol(KullaniciAdi, Sifre, EPosta, Ad, Soyad)
    if Bkontrol:
        KullaniciAdiKontrol = KullaniciAdlari.__contains__(KullaniciAdi)
        if not KullaniciAdiKontrol:
            EPostaKontrol = EPostalar.__contains__(EPosta)
            if not EPostaKontrol:
                EPostaSembol = ["@", "."]
                i = 0
                k = 0
                while i < len(EPosta):
                    if EPostaSembol.__contains__(EPosta[i]):
                        k += 1
                    i += 1
                if k == 2:
                    KullaniciAdlari.append(KullaniciAdi)
                    Sifreler.append(Sifre)
                    EPostalar.append(EPosta)
                    Adlar.append(Ad)
                    Soyadlar.append(Soyad)
                    Kontol_LBL.place(x=150, y=350)
                    Kontol_LBL.config(text="Kayıt Başarıyla Tamamlandı", font="Arial 14 bold", fg="green")
                else:
                    Kontol_LBL.place(x=150, y=350)
                    Kontol_LBL.config(text="E-Postanızda @ ve . Sembollerinin Bulunması Zorunludur", font="Arial 14 bold", fg="red")
            else:
                Kontol_LBL.place(x=150, y=350)
                Kontol_LBL.config(text="Bu E-Posta Sisteme Daha Önce Kayıt Edilmiş", font="Arial 14 bold", fg="red")
        else:
            Kontol_LBL.place(x=150, y=350)
            Kontol_LBL.config(text="Bu Kullanıcı Adı Bir Başkası Tarafından Alınmış", font="Arial 14 bold", fg="red")


form = tk.Tk()
form.geometry('850x450')
form.title('Kullanıcı Kayıt Formu')
form.tk_setPalette("#373735")

KullaniciAdi_LBL = tk.Label(text="Kullanıcı Adı", font="Arial 14 bold", fg="white")
KullaniciAdi_LBL.place(x=50, y=50)
KullaniciAdi_Entry = tk.Entry(font="Arial 14 bold", bg="white", fg="black")
KullaniciAdi_Entry.place(x=250, y=50, height=25, width=250)

Sifre_LBL = tk.Label(text="Şifre", font="Arial 14 bold", fg="white")
Sifre_LBL.place(x=50, y=100)
Sifre_Entry = tk.Entry(font="Arial 14 bold", bg="white", fg="black")
Sifre_Entry.place(x=250, y=100, height=25, width=250)

EPosta_LBL = tk.Label(text="E-Posta", font="Arial 14 bold", fg="white")
EPosta_LBL.place(x=50, y=150)
EPosta_Entry = tk.Entry(font="Arial 14 bold", bg="white", fg="black")
EPosta_Entry.place(x=250, y=150, height=25, width=250)

Ad_LBL = tk.Label(text="Ad", font="Arial 14 bold", fg="white")
Ad_LBL.place(x=50, y=200)
Ad_Entry = tk.Entry(font="Arial 14 bold", bg="white", fg="black")
Ad_Entry.place(x=250, y=200, height=25, width=250)

Soyad_LBL = tk.Label(text="Soyad", font="Arial 14 bold", fg="white")
Soyad_LBL.place(x=50, y=250)
Soyad_Entry = tk.Entry(font="Arial 14 bold", bg="white", fg="black")
Soyad_Entry.place(x=250, y=250, height=25, width=250)

Kontol_LBL = tk.Label(text="...", font="Arial 14 bold", fg="white")
Kontol_LBL.place(x=150, y=350)

Kaydol_BUTTON = tk.Button(text="Kaydol", font="Arial 14 bold", bg="white", fg="black", borderwidth=0, command=KKaydol)
Kaydol_BUTTON.place(x=500, y=300, height=25, width=100)
form.mainloop()