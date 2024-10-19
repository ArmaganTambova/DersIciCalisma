
def Mantik(Sayi1, Baglac, Sayi2):
    if Baglac == "ve":
        if Sayi1 == 1 and Sayi2 == 1:
            print("Önermeniz = 1")
        else:
            print("Önermeniz = 0")
    elif Baglac == "ya da":
        if Sayi1 == Sayi2:
            print("Önermeniz = 0")
        else:
            print("Önermeniz = 1")
    elif Baglac == "veya":
        if Sayi1 == 1 or Sayi2 == 1:
            print("Önermeniz = 1")
        else:
            print("Önermeniz = 0")
    elif Baglac == "ise":
        if Sayi1 == 1 and Sayi2 == 0:
            print("Önermeniz = 0")
        else:
            print("Önermeniz = 1")
    elif Baglac == "ancak ve ancak":
        if Sayi1 == Sayi2:
            print("Önermeniz = 1")
        else:
            print("Önermeniz = 0")
    else:
        print("Böyle Bir Bağlaç Yok")

def KesisimKumesiBulma():
