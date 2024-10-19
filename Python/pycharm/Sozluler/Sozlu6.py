import tkinter as tk

OptionMenu = ["Veri1", "Veri2"]

def Yazdir():
    Secili = Secim.get()
    Yazdir_LBL.config(text=Secili)

Form = tk.Tk()
Form.geometry('200x150')
Form.title('Sözlü 6')
Form.tk_setPalette('#373735')

Secim = tk.StringVar()
Secim.set(OptionMenu[0])
Secim_OP = tk.OptionMenu(Form, Secim, *OptionMenu)
Secim_OP.place(x=10, y=10)

Yazdir_LBL = tk.Label(text="...", font="Arial 14", fg="white")
Yazdir_LBL.place(x=10, y=50)

Yazdir_BUTTON = tk.Button(text="Yazdır", font="Arial 14", fg="black", bg="white", borderwidth=0, command=Yazdir)
Yazdir_BUTTON.place(x=10, y=90, width=150, height=25)
Form.mainloop()