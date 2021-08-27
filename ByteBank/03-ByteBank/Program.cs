using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaEllen = new ContaCorrente();

            contaDaEllen.titular = "Ellen";
            contaDaEllen.agencia = 001;
            contaDaEllen.conta = 222;

            ContaCorrente contaDaEllenMelo = new ContaCorrente();

            contaDaEllenMelo.titular = "Ellen";
            contaDaEllenMelo.agencia = 001;
            contaDaEllenMelo.conta = 222;

            Console.WriteLine("Igualdade de tipo de referência: " + (contaDaEllen == contaDaEllenMelo));

            int idade = 29;
            int idade2 = 29;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idade2));

            contaDaEllen = contaDaEllenMelo;
            Console.WriteLine(contaDaEllen == contaDaEllenMelo);

            contaDaEllen.saldo = 300;
            Console.WriteLine(contaDaEllen.saldo);
            Console.WriteLine(contaDaEllenMelo.saldo);



            Console.ReadLine();


        }
    }
}
