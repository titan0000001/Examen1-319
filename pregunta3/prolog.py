#YURIKA MACUSAYA AGUILAR CI:13846755 LP PREGUNTA 3
from pyswip import Prolog
prolog = Prolog()

print("--------------------")
prolog.assertz('(hermanosxy(X,Y):- progenitorxy(Z,X), progenitorxy(Z,Y), not(X==Y))')
prolog.assertz('(abuelosxy(X,Y) :- progenitorxy(X,Z), progenitorxy(Z,Y))')
prolog.assertz('(nietoxy(X,Y):-  progenitorxy(Z,X),  progenitorxy(Y,Z))')
prolog.assertz('(primosxy(X,Y):- progenitorxy(Z,X), progenitorxy(W,Y), hermanosxy(Z,W))')

prolog.assertz('progenitorxy(homero,bart)')
prolog.assertz('progenitorxy(homero,lisa)')
prolog.assertz('progenitorxy(abraham,homero)')
prolog.assertz('progenitorxy(abraham,jose)')
prolog.assertz('hermanosxy(jose,homero)')
prolog.assertz('hermanosxy(homero, jose)')
prolog.assertz('progenitorxy(jose,mario)')
print("---------relacion padres-----------")
for soln in prolog.query("progenitorxy(X,Y)"):
    print(soln["X"], " es el padre de ", soln["Y"])
print("---------relacion hermanos-----------")
for soln in prolog.query("hermanosxy(X,Y)"):
    print(soln["X"], " es  hermano de  de ", soln["Y"])
print("---------relacion de nietos-----------")
for soln in prolog.query("nietoxy(X,Y)"):
    print(soln["X"], " es  nieto  de ", soln["Y"])
print("---------relacion de abuelos-----------")
for soln in prolog.query("abuelosxy(X,Y)"):
    print(soln["X"], "es el abuelo de ", soln["Y"])
print("---------relacion de primos-----------")
for soln in prolog.query("primosxy(X,Y)"):
    print(soln["X"], " es  primo  de ", soln["Y"])

print("--------------------")

