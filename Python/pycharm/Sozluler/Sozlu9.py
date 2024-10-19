import tkinter as tk

def Kontrol():
    Veri = Veri_ENTRY.get()
    if Veri != "":
        Bildirim_LBL.config(text="Onaylandı", fg="green")
    else:
        Bildirim_LBL.config(text="Alanı Boş Bırakamazsınız", fg="red")

Form = tk.Tk()
Form.geometry('350x150')
Form.title('Sözlü 9')
Form.tk_setPalette('#373735')

Veri_LBL = tk.Label(text="Veri:", font="Arial 14", fg="white")
Veri_LBL.place(x=10, y=10)
Veri_ENTRY = tk.Entry(font="Arial 14", fg="black", bg="white")
Veri_ENTRY.place(x=75, y=10, width=250, height=25)

Kontrol_BUTTON = tk.Button(text="Kontrol", font="Arial 14", fg="black", bg="white", borderwidth=0, command=Kontrol)
Kontrol_BUTTON.place(x=75, y=50, width=250, height=25)

Bildirim_LBL = tk.Label(text="...", font="Arial 14", fg="white")
Bildirim_LBL.place(x=75, y=90)
Form.mainloop()