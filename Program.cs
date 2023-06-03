internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Desafio área do círculo");

        double raio = 1.0;
        System.Console.Write("Digite o valor do raio: ");
        raio = Convert.ToDouble(System.Console.ReadLine());


        double area = Math.PI * raio * raio;

        System.Console.WriteLine($"A área do círculo de raio {raio} é {area}");
    }
}