import tkinter as tk

def BKontrol(Mail):
    if Mail != "":
        return True
    else:
        return False

def Kontrol():
    Semboller = ["@"]
    i = 0
    k = 0
    Mail = Mail_ENTRY.get()
    Bkontrol = BKontrol(Mail)
    if Bkontrol:
        while i < len(Mail):
            if Semboller.__contains__(Mail[i]):
                k += 1
            i += 1
        if k == 1:
            Bildirim_LBL.config(text="E-Posta Geçerli", fg="green")
        elif k > 1:
            Bildirim_LBL.config(text="Birden fazla @ İşareti Kullanılamaz", fg="red")
        else:
            Bildirim_LBL.config(text="E-Posta Geçersiz", fg="red")
    else:
        Bildirim_LBL.config(text="Bu Alan Boş Bırakılamaz", fg="red")

Form = tk.Tk()
Form.geometry('360x150')
Form.title('Sözlü 5')
Form.tk_setPalette('#373735')

Mail_LBL = tk.Label(text="E-Posta", font="Arial 14", fg="white")
Mail_LBL.place(x=10, y=10)
Mail_ENTRY = tk.Entry(font="Arial 14", fg="black", bg="white")
Mail_ENTRY.place(x=100, y=10, width=250, height=25)

Kontrol_BUTTON = tk.Button(text="Kontrol", font="Arial 14", fg="black", bg="white", borderwidth=0, command=Kontrol)
Kontrol_BUTTON.place(x=250, y=50, width=100, height=25)

Bildirim_LBL = tk.Label(text="...", font="Arial 14", fg="white")
Bildirim_LBL.place(x=10, y=75)
Form.mainloop()