
tiene_tallo(manzana,si).
tiene_tallo(cereza,si).
tiene_tallo(platano,no).
tiene_tallo(limon,no).
tiene_tallo(pera,no).
tiene_tallo(ciruela,no).
tiene_tallo(uva,no).
tiene_tallo(naranja,no).
tiene_tallo(mandarina,no).
tiene_tallo(mango,no).

es_acido(limon,si).
es_acido(cereza,no).
es_acido(platano,no).
es_acido(manzana,no).
es_acido(pera,no).
es_acido(ciruela,no).
es_acido(uva,no).
es_acido(naranja,no).
es_acido(mandarina,no).
es_acido(mango,no).

tiene_piedra(cereza,si).
tiene_piedra(mango,si).
tiene_piedra(platano,no).
tiene_piedra(manzana,no).
tiene_piedra(limon,no).
tiene_piedra(pera,no).
tiene_piedra(ciruela,no).
tiene_piedra(uva,no).
tiene_piedra(naranja,no).
tiene_piedra(mandarina,no).

es_color(platano,amarillo).
es_color(manzana,verde).
es_color(manzana,rojo).
es_color(limon,amarillo).
es_color(limon,verde).
es_color(pera,verde).
es_color(ciruela,rojo).
es_color(uva,morado).
es_color(naranja,naranja).
es_color(mandarina,naranja).
es_color(durazno,durazno).
es_color(mango,verde).
es_color(mango,amarillo).
es_color(cereza,rojo).

es_forma(platano,creciente).
es_forma(manzana,esfera).
es_forma(limon,'esfera conica').
es_forma(pera,'esfera conica').
es_forma(ciruela,esfera).
es_forma(uva,esfera).
es_forma(naranja,esfera).
es_forma(mandarina,'esfera aplanada').
es_forma(mango,creciente).
es_forma(cereza,esfera).

cargar:-exists_file('rules.pl'),consult('rules.bd').
es_fruta(FRUTA,FORMA,COLOR,PIEDRA,ACIDO,TALLO):- es_forma(FRUTA,FORMA),es_color(FRUTA,COLOR),tiene_piedra(FRUTA,PIEDRA),es_acido(FRUTA,ACIDO),tiene_tallo(FRUTA,TALLO).