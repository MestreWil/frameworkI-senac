// Esta sendo usado/importado no projeto a biblioteca/classe System

using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Declarando Variáveis");
        int anoNascimento = 1998;
        long cod = 9582336623;
        bool solteiro = true;
        bool estaChovendo = false;
        char genero = 'M';
        char letra = '\u0041';
        float altura = 1.70f;
        double peso = 81.9;
        double salario = 15600.00;
        string nome = "William Tavares";
        Console.WriteLine(nome + " tem " + altura + " de altura");
        Console.WriteLine("{0} tem {1} de altura", nome, altura);

        /* Conversão */

        int novoSalario = (int)salario;
        Console.WriteLine(novoSalario + (novoSalario * 0.10));

        string sobrenome;
        Console.WriteLine("Digite seu sobrenome: ");
        sobrenome = Console.ReadLine();
        Console.WriteLine("Olá, " + nome + " " + sobrenome);

        int idade;
        Console.WriteLine("Digite sua idade: ");
        idade = int.Parse(Console.ReadLine());
        Console.WriteLine("Você tem " + idade + " anos");

        string frutas;
        Console.WriteLine("Digite suas frutas favoritas: ");
        frutas = Console.ReadLine();

        string[] listaFrutas = frutas.Split(' ');
        Console.WriteLine("Lista de Frutas com foreach");
        foreach (string fruta in listaFrutas) {
            Console.Write(fruta + " ,");
        }

        Console.WriteLine("Lista de Frutas com for");
        for(int i = 0; i < listaFrutas.Length; i++){
          Console.Write(listaFrutas[i] + " ,");
        }

      DateTime data = DateTime.Now;
      Console.WriteLine(data);

      if(data.Hour > 12){
        Console.WriteLine("Boa Dia");
      } else {
        Console.WriteLine("Bom dia!");
      }

      /* 
      variavel = condicional ? valor_verdadeiro : valor_falso;
      */

      string saudacao = data.Hour > 12 ? "Boa Dia" : "Bom dia!";
      Console.WriteLine(saudacao);
    }
}