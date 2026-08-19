
//comentário teste commit Aula 03
using System;
using System.Data;

namespace Aula01Variaveis
{
    public class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Observe o menu abaixo e digite o número referente a opção desejada: ");
            Console.WriteLine("1 - Concatenar Palavras");
            Console.WriteLine("2 - Verificar Dias da Semana");
            Console.WriteLine("3 - Calcular Média");
            Console.WriteLine("4 - Calcular Tabuada");
            Console.WriteLine("5 - Detalhar Data");
            Console.WriteLine("6 - Calcular Desconto INSS");

            int opcaoEscolhida = int.Parse(Console.ReadLine());

            switch (opcaoEscolhida)
            {
                case 1:
                    ConcatenarPalavras();
                    break;

                case 2:
                    VerificarAulaEtec();
                    break;

                case 3:
                    CalcularMedia();
                    break;

                case 4:
                    CalcularTabuada();
                    break;

                case 5:
                    DetalharData();
                    break;

                case 6:
                    CalcularDescontoINSS();
                    break;
            }
        }
        
        public static void VerificarAulaEtec()

        {
            Console.WriteLine("Digite a data: ");
            DateTime data = DateTime.Parse(Console.ReadLine());

            if (data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday)
                Console.WriteLine("Final de semana! Hoje não tem aula! Revisarei exercícios.");
            else
                Console.WriteLine("Dia de semana! Bora pra Etec!");
        }

        public static void CalcularTabuada()
        {
            Console.WriteLine("Digite a tabuada que deseja calcular:");
            int tabuada = int.Parse(Console.ReadLine());
            int contador = 0;

            while (contador <= 10)
            {
                string mensagem = string.Format("{0} X {1} = {2}", tabuada, contador, tabuada * contador);

                Console.WriteLine(mensagem);
                contador++;
            }



        }

        public static void CalcularMedia()
        {
            Console.WriteLine("Digite a primeira nota:");
            decimal nota1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            decimal nota2 = decimal.Parse(Console.ReadLine());

            decimal media = (nota1 + nota2) / 2;
            Console.WriteLine($"A média é {media}");

            if (media >= 7)
                Console.WriteLine("Aprovado");
            else if (media >= 4)
                Console.WriteLine("Recuperação");
            else
                Console.WriteLine("Reprovado");
        }

        public static void ConcatenarPalavras()
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            string frase1 = $"Olá {nome}, hoje é {DateTime.Now}";
            Console.WriteLine(frase1);

            Console.WriteLine("===========================");

            Console.WriteLine("Quanto custa um dólar em reais?");
            decimal ValorDolarReais = decimal.Parse(Console.ReadLine());
            string frase2 = string.Format("Hoje é {0:dd/MM/yyyy}, o dólar está custando {1:c2}", DateTime.Now, ValorDolarReais);
            Console.WriteLine(frase2);

            Console.WriteLine("===========================");

            string cabecalho = string.Format("{0:dddd}, {0:dd} de {0:MMMM} de {0:yy} - {0:HH:mm:ss}", DateTime.Now);
            Console.WriteLine(cabecalho);
        }

        public static void DetalharData()
        {
            Console.WriteLine("Digite uma data:");
            DateTime data = DateTime.Parse(Console.ReadLine());

            string diaSemana = data.ToString("dddd");
            string mes = data.ToString("MMMM");

            Console.WriteLine($"Dia da semana: {diaSemana}");
            Console.WriteLine($"Mês: {mes}");

            if (data.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine($"Hora atual: {DateTime.Now:HH:mm}");
            }
        }

        public static void CalcularDescontoINSS()
        {
            Console.WriteLine("Digite o valor do salário:");
            decimal salario = decimal.Parse(Console.ReadLine());

            decimal valorINSS;

            if (salario <= 1621.00m)
            {
                valorINSS = salario * 0.075m;
            }
            else if (salario <= 2902.84m)
            {
                valorINSS = salario * 0.09m - 24.32m;
            }
            else if (salario <= 4354.27m)
            {
                valorINSS = salario * 0.12m - 111.40m;
            }
            else if (salario <= 8475.55m)
            {
                valorINSS = salario * 0.14m - 198.49m;
            }
            else
            {
                valorINSS = 8475.55m * 0.14m - 198.49m;
            }

            decimal salarioComDesconto = salario - valorINSS;

            Console.WriteLine($"Valor do INSS: {valorINSS:C2}");
            Console.WriteLine($"Salário após desconto do INSS: {salarioComDesconto:C2}");
        }
    }
}
