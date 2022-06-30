using EjercicioClase13.Modelo;

var Billetera1 = new Billetera()
{
    BilletesDe10 = 5,
    BilletesDe20 = 0,
    BilletesDe50 = 1,
    BilletesDe100 = 0,
    BilletesDe200 = 1,
    BilletesDe500 = 1,
    BilletesDe1000 = 1
};

Console.WriteLine($"El importe total de la billetera 1 es: { Billetera1.Total(Billetera1)}\n");


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


Console.WriteLine($"El importe combinado de billetera 1 y 2 es: {Billetera2.Combinar(Billetera1, Billetera2)}\n");

var Billetera3 = new Billetera();
Billetera3.BilleteraNro3(Billetera1, Billetera2);

Billetera1.LimpiarBilletera(Billetera1);
Billetera2.LimpiarBilletera(Billetera2);

Console.WriteLine($"\nEl importe total de la billetera 1 es: {Billetera1.Total(Billetera1)}");
Console.WriteLine($"El importe total de la billetera 2 es: {Billetera2.Total(Billetera2)}");