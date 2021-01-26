namespace DigitalInovationOne.Metodos
{
    public class Out
    {
        static void Dividir(int x, int y, out int resultado, out int resto)
        {
            resultado = x / y;
            resto = x % y;
        }
        public static void Inverter()
        {
            int i = 1, j = 2;
            Dividir(10, 3, out int resultado, out int resto);
            System.Console.WriteLine("{0} {1}", resultado, resto);
        }
    }
}