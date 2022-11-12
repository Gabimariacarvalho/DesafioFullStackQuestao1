
class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite uma sequência de números inteiros:");
        string[] InputNumerosInteiros = Console.ReadLine().TrimEnd().Split(',');
        Console.WriteLine("Digite um alvo :");
        int alvo = Convert.ToInt32(Console.ReadLine());
        foreach (var n in InputNumerosInteiros)
        {
            int number;
            if (!int.TryParse(n, out number))
            {
                Console.WriteLine($"O número {n} não é um inteiro");
                break;
            }

        }
        int[] Input = InputNumerosInteiros.Select(int.Parse).ToArray();
        BuscarIndice(Input, alvo);
    }

    public static void BuscarIndice(int[] input, int alvo)
    {
        int tamanhoInput = input.Length;
        for (int i = 0; i < tamanhoInput - 1; i++)
        {
            int valor = alvo - input[i];
            int index = Array.IndexOf(input, valor);
            if (index != -1)
            {
                Console.WriteLine($"Os índices da soma do seu alvo é [{i}, {index}]");
                return;
            }
        }
        Console.WriteLine("Não conseguimos achar somas que chegam no seu alvo :(");

    }
}