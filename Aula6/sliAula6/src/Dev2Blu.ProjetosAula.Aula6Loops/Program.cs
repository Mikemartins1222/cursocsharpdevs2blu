using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev2Blu.ProjetosAula.Aula6Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Exercicio4While();




        }

        static void Exemplo1()
        {

            int controle = 1;

            // O WHILE PRIMEIRO VERIFICA DEPOIS EXECUTA
            while (controle > 0)
            {
                Console.WriteLine("Informe o código 0 para sair");
                Int32.TryParse(Console.ReadLine(), out controle);
            }



        }



        // static void Exemplo2()
        // {

        //O DO WHILE EXECUTA UMA VEZ PRIMEIRO E DEPOIS ELE VERIFICA SE PODE CONTINUAR EXECUTANDO A MESMA INSTRUÇÃO DO ESCOPO
        //do
        //{
        //  Console.WriteLine("Informe o código 0 para sair");
        // Int32.TryParse(Console.ReadLine(), out controle);

        //} while (controle > 0);


        //}


        static void Exercicio1While()
        {


            int ciclo = 0;
            const int RESTOPAR = 0;
            Console.WriteLine("Mostrando os números impares");

            while (ciclo < 100)
            {

                int resto = 0;
                resto = ciclo % 2;


                switch (resto)
                {

                    case RESTOPAR:
                        // É PAR; 
                        break;

                    default:
                        Console.WriteLine($"Número Impar: {ciclo}");
                        break;


                }


                ciclo++;



            }



        }



        static void Exercicio2While()
        {





            int ciclo = 0;
            const int RESTOPAR = 0;


            Console.WriteLine("Mostrando os números pares");



            while (ciclo <= 100)
            {

                int resto = 0;
                //Console.WriteLine($"Número gerado {ciclo}");
                resto = ciclo % 2;



                switch (resto)
                {

                    case RESTOPAR:
                        Console.WriteLine($"Número Par: {ciclo}");
                        break;


                    default:
                        //Console.WriteLine($"Número Impar: {ciclo}");
                        break;


                }


                ciclo++;



            }



        }


        static void Exercicio3While()
        {


            int ciclo = 0, maiorNumero;
            const int RESTOPAR = 0;


            Console.WriteLine("Mostrando todos os pares e impares");
            Console.WriteLine("----------------------------------");
            Int32.TryParse(Console.ReadLine(), out maiorNumero);


            while (ciclo <= maiorNumero)
            {

                int resto = 0;
                resto = ciclo % 2;

                switch (resto)
                {

                    case RESTOPAR:
                    Console.WriteLine($"Número Par: {ciclo}");
                    break;

                    default:
                    Console.WriteLine($"Número Impar: {ciclo}");
                    break;

                }


                ciclo++;



            }
        }

        static void Exercicio4While()
        {

            int alunos = 0;
            int contador = 0;
            double soma = 0;
            double nota = 0;

            Console.WriteLine("Quantos alunos tem na sua sala?");
            int.TryParse(Console.ReadLine(), out alunos);
            Console.WriteLine("\n");

            while (contador < alunos)
            {
                Console.WriteLine($"Digite a nota do {contador + 1}º aluno");
                double.TryParse(Console.ReadLine(), out nota);
                soma += nota;
                contador++;
            }
            double media = soma / alunos;
            Console.WriteLine($"A média de nota dos seus alunos é {media:F1}\n\n");

        }
    }
}