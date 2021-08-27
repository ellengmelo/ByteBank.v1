using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaEllen = new ContaCorrente();

            contaDaEllen.titular = "Ellen";
            contaDaEllen.agencia = 001;
            contaDaEllen.conta = 222;
            contaDaEllen.saldo = 1000;

            Console.WriteLine(contaDaEllen.titular);
            Console.WriteLine("Agência: " + contaDaEllen.agencia);
            Console.WriteLine("Conta: " + contaDaEllen.conta);
            Console.WriteLine("Saldo: " + contaDaEllen.saldo);

            contaDaEllen.saldo += 200;
            Console.WriteLine("Saldo: " + contaDaEllen.saldo);
            
            
            
            Console.WriteLine("Fim da Execução!");
            Console.ReadLine();
        }
    }
}
