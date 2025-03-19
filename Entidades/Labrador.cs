namespace Entidades
{
    public class Labrador : IPaseo
    {
        public void Pasear()
        {
            Console.WriteLine("Tiempo de paseo: 20min " +
                              "\nCosto: 200$");
        }
    }
}
