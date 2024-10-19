import tkinter as tk

def Yazdir():
    Veri_LBL.config(text=Listbox_LISTBOX.get(tk.ACTIVE))

Listbox = ["Veri1", "Veri2"]

Form = tk.Tk()
Form.geometry('600x400')
Form.title('Sözlü 10')
Form.tk_setPalette('#373735')

Listbox_LISTBOX = tk.Listbox(font="Arial 14", fg="black", bg="white", borderwidth=0)
Listbox_LISTBOX.place(x=10, y=10, width=250, height=380)

Veri_LBL = tk.Label(text="...", font="Arial 14", fg="white")
Veri_LBL.place(x=300, y=10)

Yazdir_BUTTON = tk.Button(text="Yazdır", font="Arial 14", fg="black", bg="white", borderwidth=0, command=Yazdir)
Yazdir_BUTTON.place(x=300, y=50, width=100, height=25)

for Veri in Listbox:
    Listbox_LISTBOX.insert(tk.END, Veri)
Form.mainloop()