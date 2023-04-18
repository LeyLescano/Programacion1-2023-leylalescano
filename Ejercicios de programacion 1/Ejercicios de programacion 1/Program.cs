/* ejercicio 1, forma A
Console.WriteLine("Ingresar clave:");
 string? clave = Console.ReadLine();
while (clave != "667788") // != es una forma de declarar la cadena
{
    Console.WriteLine("contraseña incorrecta");
    clave = Console.ReadLine();
}
Console.WriteLine("inicio correcto");

*/

/* ejercicio 1 forma B
Console.WriteLine("ingresa la clave");
string? clave;
do
{
    clave = Console.ReadLine();
} while (clave != "667788");
Console.WriteLine("perfecto");
*/

/*
Console.WriteLine("Ingresar numero:");
string? numeroingresado = Console.ReadLine();
int numero2 = int.Parse(numeroingresado);

while (numero2 < 0) // hacer que el string se haga int 
{
    Console.WriteLine("numero incorrecto");
    numeroingresado = Console.ReadLine(); //volver a definir int de numeroingresado para que numero2 se compare 
    numero2 = int.Parse(numeroingresado);

}
Console.WriteLine("numero leido");
*/
/*
Console.WriteLine("Flaco, poneme las ventas y cuando no tengas mas, poneme un 0");
int sumita = -0;

Console.WriteLine("ingresar valor:");
string valor = Console.ReadLine();
int valorInt = int.Parse(valor);

while (valorInt < 0)
{
    sumita = sumita + valorInt;

    Console.WriteLine("ingresar valor:");
    valor = Console.ReadLine();
    valorInt = int.Parse(valor);

}
Console.WriteLine("al final te equivocaste: " + sumita);
*/

Console.WriteLine("Ingresar numero:");
string? numeroingresado = Console.ReadLine();
int numero2 = int.Parse(numeroingresado);
int sumitaneg = 0;

int cuentaneg = 0;
while (numero2 < 0) // hacer que el string se haga int 
{
    Console.WriteLine("numero incorrecto");
    numeroingresado = Console.ReadLine(); //volver a definir int de numeroingresado para que numero2 se compare 
    numero2 = int.Parse(numeroingresado);
    sumitaneg = sumitaneg + numero2;
    cuentaneg = cuentaneg + 1;

}
int promedio = 0;
if (cuentaneg > 0)
{
    promedio = sumitaneg / cuentaneg;
}
Console.WriteLine("numero leido, el promedio de errores es: " + promedio);
