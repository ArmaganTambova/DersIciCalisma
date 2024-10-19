import tkinter as tk

def Yazdir():
    Ad = Ad_ENTRY.get()
    Soyad = Soyad_ENTRY.get()
    Bildirim_LBL.config(text=Ad + " " + Soyad)

Form = tk.Tk()
Form.geometry('400x200')
Form.title('Sözlü 15')
Form.tk_setPalette('#373735')

Ad_LBL = tk.Label(text="Ad:", font="Arial 14", fg="white")
Ad_LBL.place(x=10, y=10)
Ad_ENTRY = tk.Entry(font="Arial 14", fg="black", bg="white")
Ad_ENTRY.place(x=75, y=10, width=250, height=25)

Soyad_LBL = tk.Label(text="Soyad:", font="Arial 14", fg="white")
Soyad_LBL.place(x=10, y=50)
Soyad_ENTRY = tk.Entry(font="Arial 14", fg="black", bg="white")
Soyad_ENTRY.place(x=75, y=50, width=250, height=25)

Yazdir_BUTTON = tk.Button(text="Yazdır", font="Arial 14", fg="black", bg="white", borderwidth=0, command=Yazdir)
Yazdir_BUTTON.place(x=75, y=90, width=250, height=25)

Bildirim_LBL = tk.Label(text="...", font="Arial 14", fg="white")
Bildirim_LBL.place(x=75, y=130)
Form.mainloop()