import tkinter as tk

def Hesapla():
    Sayi = int(Sayi_ENTRY.get())
    Sonuc = Sayi ** 2
    Cevap_LBL.config(text="Cevabınız = " + str(Sonuc))

Form = tk.Tk()
Form.geometry('350x150')
Form.title('Sözlü 8')
Form.tk_setPalette('#373735')

Sayi_LBL = tk.Label(text="Sayı:", font="Arial 14", fg="white")
Sayi_LBL.place(x=10, y=10)
Sayi_ENTRY = tk.Entry(font="Arial 14", fg="black", bg="white")
Sayi_ENTRY.place(x=75, y=10, width=250, height=25)

Hesapla_BUTTON = tk.Button(text="Hesapla", font="Arial 14", fg="black", bg="white", borderwidth=0, command=Hesapla)
Hesapla_BUTTON.place(x=75, y=50, width=250, height=25)

Cevap_LBL = tk.Label(text="Cevap", font="Arial 14", fg="white")
Cevap_LBL.place(x=75, y=90)
Form.mainloop()