import tkinter as tk

def Hesapla():
    Kenar = int(Kare_ENTRY.get())
    Cevap = Kenar ** 4
    Cevap_LBL.config(text="Cevabınız = " + str(Cevap))

Form = tk.Tk()
Form.geometry('600x150')
Form.title('Sözlü 12')
Form.tk_setPalette('#373735')

Kare_LBL = tk.Label(text="Karenin Kenar Uzunluğunu Giriniz:", font="Arial 14", fg="white")
Kare_LBL.place(x=10, y=10)
Kare_ENTRY = tk.Entry(font="Arial 14", fg="black", bg="white")
Kare_ENTRY.place(x=300, y=10, width=250, height=25)

Hesapla_BUTTON = tk.Button(text="Hesapla", font="Arial 14", fg="black", bg="white", borderwidth=0, command=Hesapla)
Hesapla_BUTTON.place(x=300, y=50, width=250, height=25)

Cevap_LBL = tk.Label(text="Cevap", font="Arial 14", fg="white")
Cevap_LBL.place(x=300, y=90)
Form.mainloop()