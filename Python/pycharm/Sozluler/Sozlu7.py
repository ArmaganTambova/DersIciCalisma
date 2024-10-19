import tkinter as tk

Sayi = [0]
def Ekle():
    SayiE = Sayi[0]
    SayiE += 1
    Sayi.pop(0)
    Sayi.insert(0, SayiE)
    Button_BUTTON.config(text=str(SayiE))

Form = tk.Tk()
Form.geometry('170x50')
Form.title('Sözlü 7')
Form.tk_setPalette('#373735')

Button_BUTTON = tk.Button(text="0", font="Arial 14", fg="black", bg="white", borderwidth=0, command=Ekle)
Button_BUTTON.place(x=10, y=10, width=150, height=25)
Form.mainloop()