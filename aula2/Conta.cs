using System;
//public - outras classes podem ter o tipo Conta
// por padrao as classes tem atributos private

// primeiro bibliotecas, depois define os atributos da classe e depois o metodo construtor
public class Conta
{
    // get e set - get e set sao metodos que retornam e atribui valores
    //Get e set letra maiuscula e fazemos em uma funcao so

    private int numero;
    public int Numero
    {
        get
        {
            return this.numero;
        }
        set
        {
            this.numero = value;
        }
    }
    // get e set alto implementado
    public double Saldo { get; private set; }

    public Cliente Titular { get; set; }

    // Declara o metodo construtor

    public Conta(int numero, Cliente titular)
    {
        this.Numero = numero;
        this.Titular = titular;
        this.Saldo = 0;
    }




    public void Info()
    {
        Console.WriteLine("Numero: " + this.Numero);
        Console.WriteLine("Saldo: " + this.Saldo);
        Titular.Info();
    }

    public void Depositar(double valor)
    {
        this.Saldo += valor;
    }
    public void Sacar(double valor)
    {
        if (this.Saldo >= valor)
        {
            this.Saldo -= valor;
            Console.WriteLine("Saque feito com sucesso. SALDO ATUAL:" + this.Saldo);
        }
        else
        {
            Console.WriteLine("Saldo insuficiente. SEU SALDO ATUAL:" + this.Saldo);
        }
    }
    public void Transferir(double valor, Conta destino){
        if (Saldo >= valor)
        {
            Saldo -= valor;
            destino.Depositar(valor);
            Console.WriteLine("Transferencia feita com sucesso. SALDO ATUAL:" + this.Saldo);
        }
        else 
        {
            Console.WriteLine("Saldo insuficiente. SEU SALDO ATUAL:" + this.Saldo);
        }
    }
}
