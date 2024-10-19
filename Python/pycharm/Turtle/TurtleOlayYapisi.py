import turtle

ok = turtle.Turtle()

def DaireCiz(x, y):
    ok.circle(100)

def ElleCiz(x, y):
    ok.goto(x, y)

ok.ondrag(ElleCiz)
# ok.onclick(DaireCiz)
ok.screen.mainloop()