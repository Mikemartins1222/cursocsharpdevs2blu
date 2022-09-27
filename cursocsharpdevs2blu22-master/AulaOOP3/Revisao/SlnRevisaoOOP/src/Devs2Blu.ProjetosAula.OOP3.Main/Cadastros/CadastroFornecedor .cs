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
    public class CadastroFornecedor
    {

        public Fornecedor frd;
        public CadastroFornecedor()
        {
                    
        }
        
        public void MenuCadastro() 
        
        {
            int opcao = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("------Cadastro de Fornecedores------");
                Console.WriteLine("------1 - Lista de Fornecedores------");
                Console.WriteLine("------2 - Cadastro de Fornecedores------");
                Console.WriteLine("------3 - Alterar de Fornecedores------");
               
                Int32.TryParse(Console.ReadLine(), out opcao);
            
            
            
            switch (opcao)

            {
                    case (int)MenuEnums.LISTAR:
                    ListarFornecedor();
                    break;


                    case (int)MenuEnums.CADASTRAR:
                    CadastrarFornecedor(frd);// Aqui adicionamos o argumento da classe paciente para alimentar o parâmetro do método"
                    break;


                    default:

                    break;

            }
            
            
            
            } while (!opcao.Equals(MenuEnums.SAIR));



        }

        public void ListarFornecedor() 
        {
        
            Console.Clear();

            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedores)
            {

                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Codigo: {fornecedor.Codigo}");
                Console.WriteLine($"Nome: {fornecedor.Nome}");
                Console.WriteLine($"CPF: {fornecedor.CGCCPF}");
                Console.WriteLine($"Tipo Fornecedor: {fornecedor.TipoFornecedor}");
                Console.WriteLine($"Código Fornecedor: {fornecedor.CodigoFornecedor}");
                Console.WriteLine("-----------------------------------------");
            }

            Console.ReadKey();


        }

      
        public void CadastrarFornecedor(Fornecedor novoFornecedor)
        {

            Console.Clear();

            // Listar a entrada de dados aqui 
            novoFornecedor = new Fornecedor(); // Aqui instanciamos um novo objeto Paciente 
            Random rd = new Random();

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Cadastro de Fornecedores");
            Console.WriteLine("-----------------------------------------");

            novoFornecedor.Codigo = rd.Next(1, 300);
            Console.WriteLine($"Código: {novoFornecedor.Codigo}");

            Console.WriteLine($"Insira o nome do fornecedor");
            novoFornecedor.Nome = Console.ReadLine();

            Console.WriteLine($"Insira o CPF do fornecedor");
            novoFornecedor.CGCCPF = Console.ReadLine();

            Console.WriteLine($"Insira o tipo de fornecedor");
            novoFornecedor.TipoFornecedor = Console.ReadLine();
            Console.WriteLine($"Especialidade: {novoFornecedor.TipoFornecedor}");

            novoFornecedor.CodigoFornecedor = rd.Next(1, 300);
            Console.WriteLine("Médico Cadastrado com Sucesso!\n");


            Program.Mock.ListaFornecedores.Add(novoFornecedor);

            Console.ReadKey();





        }


    }
}

