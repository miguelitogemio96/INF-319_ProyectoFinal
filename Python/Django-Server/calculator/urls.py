from django.urls import path

from . import views     # it means - 'from all import views'

urlpatterns = [
    path('',views.index, name='index'),
    path('lpar',views.lista_pares, name='lpar'),
    path('hora',views.calc_hora, name='hora'),
    path('rev',views.reversa, name='rev'),
    path('bis',views.bisiesto, name='bis'),
]

# whenever 'localhost:8000' will be called, function named 'index' will be called that is present in 'views.py' file
# This will happen for all other routes as well