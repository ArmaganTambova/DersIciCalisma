import tkinter as tk

pencere = tk.Tk()
pencere.title("Listbox Kontrolü")
pencere.geometry('450x300')
lb_Liste = tk.Listbox(bg="silver", fg="purple", relief="sunken", font="Arial 14")
lb_Liste.place(x=10, y=10, height=250, width=250)
Isimler = ["Cemrenaz", "Kaan", "Armağan", "Nisa"]
for Isim in Isimler:
    lb_Liste.insert(tk.END, Isim)
pencere.mainloop()

#-Listbox Aracı Parametreleri-
#bg                     Arkaplan Rengi
#db                     Kenarlık Rengi
#cursor                 Fare İmleci Görünümü
#font                   Liste Elemanlarının Yazı Tipi
#fg                     Yazı Rengi
#width                  Listbox Genişliği(Yatay Karakter Sayısı)
#heigth                 Listbox Yüksekliği(Satır Sayısı)
#relief                 Listbox Kenarlık Görünümü(sunken, raised, groove, flat)
#selectmode             Liste Elemanlarının Seçim Şekli
#SINGLE                 Sadece 1 Eleman Seçilebilir
#MULTIPLE               Listede 1'den Fazla Eleman Seçilebilir
#xscrollcommand         Listbox'a Yatay Kaydırma Çubuğu Ekler
#yscrollcommand         Listbox'a Dikey Kaydırma Çubuğu Ekler
#-Listbox Aracı Metodları-
#activate(index)        İndex Numarası İle Belirtilen Satırı Seçili Hale Getirir
#curselection()         Mouse İle Seçilen Satırın Numarasını Getirir
#delete(first, last)    First Last İndex Numaraları Arasındaki Satırları Siler
#get(first, last)       First Last İndex Numaraları Arasındaki Satırların Metnini Getirir
#insert(index, eleman)  Belirlenen İndex Numarasına Eleman Ekler
#size()                 Listboxtaki Satır Sayısını Döndürür