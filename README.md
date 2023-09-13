# Fibonacci
Es un API REST que devuelve el valor de una serie de Fibonacci que corresponde al índice solicitado

una serie de fibonnaci se compone de una secuencia de números cuyo valor es la suma de los dos anteriores.
Los primeros dos numeros siempre serán 0 y 1, el tercero será la suma de 0+1=1, el cuarto será 1+1=2, el quinto 2+1=3, el sexto 3+2=5, etc.

x1 contiene el valor del primer número de la serie que es 0
x2 contiene el valor del segundo número de la serie que es 1

Creamos un ciclo for-next para recorrer los índices de la serie del 0 hasta el índice indicado por el usuario.
Si el índice requerido es 0, no se entra al ciclo y el sistema de vuelve el valor de x1 que es 0.
Si el índice requerido es 1 o mayor el sistema entra al ciclo, 

	Al entrar al ciclo x1 contiene el valor del fibonacci anterior
	Al entrar al ciclo x2 contiene el valor del fibonacci actual

	En una variable temp almacenamos el valor del fibonacci anterior (x1)
	
	En x1 almacemanos el valor del fibonnaci actual(x2)

	En x2 almacenamos el valor del fibonnaci siguiente, es decir el anterior + el actual (temp + x1) 

	Al salir del ciclo x1 contiene el valor del fibonacci actual
	Al salir del ciclo x2 contiene el valor del fibonacci siguiente


Al terminar el ciclo x1 contiene el valor de la serie de fibonacci solicitada.



 






