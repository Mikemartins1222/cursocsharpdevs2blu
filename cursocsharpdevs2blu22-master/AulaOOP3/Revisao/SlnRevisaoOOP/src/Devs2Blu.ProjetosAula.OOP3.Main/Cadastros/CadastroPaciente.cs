using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroPaciente
    {
        public Paciente pct;//Aqui foi feita a inicialização da classe paciente para o cadastro paciente 

        public CadastroPaciente()
        {
           
        }
        
        public void MenuCadastro() 
        
        {
            int opcao = 0;

            do
            {
                //Console.Clear();
                Console.WriteLine("------Cadastro de Pacientes------");
                Console.WriteLine("------1 - Lista de Pacientes------");
                Console.WriteLine("------2 - Cadastro de Pacientes------");
                Console.WriteLine("------3 - Alterar Pacientes------");
               
                Int32.TryParse(Console.ReadLine(), out opcao);
                


                switch (opcao)

                {
                    case (int)MenuEnums.LISTAR:
                    ListarPaciente();
                    break;


                    

                   case (int)MenuEnums.CADASTRAR:
                   CadastrarPaciente(pct);// Aqui adicionamos o argumento da classe paciente para alimentar o parâmetro do método"
                        break;

                    
                   default:
                   Console.WriteLine($"VALOR INVÁLIDO");
                   break;

                }
            
            
            
            } while (!opcao.Equals(MenuEnums.SAIR));




        }

        public void ListarPaciente() 
        {

            Console.Clear();

            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Paciente: {paciente.Codigo}");
                Console.WriteLine($"Nome: {paciente.Nome}");
                Console.WriteLine($"CPF: {paciente.CGCCPF}");
                Console.WriteLine($"Convenio: {paciente.Convenio}");
                Console.WriteLine($"Cod. Paciente: {paciente.CodigoPaciente}");
                Console.WriteLine("-----------------------------------------\n");
            }

            Console.ReadKey();


        }



        public void CadastrarPaciente(Paciente novoPaciente)// O parametro está solicitando uma entrada do tipo "Paciente"
        {

            Console.Clear();

            // Listar a entrada de dados aqui 
            novoPaciente = new Paciente(); // Aqui instancioamos um novo objeto Paciente 
            Random rd = new Random();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Cadastro de Pacientes");
            Console.WriteLine("-----------------------------------------");
            
            novoPaciente.Codigo = rd.Next(1, 300); 
            Console.WriteLine($"Paciente: {novoPaciente.Codigo}");
            
            Console.WriteLine($"Insira o nome do paciente");
            novoPaciente.Nome = Console.ReadLine();
            
            Console.WriteLine($"Insira o CPF do paciente");
            novoPaciente.CGCCPF = Console.ReadLine();
           
            Console.WriteLine($"Insira qual o convênio");
            novoPaciente.Convenio = Console.ReadLine();
            Console.WriteLine($"Convenio: {novoPaciente.Convenio}");
            
            novoPaciente.CodigoPaciente = rd.Next(1, 300);
            Console.WriteLine("Cliente Cadastrado com Sucesso!\n");
            
            
            Program.Mock.ListaPacientes.Add(novoPaciente);

            Console.ReadKey();
        }



        public void AlterarPaciente()
        {




        }


        public void ExcluirPaciente()
        {




        }
    }
}

