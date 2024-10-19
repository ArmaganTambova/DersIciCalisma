import tkinter as tk
#import messagebox as msg
Adlar = []
Soyadlar = []
KimlikNumaralari = []
Ilceler = []
Okullar = []
Cinsiyetler = []
Siniflar = []

KontrolK = ["1", "2", "3", "4", "5", "6", "7", "8", "9", "0"]

def BKontrol(Isim, Soyad, KimlikNo, Okul):
    if Isim != "":
        if Soyad != "":
            if KimlikNo != "":
                if Okul != "":
                    return True
                else:
                    Kontrol_LBL.config(text="Okul Hanesi Boş Bırakılamaz", fg="red")
                    return False
            else:
                Kontrol_LBL.config(text="Kimlik Numarası Hanesi Boş Bırakılamaz", fg="red")
                return False
        else:
            Kontrol_LBL.config(text="Soyad Hanesi Boş Bırakılamaz", fg="red")
            return False
    else:
        Kontrol_LBL.config(text="İsim Hanesi Boş Bırakılamaz", fg="red")
        return False

def Kaydet():
    Isim = Isim_ENTRY.get()
    Soyad = Soyad_ENTRY.get()
    KimlikNo = KimlikNo_ENTRY.get()
    Ilce = Secili1.get()
    Okul = Okul_ENTRY.get()
    Cinsiyet = Secili2.get()
    Sinif = Secili3.get()

    if BKontrol(Isim, Soyad, KimlikNo, Okul):
        if len(KimlikNo) == 11:
            i = 0
            k = 0
            while i < len(KimlikNo):
                if KontrolK.__contains__(KimlikNo[i]):
                    k += 1
                i += 1
            if k == 11:
                Adlar.append(Isim)
                Soyadlar.append(Soyad)
                KimlikNumaralari.append(KimlikNo)
                Ilceler.append(Ilce)
                Okullar.append(Okul)
                Cinsiyetler.append(Cinsiyet)
                Siniflar.append(Sinif)

                Eklenecek = str(Isim + " " + Soyad + " / " + Ilce)
                Listbox_LISTBOX.insert(tk.END, Eklenecek)

                Isim_ENTRY.delete(0, tk.END)
                Soyad_ENTRY.delete(0, tk.END)
                KimlikNo_ENTRY.delete(0, tk.END)
                Okul_ENTRY.delete(0, tk.END)
                Secili1.set(IlcelerS[0])
                Secili2.set(CinsiyetlerS[0])
                Secili3.set(SiniflarS[0])
                Kontrol_LBL.config(text="Başarıyla Kaydedildi", fg="green")
            else:
                Kontrol_LBL.config(text="Kimlik Numaranızı Kontrol Ediniz", fg="red")
        else:
            Kontrol_LBL.config(text="Kimlik 11 Haneden Oluşmalıdır", fg="red")

def Temizle():
    Isim_ENTRY.delete(0, tk.END)
    Soyad_ENTRY.delete(0, tk.END)
    KimlikNo_ENTRY.delete(0, tk.END)
    Okul_ENTRY.delete(0, tk.END)
    Secili1.set(IlcelerS[0])
    Secili2.set(CinsiyetlerS[0])
    Secili3.set(SiniflarS[0])
    Kontrol_LBL.config(text="Temizlendi", fg="green")

def Sil():
    Index = Listbox_LISTBOX.curselection()
    Listbox_LISTBOX.delete(tk.ACTIVE)
    Adlar.pop(Index)
    Soyadlar.pop(Index)
    KimlikNumaralari.pop(Index)
    Ilceler.pop(Index)
    Okullar.pop(Index)
    Cinsiyetler.pop(Index)
    Siniflar.pop(Index)
    Kontrol_LBL.config(text="Öğrenci Kaydı Silindi", fg="red")

def Incele():
    Index = Listbox_LISTBOX.curselection()
    InceleForm = tk.Tk()
    InceleForm.geometry('600x600')
    InceleForm.title('İnceleme Ekranı')
    InceleForm.tk_setPalette('#373735')
    Baslik_Incele = tk.Label(InceleForm, text="İnceleme Ekranı", font="Arial 12 bold", fg="white", bg="#E43755")
    Baslik_Incele.place(x=0, y=0, width=600, height=25)

    Isim = str(Index)
    Soyad = Soyadlar[0]
    KimlikNo = KimlikNumaralari[0]
    Ilce = Ilceler[0]
    Okul = Okullar[0]
    Cinsiyet = Cinsiyetler[0]
    Sinif = Siniflar[0]

    Isim_LABEL_Incele = tk.Label(InceleForm, text="Öğrenci Adı: " + Isim)
    Isim_LABEL_Incele.place(x=10, y=50)

    Soyad_LABEL_Incele = tk.Label(InceleForm, text="Öğrenci Soyadı: " + Soyad)
    Soyad_LABEL_Incele.place(x=10, y=100)

    KimlikNo_LABEL_Incele = tk.Label(InceleForm, text="Öğrenci Kimlik Numarası: " + KimlikNo)
    KimlikNo_LABEL_Incele.place(x=10, y=150)

    Ilce_LABEL_Incele = tk.Label(InceleForm, text="Öğrencinin Bulunduğu İlçe: " + Ilce)
    Ilce_LABEL_Incele.place(x=10, y=200)

    Okul_LABEL_Incele = tk.Label(InceleForm, text="Öğrencinin Okulu: " + Okul)
    Okul_LABEL_Incele.place(x=310, y=50)

    Cinsiyet_LABEL_Incele = tk.Label(InceleForm, text="Öğrencinin Cinsiyeti: " + Cinsiyet)
    Cinsiyet_LABEL_Incele.place(x=310, y=100)

    Sinif_LABEL_Incele = tk.Label(InceleForm, text="Öğrencinin Sınıf Düzeyi: " + Sinif)
    Sinif_LABEL_Incele.place(x=310, y=150)
    InceleForm.mainloop()


IlcelerS = ["Alpu", "Beylikova", "Çifteler", "Günyüzü", "Han", "İnönü", "Mahmudiye", "Mihalgazi", "Mihalıççık", "Tepebaşı", "Sarıcakaya", "Seyitgazi", "Sivrihisar", "Odunpazarı"]
CinsiyetlerS = ["Erkek", "Kadın"]
SiniflarS = ["9", "10", "11", "12"]
Form = tk.Tk()
Form.geometry('1200x600')
Form.title('Kayıt Sistemi Uygulaması')
Form.tk_setPalette('#373735')
Baslik = tk.Label(text="Ders İçi Kimlik Sistemi", font="Arial 12 bold", fg="white", bg="#E43755")
Baslik.place(x=0, y=0, width=1200, height=25)
Cikis_BUTTON = tk.Button(text="Çıkış", font="Arial 10", fg="black", bg="white", borderwidth=1, command=quit)
Cikis_BUTTON.place(x=1075, y=2, width=100, height=21)

Isim_LABEL = tk.Label(text="İsim:", font="Arial 14", fg="white")
Isim_LABEL.place(x=10, y=50)
Isim_ENTRY = tk.Entry(font="Arial 14", fg="black", bg="white")
Isim_ENTRY.place(x=100, y=50, width=250, height=25)

Soyad_LABEL = tk.Label(text="Soyad:", font="Arial 14", fg="white")
Soyad_LABEL.place(x=10, y=100)
Soyad_ENTRY = tk.Entry(font="Arial 14", fg="black", bg="white")
Soyad_ENTRY.place(x=100, y=100, width=250, height=25)

KimlikNo_LABEL = tk.Label(text="Kimlik No:", font="Arial 14", fg="white")
KimlikNo_LABEL.place(x=10, y=150)
KimlikNo_ENTRY = tk.Entry(font="Arial 14", fg="black", bg="white")
KimlikNo_ENTRY.place(x=100, y=150, width=250, height=25)

Ilceler_LABEL = tk.Label(text="İlçe:", font="Arial 14", fg="white")
Ilceler_LABEL.place(x=10, y=200)
Secili1 = tk.StringVar()
Secili1.set(IlcelerS[0])
Ilceler_OP = tk.OptionMenu(Form, Secili1, *IlcelerS)
Ilceler_OP.place(x=100, y=200)

Okul_LABEL = tk.Label(text="Okul:", font="Arial 14", fg="white")
Okul_LABEL.place(x=610, y=50)
Okul_ENTRY = tk.Entry(font="Arial 14", fg="black", bg="white")
Okul_ENTRY.place(x=710, y=50, width=250, height=25)

Cinsiyet_LABEL = tk.Label(text="Cinsiyet:", font="Arial 14", fg="white")
Cinsiyet_LABEL.place(x=610, y=100)
Secili2 = tk.StringVar()
Secili2.set(CinsiyetlerS[0])
Cinsiyet_OP = tk.OptionMenu(Form, Secili2, *CinsiyetlerS)
Cinsiyet_OP.place(x=710, y=100)

Sinif_LABEL = tk.Label(text="Sınıf:", font="Arial 14", fg="white")
Sinif_LABEL.place(x=610, y=150)
Secili3 = tk.StringVar()
Secili3.set(SiniflarS[0])
Sinif_OP = tk.OptionMenu(Form, Secili3, *SiniflarS)
Sinif_OP.place(x=710, y=150)

Listbox_LISTBOX = tk.Listbox(font="Arial 14", fg="black", bg="white", borderwidth=1)
Listbox_LISTBOX.place(x=610, y=250, width=350, height=200)

Kontrol_LBL = tk.Label(text="...", font="Arial 14", fg="white")
Kontrol_LBL.place(x=10, y=250)

Kaydet_BUTTON = tk.Button(text="Kaydet", font="Arial 14", fg="white", bg="blue", borderwidth=1, command=Kaydet)
Kaydet_BUTTON.place(x=710, y=200, width=120, height=25)
Temizle_BUTTON = tk.Button(text="Temizle", font="Arial 14", fg="white", bg="#959691", borderwidth=1, command=Temizle)
Temizle_BUTTON.place(x=840, y=200, width=120, height=25)
Sil_BUTTON = tk.Button(text="Sil", font="Arial 14", fg="white", bg="red", borderwidth=1, command=Sil)
Sil_BUTTON.place(x=840, y=450, width=120, height=25)
Incele_BUTTON = tk.Button(text="İncele", font="Arial 14", fg="white", bg="#959691", borderwidth=1, command=Incele)
Incele_BUTTON.place(x=610, y=450, width=120, height=25)
Form.mainloop()