using System;

namespace Calc_Dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            double NUM1, NUM2, Validation, value;

            Program program = new Program();

            Validation = program.Menu();

            Console.WriteLine("Digite um número inteiro");
            NUM1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite outro número inteiro");
            NUM2 = Convert.ToDouble(Console.ReadLine());

            switch (Validation)
            {
              
                case 1:
                    
                    value = program.Somar(NUM1, NUM2);
                    Console.WriteLine($"A SOMA DOS NUMEROS {NUM1} + {NUM2} = {value}");
                    break;
                case 2:
                    
                    value = program.Subtrair(NUM1, NUM2);
                    Console.WriteLine($"A SUBTRAÇÃO DOS NUMEROS {NUM1} - {NUM2} = {value}");
                    break;
                case 3:
            
                    value =  program.Multiplicar(NUM1, NUM2);
                    Console.WriteLine($"A MULTIPLICAÇÃO DOS NUMEROS {NUM1} * {NUM2} = {value}");
                    break;
                case 4:
                    
                    value = program.Dividir(NUM1, NUM2);
                    Console.WriteLine($"A DIVISÃO DOS NUMEROS {NUM1} / {NUM2} = {value}");
                    break;
                default:
                    program.ToString();
                    break;
            }
        }
        private int Menu()
        {
            int opção = 0;
            

            do
            {

                Console.WriteLine("Bem Vindo a Calculadora");
                Console.WriteLine("Qual opção desejada?");
                Console.WriteLine("(1) Soma");
                Console.WriteLine("(2) Subtração");
                Console.WriteLine("(3) Multriplicação");
                Console.WriteLine("(4) Divisão");

                Console.WriteLine("Digite uma opção: ");
                opção = Convert.ToInt32(Console.ReadLine());


            } while ((opção != 1) && (opção != 2) && (opção != 3) && (opção != 4));
            
            return opção;
        }

        private double Somar(Double Num1, Double Num2)
        {
            return Num1 + Num2;
        }

        private double Subtrair(Double Num1, Double Num2)
        {
            return Num1 - Num2;
        }
        private double Multiplicar(Double Num1, Double Num2)
        {
            return Num1 * Num2;
        }
        private double Dividir(Double Num1, Double Num2)
        {
            return Num1 / Num2;
        }
        public override string ToString()
        {
            return "ERROR";
        }
    }
}
