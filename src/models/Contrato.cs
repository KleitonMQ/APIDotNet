namespace src.Models;

public class Contrato
{

    public Contrato()
    {
        this.dataCriacao = DateTime.Now;
        this.valor = 0;
        this.tokenId = "00000";
        this.pago = false;
    }

    public Contrato(string tokenId, double valor)
    {
        this.dataCriacao = DateTime.Now;
        this.tokenId = tokenId;
        this.valor = valor;
        this.pago = false;
    }
    public int id { get; set; }
    public DateTime dataCriacao { get; set; }
    public string tokenId { get; set; }
    public double valor { get; set; }
    public bool pago { get; set; }
    public int pessoaID { get; set; }
}