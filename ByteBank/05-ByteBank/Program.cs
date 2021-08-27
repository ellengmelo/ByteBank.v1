using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente ellen = new Cliente();

            ellen.nome = "Ellen";
            ellen.profissao = "Desenvolvedora C#";
            ellen.cpf = "383.341.628-98";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = ellen;
            conta.saldo = 500;
            conta.agencia = 563;
            conta.conta = 222;

            Console.WriteLine(ellen.nome);
            Console.WriteLine(conta.titular.nome);


            Console.ReadLine();

        }
    }
}
