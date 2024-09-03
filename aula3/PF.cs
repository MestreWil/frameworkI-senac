using System;

class PJ : Cliente {

   public string Cnpj { get; set; }
   public DateOnly DataAbertura { get; set; }

    public PJ(string nome, string telefone, string email, string endereco, string cnpj, DateOnly dataAbertura) : base(nome, telefone, email, endereco){
      this.Cnpj = cnpj;
      this.DataAbertura = dataAbertura;
    }

  public override void Info(){
    base.Info();
    Console.Write(this.Cnpj + "\n" + this.DataAbertura + "\n");
    Console.WriteLine("Data de Abertura: " + this.DataAbertura.ToString("dd/MM/yyyy"));
  }
}
