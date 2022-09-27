﻿using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Utils
{
    public class Mocks
    {
        public List<Paciente> ListaPacientes { get; set; }
        public List<Medico> ListaMedicos { get; set; }
        public List<Recepcionista> ListaRecepcionistas { get; set; }
        public List<Fornecedor> ListaFornecedores { get; set; }

        public Mocks()
        {
            ListaPacientes = new List<Paciente>();
            ListaMedicos = new List<Medico>();
            ListaRecepcionistas = new List<Recepcionista>();
            ListaFornecedores = new List<Fornecedor>();

            CargaMock();
        }
        public void CargaMock()
        {
            CargaPacientes();
            CargaMedicos();
            CargaRecepcionistas();
            CargaFornecedores();
        }

        public void CargaPacientes()
        {
            for (int i = 0; i < 2; i++)
            {
                Paciente paciente = new Paciente(i, $"Paciente {i+1}", $"{i}23{i}56{i}891{i}","Unimed");
                ListaPacientes.Add(paciente);
            }
        }



        public void CargaMedicos()
        {
            for (int i = 0; i < 4; i++)
            {
                
                Medico medico = new Medico(i, $"Médico {i + 1}", $"{i}23{i}56{i}891{i}", 1+i, "Ortopedista");
                ListaMedicos.Add(medico);
            }
        }

        public void CargaRecepcionistas()
        {

            Random rd = new Random();
            string[] setor = new string[] { "setor 1", "setor 2", "setor 3", "setor 4" }; 

            for (int i = 0; i < 5; i++)
            {

                Recepcionista recepcionista = new Recepcionista(rd.Next(0,10), $"Recepcionista {i + 1}", $"{i}23{i}56{i}891{i}", setor[rd.Next(0, 3)]);
                ListaRecepcionistas.Add(recepcionista);
            }



        }


        public void CargaFornecedores()
        {

            Random rd = new Random();

            string[] tipoFornecedor = new string[] { "fornecedor 1", "fornecedor 2", "fornecedor 3", "fornecedor 4" };

            for (int i = 0; i < 5; i++)
            {

                Fornecedor fornecedor = new Fornecedor(rd.Next(0, 10), $"Fornecedor {i + 1}", $"{i}23{i}56{i}891{i}", tipoFornecedor[rd.Next(0, 3)]);
                ListaFornecedores.Add(fornecedor);
            }



        }
    }
}

