using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Enum;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroRecepcionista
    {

        public Recepcionista rct;
        public CadastroRecepcionista()
        {
                    
        }
        
        public void MenuCadastro() 
        
        {
            int opcao = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("------Cadastro de Recepcionistas------");
                Console.WriteLine("------1 - Lista de Recepcionistas------");
                Console.WriteLine("------2 - Cadastro de Recepcionistas------");
                Console.WriteLine("------3 - Alterar Recepcionistas------");
               
                Int32.TryParse(Console.ReadLine(), out opcao);
            
            
            
            switch (opcao)

            {
                    case (int)MenuEnums.LISTAR:
                    ListarRecepcionista();
                    break;


                    case (int)MenuEnums.CADASTRAR:
                    CadastrarRecepcionista(rct);// Aqui adicionamos o argumento da classe paciente para alimentar o parâmetro do método"
                    break;



                    default:

                    break;

            }
            
            
            
            } while (!opcao.Equals(MenuEnums.SAIR));



        }

        public void ListarRecepcionista() 
        {
        
            Console.Clear();

            foreach (Recepcionista recepcionista in Program.Mock.ListaRecepcionistas)
            {

                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Codigo: {recepcionista.Codigo}");
                Console.WriteLine($"Nome: {recepcionista.Nome}");
                Console.WriteLine($"CPF: {recepcionista.CGCCPF}");
                Console.WriteLine($"Setor: {recepcionista.Setor}");
                Console.WriteLine($"Código Recepcionista: {recepcionista.CodigoRecepcionista}");
                Console.WriteLine("-----------------------------------------");
            }

            Console.ReadKey();


        }


        public void CadastrarRecepcionista(Recepcionista novoRecepcionista)

        {
            Console.Clear();

            // Listar a entrada de dados aqui 
            novoRecepcionista = new Recepcionista(); // Aqui instanciamos um novo objeto Paciente 
            Random rd = new Random();
            
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Cadastro de Recepcionistas");
            Console.WriteLine("-----------------------------------------");

            novoRecepcionista.Codigo = rd.Next(1, 300);
            Console.WriteLine($"Código: {novoRecepcionista.Codigo}");

            Console.WriteLine($"Insira o nome do recepcionista");
            novoRecepcionista.Nome = Console.ReadLine();

            Console.WriteLine($"Insira o CPF do recepcionista");
            novoRecepcionista.CGCCPF = Console.ReadLine();

            Console.WriteLine($"Insira o setor do recepcionista");
            novoRecepcionista.Setor = Console.ReadLine();
            Console.WriteLine($"Especialidade: {novoRecepcionista.Setor}");

            novoRecepcionista.CodigoRecepcionista = rd.Next(1, 300);
            Console.WriteLine("Médico Cadastrado com Sucesso!\n");


            Program.Mock.ListaRecepcionistas.Add(novoRecepcionista);

            Console.ReadKey();




        }



    }
}

