namespace Entidades
{
    public class FactoryContext
    {
        public static IPaseo GetPerro(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    return new Chiwawa();
                    break;
                case 2:
                    return new Labrador();
                    break;
                case 3:
                    return new Husky();
                    break;

                default:
                    Console.WriteLine("Ingrese una opcion valida por favor");
                    return null;
                    break;
            }
        }
    }
}
