public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int conta;
    public double saldo = 100;


    //função com retorno
    public bool Sacar(double valor)
    {
        if (this.saldo < valor)
        {
            return false;
        }
      
        this.saldo -= valor;
        return true;
 
    }

    //método sem retorno
   public void Depositar(double valor)
    {
        this.saldo += valor;
    }


    //método com varios argumentos
    public bool Transferir(double valor,ContaCorrente contaDestino)
    {
        if (this.saldo < valor)
        {
            return false;
        }
       
        this.saldo -= valor;
        contaDestino.Depositar(valor);
        return true;
    }
}