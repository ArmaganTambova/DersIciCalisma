import tkinter as tk

def Ekle():
    Ad = Ad_ENTRY.get()
    Liste_LISTBOX.insert(tk.END, Ad)

Form = tk.Tk()
Form.geometry('650x400')
Form.title('Sözlü 4')
Form.tk_setPalette('#373735')

Liste_LISTBOX = tk.Listbox(font="Arial 14", fg="black", bg="white", borderwidth=0)
Liste_LISTBOX.place(x=10, y=10, width=250, height=380)

Ad_LBL = tk.Label(text="İsim:", font="Arial 14", fg="white")
Ad_LBL.place(x=285, y=10)
Ad_ENTRY = tk.Entry(font="Arial 14", fg="black", bg="white")
Ad_ENTRY.place(x=350, y=10, width=250, height=25)

Ekle_BUTTON = tk.Button(text="Ekle", font="Arial 14", fg="black", bg="white", borderwidth=0, command=Ekle)
Ekle_BUTTON.place(x=500, y=50, width=100, height=25)
Form.mainloop()