using System;

public class Cliente{
  public string Nome {get; set;}
  public string Telefone {get; set;}
  public string Email {get; set;}
  public string Endereco {get; set;}

  public Cliente(string nome, string telefone, string email, string endereco){
    this.Nome = nome;
    this.Telefone = telefone;
    this.Email = email;
    this.Endereco = endereco;
  }

  public void Info(){
    Console.Write("Nome: " + this.Nome + "\n" + this.Telefone + "\n" + this.Email + "\n" + this.Endereco);
  }
}