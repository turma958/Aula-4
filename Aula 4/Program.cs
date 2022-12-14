namespace Aula_4
{
    public class Conversor10toX
    {
        static void Main(string[] args)
        {
            int numBase10 = 20;
            List<string> numBaseX = new List<string>();
            Dictionary<int, string> algarimosTraduzidos = new Dictionary<int, string>()
            {
                {0,"0"},
                {1,"1"},
                {2,"2"},
                {3,"3"},
                {4,"4"},
                {5,"5"},
                {6,"6"},
                {7,"7"},
                {8,"8"},
                {9,"9"},
                {10,"A"},
                {11,"B"},
                {12,"C"},
                {13,"D"},
                {14,"E"},
                {15,"F"},
            };
            int BaseX = 2;

            while (numBase10 > 0)
            {
                int resto = numBase10 % BaseX;
                numBase10 = numBase10 / BaseX;
                numBaseX.Add(algarimosTraduzidos[resto]);
            }

            numBaseX.Reverse();
            if (numBaseX[0] == "0")
                numBaseX.RemoveAt(0);

            foreach (string num in numBaseX)
            {
                Console.Write($"{num}");
            }


        }
    }
}