def reversa(lista):
    lista = lista.split(',')
    lista_inversa= [];
    for i in lista:
        lista_inversa.insert(0,i);
    return lista_inversa

print(reversa("1,2,3,4,3,5"))