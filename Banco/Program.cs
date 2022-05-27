using System;

namespace Banco_Digital.Classes
{
    class Program
    {
        static void Main()
        {
            try
            {
                var mauricio = Banco_Digital.Classes.Cliente.CreateCliente("Mauricio", "Rua 9 de Julho", 3333332999, "999.999.999-99", new System.DateTime(2000, 02, 17));
                var brunao = Banco_Digital.Classes.Cliente.CreateCliente("Brunao", "Rua 11 de Maio", 33232329, "999.999.999-99", new System.DateTime(2001, 12, 17));
                var deposito = 1000;
                var saque = 500;
                
                
                Console.WriteLine($"criando conta poupanca.{mauricio} \nSaldo:");
                Classes.Conta ContaMauricioPoupanca = new Poupanca(mauricio, 445852, 100);
                System.Console.WriteLine(ContaMauricioPoupanca.Saldo);

                Console.WriteLine($"deposito de {deposito} na conta poupanca");
                ContaMauricioPoupanca.Depositar(deposito);
                System.Console.WriteLine(ContaMauricioPoupanca.Saldo);

                Console.WriteLine($"saque de {saque} na conta poupanca");
                ContaMauricioPoupanca.Sacar(saque);
                System.Console.WriteLine(ContaMauricioPoupanca.Saldo);

                
                Console.WriteLine($"criando conta corrente {mauricio} \nSaldo:");
                Classes.Conta contaMauricioCorrente = new Corrente(mauricio, 445852, 1000);
                System.Console.WriteLine(contaMauricioCorrente.Saldo);

                Console.WriteLine($"deposito de {deposito} na conta corrente");
                contaMauricioCorrente.Depositar(deposito);
                System.Console.WriteLine(contaMauricioCorrente.Saldo);

                Console.WriteLine($"saque de {saque} na conta corrente");
                contaMauricioCorrente.Sacar(saque);
                System.Console.WriteLine(contaMauricioCorrente.Saldo);


                Console.WriteLine("criando conta corrente novo cliente");
                Classes.Conta contaBrunaoCorrente = new Corrente(brunao, 445852, 10);
                Console.WriteLine("criando conta poupanca novo cliente");
                Classes.Conta ContaBrunaoPoupanca = new Poupanca(brunao, 445852, 0);

                Console.WriteLine("Saldo conta corrente:");
                Console.WriteLine(contaBrunaoCorrente.Saldo);
                ContaMauricioPoupanca.Transferir(500, contaBrunaoCorrente, ContaMauricioPoupanca.Saldo);
                Console.WriteLine("Novo Saldo:");
                Console.WriteLine(contaBrunaoCorrente.Saldo);
            }
            catch (System.Exception ex) { System.Console.WriteLine(ex.Message); }
        }
    }
}
