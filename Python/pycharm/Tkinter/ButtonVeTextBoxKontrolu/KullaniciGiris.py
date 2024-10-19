import tkinter as tk

def Kontrol():
    kullaniciadi = t1.get()
    sifre = t2.get()
    if kullaniciadi == "admin" and sifre == "1234":
        kontrol = tk.Label(text="Giriş Başarılı", font="Arial 14 bold", fg="green")
        kontrol.place(x=50, y=200)
    else:
        kontrol = tk.Label(text="Kullanıcı Adı veya Şifre Yanlış Tekrar Deneyiniz", font="Arial 14 bold", fg="red")
        kontrol.place(x=50, y=200)

pencere = tk.Tk()
pencere.geometry('650x300')
pencere.title('Giriş Ekranı')
lbl1 = tk.Label(text="Kullanıcı Giriş", font="Arial 14 bold")
lbl1.place(x=300, y=10)
lbl2 = tk.Label(text="Kullanıcı Adı", font="Arial 14 bold")
lbl2.place(x=50, y=50)
lbl3 = tk.Label(text="Şifre", font="Arial 14 bold")
lbl3.place(x=50, y=100)
t1 = tk.Entry(font="Arial 14 bold", bg="blue", fg="white")
t1.place(x=250, y=50, height=25, width=250)
t2 = tk.Entry(font="Arial 14 bold", bg="blue", fg="white")
t2.place(x=250, y=100, height=25, width=250)
bt = tk.Button(text="Giriş", font="Arial 14 bold", bg="blue", fg="white", command=Kontrol)
bt.place(x=500, y=150, height=25, width=100)
pencere.mainloop()