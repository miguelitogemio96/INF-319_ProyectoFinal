from django.shortcuts import render

# Create your views here.

def index(request):
    return render(request, "input.html")


def bisiesto(año):
    año = int(request.POST['num1'])
    if año % 4 == 0 and (año % 100 != 0 or año % 400 == 0):
	    return "Es Bisiesto"
    else:
        return "No es Bisiesto"
# print(es_biciesto("2020"))
    
        
def lista_pares(request):
    num1 = request.POST['num1']   
    lista_pares = num1.split(',')
    lista_resultado = [];
    for i in lista_pares:
        par = i.split(' ')
        lista_resultado.append(int(par[0]) + int(par[1]))     
    return render(request, "result.html", {"result": lista_resultado})
    

def calc_hora(request):
    num1 = request.POST['num1']
    segundos = int(num1)
    time = []
    time.append(segundos//3600)
    time.append((segundos%3600)//60)
    time.append((segundos%3600)%60)
    res = "HH:MM:SS -> " + str(time[0]) + ":" + str(time[1]) + ":" + str(time[2])
    return render(request, "result.html", {"result": res})
    

def reversa(request):
    num1 = request.POST['num1']
    lista = num1.split(',')
    lista_inversa= [];
    for i in lista:
        lista_inversa.insert(0,i);
    return render(request, "result.html", {"result": lista_inversa})

def bisiesto(request):
    num1 = request.POST['num1']
    año = int(num1)
    if año % 4 == 0 and (año % 100 != 0 or año % 400 == 0):
	    res = "Es Bisiesto"
    else:
        res = "No es Bisiesto"
    return render(request, "result.html", {"result": res})
    