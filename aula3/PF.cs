using System;

class PF : Cliente
{
    public string Cpf { get; set; }
    public TipoEstadoCivil EstadoCivil { get; set; }

    public PF(string nome, string telefone, string email, string endereco, string cpf, TipoEstadoCivil estadoCivil) : base(nome, telefone, email, endereco)
    {
        this.Cpf = cpf;
        this.EstadoCivil = estadoCivil;
    }

    public enum TipoEstadoCivil
    {
        Solteiro,
        Casado,
        Divorciado,
        Viuvo,
    }

    // A palavra reservada override é usada para indicar que o método sobrescrito esta sendo modificado

    public override void Info()
    {
        base.Info();
        Console.Write(this.Cpf + "\n" + this.EstadoCivil + "\n");
    }
}
