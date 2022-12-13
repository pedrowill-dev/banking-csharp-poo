using System.Globalization;

namespace Exercicio1
{

    class Program
    {

        static void Main(string[] args)
        {
            int acc;
            string titular;
            double valorInicial;
            char deposito;
            Account account;

            Console.Write("Entre o numero da conta: ");
            acc = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            deposito = char.Parse(Console.ReadLine());


            if (deposito == 's') {
                Console.WriteLine("Entre o valor de depósito inicial: ");
                valorInicial = double.Parse(Console.ReadLine());
                account = new Account(acc, titular, valorInicial);
            } else {
                account = new Account(acc, titular);
            }

            Console.WriteLine("Dados da conta: ");
            Console.Write(account);

            Console.WriteLine("Entre um valor para depósito: ");
            valorInicial = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados da conta atualizados:");
            account.DepositoAccount(valorInicial);
            Console.WriteLine(account);

            Console.WriteLine("Entre um valor saque: ");
            valorInicial = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados da conta atualizados:");
            account.SaqueAccount(valorInicial);
            Console.WriteLine(account);




        }
    }
}
