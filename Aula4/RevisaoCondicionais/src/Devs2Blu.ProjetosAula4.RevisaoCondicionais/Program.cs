using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula4.RevisaoCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //Em um método Estático, só pode ser chamado outros métodos estáticos 
            Exercicio8();



        }

        static void Exemplo1()
        {




        }



        static void Exemplo2()
        {




        }




        static void Exemplo3()
        {

            //Verificador ternário 


        }



        static void Exemplo4()
        {

            //Verificador com "ou" || 


        }



        static void Exercicio3()
        {

            int valor, checarValor;

            Console.WriteLine("///Programa que aponta se é par ou impar///");

            //Console.WriteLine("Digite um valor");
            //string valorStr;
            //valorStr = Console.ReadLine();
            //Int32.TryParse(valorStr, out valor);

            Random rd = new Random();
            valor = rd.Next(0, 50); 
            checarValor = valor - valor / 2 * 2;



            if(valor != 0)
            {


                    //if (!checarValor == 0) Exclamação atrás verifica se a condição é falsa
                    if (checarValor == 0)
                    {

                    Console.WriteLine($"O número é par {valor}");
                    }

                    else
                    {

                    Console.WriteLine($"O número é impar {valor}");

                    }



            }
            
            else
            
            
            {

                Console.WriteLine($"Você digitou 0");


            }




            



        }



        static void Exercicio4()
        {

            string cod1, cod2, cod3, codRecebido;
            
            
            cod1 = "001";
            cod2 = "002";
            cod3 = "003";
            


            Console.WriteLine($"Consulte o nome do produto");
            
            
            Console.WriteLine($"Digite o código do produto:");
            Console.WriteLine($"001 - Arroz");
            Console.WriteLine($"002 - Feijão");
            Console.WriteLine($"002 - Farinha");


            codRecebido = Console.ReadLine(); 


            if(codRecebido.Equals (cod1))
            {
                
                Console.WriteLine($" O produto é Arroz\n\n{codRecebido}");



            } else if (codRecebido == (cod2))
            {

                Console.WriteLine($" O produto é Feijão\n\n{codRecebido}");


            } else if (codRecebido == (cod3))
            {

                Console.WriteLine($" O produto é Farinha\n\n{codRecebido}");


            } else
            {


                Console.WriteLine($"Diversos");

            }



        }


        static void Exercicio5()
        {
            bool votar;
            int anoNascimento, idade;

             
            Console.WriteLine("Vamos verificar se você pode votar");
            Console.WriteLine("Digite o ano que você nasceu");
            string idadeStr = Console.ReadLine(); 


            Int32.TryParse(idadeStr, out anoNascimento);

           idade = DateTime.Now.Year - anoNascimento; 
           votar = (idade >= 16) ? true : false; 

            if (votar)
            {
                
                Console.WriteLine($"Você tem {idade} anos e pode votar"); 


            }
            else
            {

                Console.WriteLine($"Você tem {idade} anos e não pode votar"); 


            }


        }


        static void Exercicio6()
        {

            //CONSTANTE SEMPRE UTILIZAR MAIÚSCULO, ela é utilizada para valores dos quais não mudam ao longo do programa
            const string SENHA = "1234";
            string entradaSenha; 
            bool acesso;


            Console.WriteLine("*****Validação de acesso iniciada*****");
            
            Console.WriteLine("Digite a senha para validar o acesso");
            entradaSenha = Console.ReadLine();

            acesso = (entradaSenha.Equals(SENHA)) ? true : false;

            if (acesso)
            {

                Console.WriteLine("*****Acesso permitido*****");

            }
            else
            {

                Console.WriteLine("*****Acesso negado*****");


            }


        }

        static void Exercicio7()
        {
            int qdeMacas;
            double precoMacas, valorTotal; ;



            Console.WriteLine($"***Sistema de pagamento da feira***\n\n");
            

            Console.WriteLine($"Digite a quantidade de maçãs que deseja comprar:");
            string qdeMacasSTR = Console.ReadLine();
            Int32.TryParse(qdeMacasSTR, out qdeMacas);


            precoMacas = (qdeMacas < 12) ? 0.30 : 0.25;
            valorTotal = precoMacas * qdeMacas; 

            Console.WriteLine($"Quantidade de maçãs compradas: {qdeMacas} Preço por maçã: R$ {precoMacas} Valor total a pagar: R${valorTotal}");


        }

        static void Exercicio8()
        {

            int[] valores = new int[3];
            string[] valorSTR = new string[3];
            int[] ordemFinal = new int[3];

            Console.WriteLine($"***Ordenador de valores***");

            Console.WriteLine("Digite 3 valores");

            for (int i = 0; i < 3; i++)
            {
               
                Console.WriteLine($"Digite o valor {i}");
                valorSTR[i] = Console.ReadLine();
                Int32.TryParse(valorSTR[i], out valores[i]);

            
            
            }

            if (valores[0] > valores[1] && valores[0] > valores[2])
            {

                ordemFinal[0] = valores[0]; 

                
                if(valores[1] > valores[2])
                {

                    ordemFinal[1] = valores[1];
                    ordemFinal[2] = valores[2];

                } else if (valores[2] > valores[1])
                {

                    ordemFinal[1] = valores[2];
                    ordemFinal[2] = valores[1];

                }

            }




            if (valores[1] > valores[0] && valores[1] > valores[2])
            {

                ordemFinal[0] = valores[1]; 

                
                if(valores[0] > valores[2])
                {

                    ordemFinal[1] = valores[0];
                    ordemFinal[2] = valores[2];

                } else if (valores[2] > valores[0])
                {

                    ordemFinal[1] = valores[2];
                    ordemFinal[2] = valores[0];

                }

            }




            if (valores[2] > valores[0] && valores[2] > valores[1])
            {

                ordemFinal[0] = valores[2];


                if (valores[0] > valores[1])
                {

                    ordemFinal[1] = valores[0];
                    ordemFinal[2] = valores[1];

                }
                else if (valores[1] > valores[0])
                {

                    ordemFinal[1] = valores[1];
                    ordemFinal[2] = valores[0];

                }

            }


            Console.WriteLine($"A ordem é: {ordemFinal[0]}{ordemFinal[1]}{ordemFinal[2]}");



        }
    }
}
