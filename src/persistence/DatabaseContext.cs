using Microsoft.EntityFrameworkCore;
using src.Models;
namespace src.Persistence;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {

    }
    public DbSet<Pessoa> pessoas { get; set; }
    public DbSet<Contrato> contratos { get; set; }

    //Metodo de criação do modelo das tabelas. 
    protected override void OnModelCreating(ModelBuilder builder)
    {

        builder.Entity<Pessoa>(tabelaPessoa =>
        {

            tabelaPessoa.HasKey(entidadePessoa => entidadePessoa.id);

            //configuração para definir qual campo da tabela Pessoa faz a ligação com a tabela Contrato utilizando a chave estrangeira. 
            tabelaPessoa.HasMany(contrato => contrato.contratos).WithOne().HasForeignKey(contato => contato.pessoaID);
        });

        builder.Entity<Contrato>(tabelaContrato =>
        {
            tabelaContrato.HasKey(entidadeContrato => entidadeContrato.id);
        });
    }
}