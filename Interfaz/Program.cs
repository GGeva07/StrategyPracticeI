using Entidades;

namespace Interfaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Menuu paseador de perros" +
                "\nIngresa una opcion para ver los costos" +
                "\n1. Chiwawa" +
                "\n2. Labrador" +
                "\n3. Husky");
            string? o = Console.ReadLine();
            if (o != null && int.TryParse(o, out int opcion) && opcion > 0 && opcion < 3)
            {
                Context contexto = new(FactoryContext.GetPerro(opcion));
                contexto.Pasear();     
            }
            else
            {
                Console.WriteLine("Ingresa una opcion valida por favor");
            }
            Console.ReadKey();
            Main(args);

        }
    }
}
