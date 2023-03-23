abstract class Musico
{
    public string Nombre{get; set;}
    public string Instrumento{get; set;}
    public Musico(string n) => Nombre = n; //Constructor

    public virtual void Saludar()
    {
        Console.WriteLine($"Hola soy {Nombre}");
    }
        
        public abstract void Toca();
}

class Guitarrista:Musico
{
    public string Guitarra {get; set;}
    public Guitarrista(string Nombre, string guitarra):base(Nombre)
    {
        Guitarra = guitarra;
    }

    public override void Toca()
    {
        Console.WriteLine($"{Nombre} esta tocando su {Guitarra}");
    }
}
class Baterista:Musico
{
    public string Bateria {get; set;}
    public Baterista(string Nombre, string bateria):base(Nombre)
    {
        Bateria = bateria;
    }

    public override void Saludar ()
    {
        Console.WriteLine($"Hola {Nombre} y soy baterista");
    }

    public override void Toca()
    {
        Console.WriteLine($"{Nombre} tocando su bateria {Bateria}");
    }


}
class Bajista:Musico
{
    public string Bajo {get; set;}
    public Bajista(string Nombre, string bajo):base(Nombre)
    {
        Bajo = bajo;
    }

    public override void Saludar()
    {
        Console.WriteLine($"Hola soy {Nombre} y soy bajista");
    }

    public override void Toca()
    {
        Console.WriteLine($"{Nombre} tocando su bajo {Bajo}");
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        List<Musico> Metallica = new List<Musico>();
        Metallica.Add(new Guitarrista("James Hetfield", "Gibson"));
        Metallica.Add(new Baterista("Lars Ulrich", "Zildjian"));
        Metallica.Add(new Guitarrista("Kirk Hammet", "Gibson"));
        Metallica.Add(new Bajista("Jason Newsted", "Yamaha"));

        foreach (var Musico in Metallica)
        Musico.Saludar();

        foreach (var Musico in Metallica)
        Musico.Toca();

    }
}