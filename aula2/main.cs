using System;

// using models.Conta;


class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Somando Valores: " + Calculadora.Somar(10, 20));
        Console.WriteLine("Criando Clientes: \n");
        //Cliente cliente1 = new Cliente("João", "11 99999-9999", "ztejd@example.com", "Rua A, 123");
        //Cliente cliente2 = new Cliente("Bruno", "11 99999-9999", "elchapo@example.com", "Rua B, 123");

        PF pf1 = new PF("MestreWill", "11 99999-9999", "111.111.111-11", "mestre@gmail.com", "Rua c,2121", PF.TipoEstadoCivil.Solteiro);

        PJ pj1 = new PJ("Empresa X", "11 99999-9999", "Empresa@gmail.com", "Rua d,2121", "3592651981", new DateOnly(2022, 01, 01));
        Console.WriteLine("Criando Contas: \n");

        Conta c1 = new Conta(123, pf1);
        Conta c2 = new Conta(456, pj1);

        c1.Info();
        c1.Depositar(100);
        c1.Info();
        c1.Sacar(100);
        c1.Depositar(300);
        c1.Info();
        c1.Transferir(100, c2);
        c1.Info();
        c2.Info();

        pf1.Info();

        Console.WriteLine("Quantidade de Contas c1: " + Conta.TotalDeContas);

    }
}
