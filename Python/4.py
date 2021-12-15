def es_biciesto(año):
    año = int(año)
    if año % 4 == 0 and (año % 100 != 0 or año % 400 == 0):
	    return "Es Bisiesto"
    else:
        return "No es Bisiesto"


print(es_biciesto("2020"))