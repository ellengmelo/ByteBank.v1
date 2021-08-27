using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoThiago = new ContaCorrente();

            contaDoThiago.titular = "Thiago";

            Console.WriteLine(contaDoThiago.saldo);

            //tem que criar uma variável porque precisa retornar um valor
            bool resultadoSaque = contaDoThiago.Sacar(500);

            Console.WriteLine(contaDoThiago.saldo);
            Console.WriteLine(resultadoSaque);

            //sem retorno por isso não precisa criar uma variável
            contaDoThiago.Depositar(500);
            Console.WriteLine(contaDoThiago.saldo);

            ContaCorrente contaDaEllen = new ContaCorrente();

            contaDaEllen.titular = "Ellen";

            Console.WriteLine("Saldo do Thiago: " + contaDoThiago.saldo);
            Console.WriteLine("Saldo da Ellen: " + contaDaEllen.saldo);

            bool resultadoTranferencia = contaDoThiago.Transferir(200, contaDaEllen);

            Console.WriteLine("Saldo do Thiago: " + contaDoThiago.saldo);
            Console.WriteLine("Saldo da Ellen: " + contaDaEllen.saldo);

            Console.WriteLine(resultadoTranferencia);
            Console.ReadLine();
        }
    }
}
