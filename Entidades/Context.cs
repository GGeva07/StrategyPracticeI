namespace Entidades
{
    public class Context
    {
        IPaseo paseo; 

        public Context(IPaseo objeto)
        {
            paseo = objeto;
        }

        public void Pasear()
        {
            paseo.Pasear();
        }

    }
}
