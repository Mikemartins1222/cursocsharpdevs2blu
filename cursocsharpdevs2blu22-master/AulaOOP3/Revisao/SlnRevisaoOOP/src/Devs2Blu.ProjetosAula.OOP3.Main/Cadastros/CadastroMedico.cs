using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Enum;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroMedico
    {

        public Medico mdc;
        public CadastroMedico()
        {
                    
        }
        
        public void MenuCadastro() 
        
        {
            int opcao = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("------Cadastro de Médicos------");
                Console.WriteLine("------1 - Lista de Médicos------");
                Console.WriteLine("------2 - Cadastro de Médicos------");
                Console.WriteLine("------3 - Alterar Médicos------");
               
                Int32.TryParse(Console.ReadLine(), out opcao);
            
            
            
            switch (opcao)

            {
                    case (int)MenuEnums.LISTAR:
                    ListarMedico();
                    break;

                    case (int)MenuEnums.CADASTRAR:
                    CadastrarMedico(mdc);// Aqui adicionamos o argumento da classe paciente para alimentar o parâmetro do método"
                    break;


                    default:
                    break;

            }
            
            
            
            } while (!opcao.Equals(MenuEnums.SAIR));
        }

        public void ListarMedico() 
        {

            Console.Clear();

            foreach (Medico medico in Program.Mock.ListaMedicos)
            {

                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Código: {medico.Codigo}");
                Console.WriteLine($"Nome: {medico.Nome}");
                Console.WriteLine($"CPF: {medico.CGCCPF}");
                Console.WriteLine($"CRM: {medico.CRM}");
                Console.WriteLine(($"Especialidade: {medico.Especialidade}"));
                Console.WriteLine(($"Cadastro Médico: {medico.CodigoMedico}"));
                Console.WriteLine("-----------------------------------------");
            }

            Console.ReadKey();
        }

        public void CadastrarMedico(Medico novoMedico)
        {

            Console.Clear();

            // Listar a entrada de dados aqui 
            novoMedico = new Medico(); // Aqui instancioamos um novo objeto Paciente 
            Random rd = new Random();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Cadastro de Médicos");
            Console.WriteLine("-----------------------------------------");

            novoMedico.Codigo = rd.Next(1, 300);
            Console.WriteLine($"Código: {novoMedico.Codigo}");

            Console.WriteLine($"Insira o nome do médico");
            novoMedico.Nome = Console.ReadLine();

            Console.WriteLine($"Insira o CPF do médico");
            novoMedico.CGCCPF = Console.ReadLine();

            novoMedico.CRM = rd.Next(1, 300);
            Console.WriteLine($"CRM: {novoMedico.CRM}");

            Console.WriteLine($"Insira qual especialidade");
            novoMedico.Especialidade = Console.ReadLine();
            Console.WriteLine($"Especialidade: {novoMedico.Especialidade}");

            novoMedico.CodigoMedico = rd.Next(1, 300);
            Console.WriteLine("Médico Cadastrado com Sucesso!\n");


            Program.Mock.ListaMedicos.Add(novoMedico);

            Console.ReadKey();



        }





    }
}

