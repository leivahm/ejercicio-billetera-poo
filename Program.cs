using EjercicioClase13.Modelo;

var Billetera1 = new Billetera()
{
    BilletesDe10 = 5,
    BilletesDe20 = 10,
    BilletesDe50 = 1,
    BilletesDe100 = 5,
    BilletesDe200 = 2,
    BilletesDe500 = 5,
    BilletesDe1000 = 7
};

Console.WriteLine($"El importe total de la billetera 1 es: {Billetera1.Total(Billetera1)}");
Console.Write($"{Billetera1.BilletesDe10} de '$10'    {Billetera1.BilletesDe20} de '$20'    {Billetera1.BilletesDe50} de '$50'    {Billetera1.BilletesDe100}  de '$100'");
Console.Write($"\n{Billetera1.BilletesDe200} de '$200'    {Billetera1.BilletesDe500} de '$500'    {Billetera1.BilletesDe1000} de 1000\n");


var Billetera2 = new Billetera()
{
    BilletesDe10 = 6,
    BilletesDe20 = 0,
    BilletesDe50 = 0,
    BilletesDe100 = 0,
    BilletesDe200 = 0,
    BilletesDe500 = 0,
    BilletesDe1000 = 2,

};

Console.WriteLine($"\nEl importe total de la billetera 2 es: {Billetera2.Total(Billetera2)}");
Console.Write($"{Billetera2.BilletesDe10} de '$10'    {Billetera2.BilletesDe20} de '$20'    {Billetera2.BilletesDe50} de '$50'    {Billetera2.BilletesDe100}  de '$100'");
Console.Write($"\n{Billetera2.BilletesDe200} de '$200'    {Billetera2.BilletesDe500} de '$500'    {Billetera2.BilletesDe1000} de 1000\n");

Console.WriteLine($"\nEl importe combinado de billetera 1 y 2 es: {Billetera2.Combinar(Billetera1, Billetera2)}\n");

var Billetera3 = new Billetera();
Billetera3.BilleteraNro3(Billetera1, Billetera2);

Billetera1.LimpiarBilletera(Billetera1);
Billetera2.LimpiarBilletera(Billetera2);

Console.WriteLine($"\nAhora el importe total de la billetera 1 es: {Billetera1.Total(Billetera1)}");
Console.WriteLine($"Ahora el importe total de la billetera 2 es: {Billetera2.Total(Billetera2)}");