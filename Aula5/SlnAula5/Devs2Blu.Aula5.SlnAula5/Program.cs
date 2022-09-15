using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.Aula5.SlnAula5
{
    class Program
    {
        static void Main(string[] args)
        {
            ExercicioSwitchCase3();
        }

        static void ExemploSwitchCase()
        {


            /*
             *  - "A23" : Materiais
                - "A35": Produtos Perecíveis
                - "Z16": Produtos Químicos
             */
            string codigo;

            Console.WriteLine("Escolha um código para ver a descrição");
            Console.WriteLine("- A21");
            Console.WriteLine("- A22");
            Console.WriteLine("- A23");
            Console.WriteLine("- A24");
            Console.WriteLine("- A35");
            Console.WriteLine("- Z16");

            codigo = Console.ReadLine();

            switch (codigo.ToUpper())
            {
                case "A21":
                case "A22":
                case "A23":
                case "A24":
                    Console.WriteLine("A23: Materiais.");
                    break;
                case "A35":
                    Console.WriteLine("A35: Produtos Perecíveis.");
                    break;
                case "Z16":
                    Console.WriteLine("Z16: Produtos Químicos.");
                    break;

                default:
                    Console.WriteLine("Produto Não Cadastrado.");
                    break;
            }



        }

        static void ExercicioSwitchCase1()
        {

            string fruta;

            Console.WriteLine("Escolha a fruta que você deseja comprar");
            Console.WriteLine($"MAÇÃ");
            Console.WriteLine($"KIWI");
            Console.WriteLine($"MELANCIA");
            
            
            fruta = Console.ReadLine();

            switch (fruta.ToUpper())
            {
                case "MAÇÃ":

                Console.WriteLine("Não vendemos essa fruta aqui");
                
                break;



                case "KIWI":

                Console.WriteLine("Estamos com escassez de kiwis");

                break;


                case "MELANCIA":

                Console.WriteLine("Aqui está, são 3 reais o quilo");

                break;


                default:
                
                Console.WriteLine("Fruta Inválida");

                break; 


            }


        }



        static void ExercicioSwitchCase2()
        {

            string tipoVeiculo;

            Console.WriteLine("Escolha o tipo de veículo desejado");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"HATCH");
            Console.WriteLine($"SEDAN");
            Console.WriteLine($"MOTOCICLETA");
            Console.WriteLine($"CAMINHONETE");
            Console.WriteLine("----------------------------------");


            tipoVeiculo = Console.ReadLine();

            switch (tipoVeiculo.ToUpper())
            {
                case "HATCH":

                    Console.WriteLine("Compra efetuada com sucesso");

                break;

                case "SEDAN":
                case "MOTOCICLETA":
                case "CAMINHONETE":


                    Console.WriteLine("Tem certeza que não prefere este modelo?");

                
                break;

                default:

                    Console.WriteLine("Não trabalhamos com este tipo de automóvel aqui");

                break;


            }








        }

        static void ExercicioSwitchCase3()
        {

            int valor1, valor2, total = 0; 
            string operacao;
            const string SOMA = "1";
            const string SUBTRACAO = "2";
            const string MULTIPLICACAO = "3";
            const string DIVISAO = "4";

            Console.WriteLine("CALCULADORA PARA DOIS VALORES");
            Console.WriteLine("------------");
            Console.WriteLine("Informe o primeiro valor");
            string valor1STR = Console.ReadLine();
            Console.WriteLine("Informe o segundo valor");
            string valor2STR = Console.ReadLine();
            Int32.TryParse(valor1STR, out valor1);
            Int32.TryParse(valor2STR, out valor2);
            Console.WriteLine("Escolha a operação desejada");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("------------");
            operacao = Console.ReadLine();



            switch(operacao)
            {


                case SOMA:
                total = valor1 + valor2;
                operacao = "+";
                break;

                case SUBTRACAO:
                total = valor1 - valor2;
                operacao = "-";
                break;


                case MULTIPLICACAO:
                total = valor1 * valor2;
                operacao = "*";
                break;

                case DIVISAO:
                total = valor1 / valor2;
                operacao = "/";
                break;


                default:
                Console.WriteLine("Operação Inválida");
                break; 



            }


            Console.WriteLine($"Operação: {valor1} {operacao} {valor2} = {total}");



        }


        static void ExercicioSwitchCase4()
        {

            Console.WriteLine("Consulte os tipos de produtos");
            Console.WriteLine("------------");
            Console.WriteLine("Informe o primeiro valor");
            string valor1STR = Console.ReadLine();
            Console.WriteLine("Informe o segundo valor");
            string valor2STR = Console.ReadLine();
            //Int32.TryParse(valor1STR, out valor1);
            //Int32.TryParse(valor2STR, out valor2);
            Console.WriteLine("Escolha a operação desejada");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("------------");
            //operacao = Console.ReadLine();





        }

        static void ExercicioSwitchCaseJogo21()
        {

            int numMaquina, numJogador ,numOponente, pontuacaoRodadaJogador, pontuacaoRodadaOponente, ptsJogador, ptsOponente;
            

            
            Console.WriteLine("Vamos jogar 21");
            Console.WriteLine("--------------");
            Console.WriteLine("Jogador, digite um número entre 1 a 20");
            string numJogadorSTR = Console.ReadLine();
            Int32.TryParse(numJogadorSTR, out numJogador);
            Console.WriteLine($"Você escolheu o número: {numJogador}");
            Console.WriteLine("--------------");
            Random rd = new Random();
            numMaquina = rd.Next(0, 20);
            numOponente = rd.Next(0, 20);
            Console.WriteLine($"A máquina escolheu o número: {numMaquina}");
            Console.WriteLine("--------------");
            Console.WriteLine($"O seu oponente escolheu o número: {numOponente}");
            Console.WriteLine("--------------");



            pontuacaoRodadaJogador = numJogador + numMaquina;
            pontuacaoRodadaOponente = numOponente + numMaquina;

            Console.WriteLine($"A somatória da rodada da sua jogada é: {pontuacaoRodadaJogador}");
            

            switch (pontuacaoRodadaJogador)
            {
                case 7:
                ptsJogador = 10;
                Console.WriteLine($"A pontuação do jogador é: {ptsJogador}");
                break;
                
                case 14:
                ptsJogador = 20;
                Console.WriteLine($"A pontuação do jogador é: {ptsJogador}");
                break;

                case 21:
                ptsJogador = 30;
                Console.WriteLine($"A pontuação do jogador é: {ptsJogador}");
                break;

                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                ptsJogador = 1;
                Console.WriteLine($"A pontuação do jogador é: {ptsJogador}");
                break;

                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                ptsJogador = 5;
                Console.WriteLine($"A pontuação do jogador é: {ptsJogador}");
                break;

                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                ptsJogador = 6;
                Console.WriteLine($"A pontuação do jogador é: {ptsJogador}");
                break;


                default:
                Console.WriteLine("Não ganhou nenhum ponto");
                break;



            }

            Console.WriteLine($"A somatória da rodada do seu oponente é: {pontuacaoRodadaOponente}");
            



            switch (pontuacaoRodadaOponente)
            {
                case 7:
                    ptsOponente = 10;
                    Console.WriteLine($"A pontuação do oponente é: {ptsOponente}");
                    break;

                case 14:
                    ptsOponente = 20;
                    Console.WriteLine($"A pontuação do oponente é: {ptsOponente}");
                    break;

                case 21:
                    ptsOponente = 30;
                    Console.WriteLine($"A pontuação do oponente é: {ptsOponente}");
                    break;

                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    ptsOponente = 1;
                    Console.WriteLine($"A pontuação do oponente é: {ptsOponente}");
                    break;

                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    ptsOponente = 5;
                    Console.WriteLine($"A pontuação do oponente é: {ptsOponente}");
                    break;

                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    ptsOponente = 6;
                    Console.WriteLine($"A pontuação do oponente é: {ptsOponente}");
                    break;


                default:
                    Console.WriteLine("Não ganhou nenhum ponto");
                    break;



            }

            


        }
    }
}
