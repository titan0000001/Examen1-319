#YURIKA MACUSAYA AGUILAR CI:13846755LP
#�C�mo se compone una baraja de 52 cartas?
#La baraja de 52 cartas contiene naipes de 4 palos distintos; 
#dos negros: espadas y tr�boles, 
#y dos rojos: corazones y diamantes
set_de_cartas <-c("A",2:10,"J","Q","K")
cartas <-c(rep(set_de_cartas,4))
set_tipos <-c("Corazon", "Diamante", "Trebol", "Espada")
tipos <-c(rep(set_tipos,rep(13,4)))
baraja=data.frame(cartas,tipos)
print(baraja)


