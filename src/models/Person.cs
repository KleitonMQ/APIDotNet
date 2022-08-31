namespace src.Models;

public class Pessoa
{
    public Pessoa()
    {
        this.Nome = "Padrão";
        this.Idade = 0;
        this.Cpf = "123";
        this.Ativado = false;
    }

    public Pessoa(string Nome, int Idade, string cpf){
        this.Nome = Nome;
        this.Idade = Idade;
        this.Cpf = Cpf;
    }
    public string Nome {get; set;}
    public int Idade {get; set;}
    public string? Cpf { get; set; }
    public bool Ativado { get; set; }
}