namespace Aula_4
{
    public partial class Conversor10toX
    {
        static void Main(string[] args)
        {
            int numBase10 = 20;
            var numBaseX = new Stack<string>();

            int BaseX = 2;
            while (numBase10 > 0)
            {
                int resto = numBase10 % BaseX;
                numBase10 = numBase10 / BaseX;
                numBaseX.Push(algarimosTraduzidos[resto]);
            }

            if (numBaseX.Peek() == "0")
                numBaseX.Pop();


            var numero = String.Join("", numBaseX);
            Console.WriteLine(numero);
        }
    }
}