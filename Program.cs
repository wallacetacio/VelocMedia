using System;

namespace VelocMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            string distancia, tempo;

            Console.WriteLine(" ");
            Console.WriteLine(@"Olá usuário,
pronto para calcular a velocidade média? Vamos lá!");
            Console.WriteLine(" ");

            Console.Write("Distância percorrida (m): ");
            distancia = Console.ReadLine();
             Console.WriteLine(" ");

            Console.Write("Tempo gasto (s): ");
            tempo = Console.ReadLine();
            Console.WriteLine(" ");

            double d = Convert.ToDouble(distancia);
            double t = Convert.ToDouble(tempo);

            double Vm = d / t;

            Console.WriteLine($"Velocidade média: {Vm}m/s");
            Console.WriteLine(" ");

            if(Vm >= 27)
            {
                Console.ForegroundColor = ConsoleColor.Red;
             Console.WriteLine("Você está acima de 100Km/h! Cuidado!");
             Console.ResetColor();   
            }else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Continue assim! ;)");
                Console.ResetColor();
            }
        }
    }
}
