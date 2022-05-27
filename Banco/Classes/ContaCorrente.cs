using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_Digital.Classes
{
    internal class Corrente : Classes.Conta
    {
        public Corrente(Cliente cliente, int numero, decimal saldo)
            : base(cliente, numero, saldo)
        { }

        public override bool Depositar(decimal valorDeposito)
        {
            if (valorDeposito <= 0)
            {
                MensagemTransacoes = $"O valor do depósito é inválido!";
                return false;
            }
            Saldo += valorDeposito;
            MensagemTransacoes = "Deposito realizado com sucesso!";
            return true;
        }

        public override bool Sacar(decimal valorSaque)
        {
            if (Saldo <= 0m)
            {
                MensagemTransacoes = $"O saque insuficiente, valor atual de {Saldo}";
                return false;
            }
            if (Saldo < valorSaque)
            {
                MensagemTransacoes = $"Valor solicitado para o saque é {valorSaque}, taxa de saque da conta corrente de 10% aplicada. Seu saldo atual é {Saldo}.";
                return false;
            }
            Saldo -= valorSaque;
            return true;
        }
    }
}

