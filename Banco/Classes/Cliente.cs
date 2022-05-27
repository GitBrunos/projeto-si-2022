using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_Digital.Classes
{
    class Cliente
    {
        private Cliente()
        { }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public long Telefone { get; private set; }
        public string CPF { get; private set; }
        public System.DateTime Data_de_Nascimento { get; private set; }
        public static Cliente CreateCliente(string nome, string endereco, long telefone, string cpf, System.DateTime datanascimento)
        {
            var datadehoje = System.DateTime.Today;
            if (datadehoje.Year - datanascimento.Year <= 17)
            {
                System.Console.WriteLine("Novinho demais");
                System.Environment.Exit(0);
            }
            if (cpf.Length <= 11)
            {
                System.Console.WriteLine("CPF invalido.");
                System.Environment.Exit(0);
            }
            return new Cliente()
            {
                Nome = nome,
                Endereco = endereco,
                Telefone = telefone,
                CPF = cpf,
                Data_de_Nascimento = datanascimento
            };
        }
        public override string ToString() => $"Nome: {Nome} | Documento: {CPF} | Data de Nascimento: {Data_de_Nascimento}";
    }
}
