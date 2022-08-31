namespace src.Models;
using System.Collections.Generic;
public class Pessoa
{
    public Pessoa()
    {
        this.nome = "Padrão";
        this.idade = 0;
        this.cpf = "123";
        this.ativado = true;
        this.contratos = new List<Contrato>();
    }

    public Pessoa(string nome, int idade, string cpf){
        this.nome = nome;
        this.idade = idade;
        this.cpf = this.cpf;
        this.contratos = new List<Contrato>();
        this.ativado = true;
    }
    public int id { get; set; }
    public string nome {get; set;}
    public int idade {get; set;}
    public string? cpf { get; set; }
    public bool ativado { get; set; }

    public List<Contrato> contratos { get; set; }
}