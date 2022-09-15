using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula3.ProjetoCondicionais
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            Exercicio_2(); 
        }


        static void Exemplo_1()
        {



            string textoSaida;
            string nomeCandidato;
            int idadeCandidato, notaCandidato;



            Console.WriteLine("|Bem - vindo ao programa Syschool|");


            Console.WriteLine("Informe o nome do candidato");
            nomeCandidato = Console.ReadLine();

            Console.WriteLine("Informe a idade do candidato");
            string idadeSTR = Console.ReadLine();




            if (idadeSTR.Equals("")) // O Equals verifica se a variável é igual ao valor descrito
            {

                Console.WriteLine("Valor inválido para idade");
                return;

            }
            else

            {

                idadeCandidato = Int32.Parse(idadeSTR); //Int32.Parse(idadeSTR) Converte de string para uma int 


            }





            Console.WriteLine("Informe a nota do candidato");
            string notaSTR = Console.ReadLine();




            if (notaSTR.Equals("")) // O Equals verifica se a variável é igual ao valor descrito
            {

                Console.WriteLine("Valor inválido para nota");
                return;

            }
            else

            {

                notaCandidato = Int32.Parse(notaSTR); //Int32.Parse(idadeSTR) Converte de string para uma int 


            }

            //Formatação saída de dados
            textoSaida = $"Candidato: {nomeCandidato}\n";
            textoSaida += $"Idade: {idadeCandidato}";




            if (idadeSTR.Equals("")) // O Equals verifica se a variável é igual ao valor descrito
            {

                Console.WriteLine("Valor inválido para nota");
                return;

            }
            else

            {

                notaCandidato = Int32.Parse(idadeSTR); //Int32.Parse(idadeSTR) Converte de string para uma int 


            }







            // Verificar se o candidato é maior de idade
            if (idadeCandidato < 18)
            {


                textoSaida += "(Menor de Idade)\n";


            }
            else
            {


                textoSaida += "(Maior de Idade)\n";



            }



            //Formatação saída de dados
            textoSaida += $"Nota Final: {notaCandidato}\n";


            if (notaCandidato > 5)
            {


                textoSaida += "(Aprovado)";


            }
            else
            {


                textoSaida += "(Reprovado)";



            }


            Console.WriteLine(textoSaida);









        }

        static void Exercicio_1()
        {

            int valor_1 = 0; int valor_2 = 0;



            Console.WriteLine("Digite o primeiro valor");
            string valor1SRT;
            valor1SRT = Console.ReadLine();
            Int32.TryParse(valor1SRT, out valor_1);


            Console.WriteLine("Digite o primeiro valor");
            string valor2SRT;
            valor2SRT = Console.ReadLine();
            Int32.TryParse(valor2SRT, out valor_2);





            if (valor_1 > valor_2)
            {

                Console.WriteLine("O Primeiro valor é o maior");

            }
            else if (valor_1 < valor_2)

            {

                Console.WriteLine("O Segundo valor é o maior");

            }
            else
            {
                Console.WriteLine("Os dois tem o mesmo valor");
            }





        }



        static void Exercicio_2()
        {

            int valor1, valor2, valor3, valor4;
            int menorValor = 999999999;


            Console.WriteLine("Programa que verifica o menor valor entre 4 valores!\n\n");
            Console.WriteLine("Informe o valor1");
            string valor1STR = Console.ReadLine();
            Int32.TryParse(valor1STR, out valor1);


            Console.WriteLine("Informe o valor1");
            string valor2STR = Console.ReadLine();
            Int32.TryParse(valor2STR, out valor2);


            Console.WriteLine("Informe o valor1");
            string valor3STR = Console.ReadLine();
            Int32.TryParse(valor3STR, out valor3);


            Console.WriteLine("Informe o valor1");
            string valor4STR = Console.ReadLine();
            Int32.TryParse(valor4STR, out valor4);


            if (valor1 < menorValor)
            {

                menorValor = valor1;

            }


            if (valor2 < menorValor)
            {

                menorValor = valor2;

            }


            if (valor3 < menorValor)
            {

                menorValor = valor3;

            }



            if (valor4 < menorValor)
            {

                menorValor = valor4;

            }

            Console.WriteLine($"O menor valor é {menorValor}");

        }

    }






}
