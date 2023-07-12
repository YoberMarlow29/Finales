using Entidades;
internal class Program
{
    private static void Main(string[] args)
    {
        Auto auto = new Auto(4, "sfwf3", 4, EMarcas.Scania);
        Camion camion = new Camion(500,"fhg7",6,EMarcas.Ford);
        Moto moto = new Moto(1000, "ogk34", 2, EMarcas.Zanella);
        Moto moto1 = new Moto(1000, "fgwr", 2, EMarcas.Fiat);
        Lavadero lavadero = new Lavadero(400f, 200f, 100f);

        lavadero += auto;
        lavadero += camion;
        lavadero += moto;
        lavadero += moto1;



        foreach (Vehiculo vehiculo in lavadero.Vehiculos)
        {
            Console.WriteLine(vehiculo.ToString());
        }

    }
}