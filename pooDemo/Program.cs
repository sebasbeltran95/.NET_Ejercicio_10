// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Apuntador apuntadorPlatzi = new Apuntador();
Apuntador apuntadorPlatzi2 = new Apuntador();
Ave ave1 = new Ave();
Ave ave2 = new Ave();

var campo1 = apuntadorPlatzi.Color = "Negro";
var campo2 = apuntadorPlatzi2.Color = "Blanco";
Console.WriteLine(campo1);
Console.WriteLine(campo2);

var campo3 = ave1.Nombre = "colibri";
Console.WriteLine(campo3);


class Apuntador
{
    public string Color;
    public int Largo;
    public short NumeroDeBotones;
    public bool TieneStickers;
}

class Ave
{
    public string Nombre;
    public string Color;
    public string Tamaño;
    public string Familia;
    public string Ubicacion;
    public string SexoBiologico;
    public string EsVoladora;
}

