using System;

// using models.Conta;


class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Criando Clientes: \n");
        Cliente cliente1 = new Cliente("João", "11 99999-9999", "ztejd@example.com", "Rua A, 123");
        Cliente cliente2 = new Cliente("Bruno", "11 99999-9999", "elchapo@example.com", "Rua B, 123");
        Console.WriteLine("Criando Contas: \n");

        Conta c1 = new Conta(123, cliente1);

        c1.Info();
        c1.Depositar(100);
        c1.Info();
        c1.Sacar(100);
    }
}