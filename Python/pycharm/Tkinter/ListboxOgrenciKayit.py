import tkinter as tk

def Ekle():
    Isim = OgrenciKayit_Entry.get()
    List_Listbox.insert(tk.END, Isim)
    OgrenciKayit_Entry.delete(0, tk.END)

def Sil():
    List_Listbox.delete(tk.ACTIVE)

def Temizle():
    List_Listbox.delete(0, tk.END)

form = tk.Tk()
form.geometry('550x270')
form.title('Öğrenci Kayıt Formu')
form.tk_setPalette("#373735")

List_Listbox = tk.Listbox(font="Arial 14", fg="white")
List_Listbox.place(x=10, y=10, width=250, height=250)

OgrenciKayit_LBL = tk.Label(text="Öğrenci Adı", font="Arial 14 bold", fg="white")
OgrenciKayit_LBL.place(x=280, y=25)

OgrenciKayit_Entry = tk.Entry(font="Arial 14 bold", fg="black", bg="white")
OgrenciKayit_Entry.place(x=280, y=65, width=250, height=25)

Kayit_Button = tk.Button(text="Öğrenci Ekle", font="Arial 14 bold", fg="black", bg="white", borderwidth=0, command=Ekle)
Kayit_Button.place(x=405, y=125, width=125, height=25)

Sil_Button = tk.Button(text="Sil", font="Arial 14 bold", fg="black", bg="white", borderwidth=0, command=Sil)
Sil_Button.place(x=405, y=175, width=125, height=25)

Temizle_Button = tk.Button(text="Temizle", font="Arial 14 bold", fg="black", bg="white", borderwidth=0, command=Temizle)
Temizle_Button.place(x=405, y=225, width=125, height=25)
form.mainloop() 