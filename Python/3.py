def calcula_hora(segundos):
    segundos = int(segundos)
    time = []
    time.append(segundos//3600)
    time.append((segundos%3600)//60)
    time.append((segundos%3600)%60)
    return "HH:MM:SS -> " + str(time[0]) + ":" + str(time[1]) + ":" + str(time[2])


print(calcula_hora("10000"))