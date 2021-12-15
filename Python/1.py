def sum_pares(lista_pares):
    lista_pares = lista_pares.split(',')
    lista_resultado = [];
    for i in lista_pares:
        par = i.split(' ')
        lista_resultado.append(int(par[0]) + int(par[1]))       
    return lista_resultado

print(sum_pares("1 2,3 4,5 6,7 8"))