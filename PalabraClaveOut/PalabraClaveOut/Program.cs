// See https://aka.ms/new-console-template for more information
//variable local a Main(argumento)

byte numAr;
string saludoAr;
int numPrimoAr;

//Invocamos el metodo y mandamos a los argumentos
Prueba(out numAr, out saludoAr, out numPrimoAr);


//Despues de que el metodo cambio de vvalor, mostramos a los argumentos

Console.WriteLine(numAr);
Console.WriteLine(saludoAr);
Console.WriteLine(numPrimoAr);



//[modificador], [tipo], [identificador] [parametros]

static void Prueba(out byte numPa, out string saludoPa, out int numPrimoPa)
{
    numPa = 20;
    saludoPa = "Hola a todos";
    numPrimoPa = 7;

}

/*
 La palabra clave "out" sirve para cambiar los valores sin la necesidad de inicializarlos*/