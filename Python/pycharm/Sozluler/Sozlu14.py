import tkinter as tk

def Kontrol():
    Sayi = int(Sayi_ENTRY.get())
    if Sayi >= 0:
        Bildirim_LBL.config(text="Pozitif", fg="green")
    else:
        Bildirim_LBL.config(text="Negatif", fg="red")

Form = tk.Tk()
Form.geometry('350x150')
Form.title('Sözlü 14')
Form.tk_setPalette('#373735')

Sayi_LBL = tk.Label(text="Sayı:", font="Arial 14", fg="white")
Sayi_LBL.place(x=10, y=10)
Sayi_ENTRY = tk.Entry(font="Arial 14", fg="black", bg="white")
Sayi_ENTRY.place(x=75, y=10, width=250, height=25)

Kontrol_BUTTON = tk.Button(text="Kontrol", font="Arial 14", fg="black", bg="white", borderwidth=0, command=Kontrol)
Kontrol_BUTTON.place(x=75, y=50, width=250, height=25)

Bildirim_LBL = tk.Label(text="...", font="Arial 14", fg="white")
Bildirim_LBL.place(x=75, y=90)
Form.mainloop()