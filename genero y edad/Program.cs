// See https://aka.ms/new-console-template for more information
Console.WriteLine("edad y genero");

Console.WriteLine("Ingrese su edad:");
int edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese su género:");
char genero = Convert.ToChar(Console.ReadLine());

Console.WriteLine();


string mensaje = PedirDatos(edad, genero);
Console.WriteLine(mensaje);

Console.WriteLine();


static string PedirDatos(int edad, char genero)

{

    if (edad >= 18 && genero == 'f')
    {
        return "puede pasar gratis.";
    }
    else if (edad >= 18 && genero == 'm')
    {
        return " tienes que pagar para pasar.";
    }
    else
    {
        return "eres menor";
    }

}