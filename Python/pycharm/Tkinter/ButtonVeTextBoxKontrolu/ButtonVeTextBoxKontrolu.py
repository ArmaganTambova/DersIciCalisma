import tkinter as tk

#-Textbox Aracı Parametreleri-
#bg      Arkaplan Rengi
#fg      Yazı Rengi
#db      Border(Çerçeve Sınırı)
#height  Yükseklik
#width   Genişlik
#font    Yazı Tipi, Büyüklük, Kalınlık, İtalik veya Altı Çizili Yazdırma
#cursor  İmleç Tipi
#-Textbox Aracı Metodları-
#index   Belirtilen Metni Almak İçin Kullanılır
#insert  Yazı Eklemek İçin Kullanılır
#get     Belirli Bir Aralıktaki Karakteri Almak İçin Kullanılır
#delete  Belirli Bir Aralıktaki Karakterleri Siler

def metin_gonder():
    metin = t1.get(1.0, tk.END)
    lbl_yazi.config(text=metin)

pencere = tk.Tk()
t1 = tk.Text(font="Arial 14 bold", bg="dark green", fg="white")
t1.place(x=10, y=10, width=400, height=200)
#t1.pack()
t1.insert(tk.END, "Matrix Yazılım Anadolu Lisesi\nBu Dersimizde tkinder\nTextBox Aracımızı Öğreneceğiz")
btn_gonder = tk.Button(text="Tıkla", font="ComisSansMS 13 bold", command=metin_gonder)
btn_gonder.place(x=10, y=250)
lbl_yazi = tk.Label(text="-----", font="Arial 13 bold")
lbl_yazi.place(x=450, y=10)
pencere.mainloop()