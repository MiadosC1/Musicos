class Musico
{
    public string Nombre{get; set;}
    public string Instrumento{get; set;}
    public Musico(string n) => Nombre = n; //Constructor

    public void Saludar(){Console.WriteLine($"Hola soy {Nombre}");}
        
        public virtual void Toca()
        {
            Console.WriteLine($"{Nombre} esta tocando su guitarra");
        }
}
class Baterista:Musico
{
    public string Bateria {get; set;}
    public Baterista(string Nombre, string bateria):base(Nombre)
    {
        Bateria = bateria;
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
        Metallica.Add(new Musico("James Hetfield"));
        Metallica.Add(new Baterista("Lars Ulrich", "Zildjian"));
        Metallica.Add(new Musico("Kirk Hammet"));
        Metallica.Add(new Bajista("Jason Newsted", "Yamaha"));

        foreach (var Musico in Metallica)
        Musico.Saludar();

        foreach (var Musico in Metallica)
        Musico.Toca();

    }
}