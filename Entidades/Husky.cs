namespace Entidades
{
    public class Husky : IPaseo
    {
        public void Pasear()
        {
            Console.WriteLine("Tiempo de paseo: 60min " +
                "\nCosto: 300$");
        }
    }
}
