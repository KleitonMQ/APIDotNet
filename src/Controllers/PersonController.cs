// Maneira de declarar que será usado o aspnet core.
using Microsoft.AspNetCore.Mvc;
using src.Models;
using src.Persistence;
using Microsoft.EntityFrameworkCore;
//Endereço de memoria virutal (o nome não faz diferença, usado dessa forma apenas para melhor interpretação)
namespace src.Controllers;

//Esta declaração indica ao .net que esta clase será uma API.
[ApiController]

//Rota de acesso, usando o nome controller declarando dessa forma, ele vai utilizar a rota como o nome da classe sem usar a palavra controller.
[Route("[controller]")]
public class PersonController : ControllerBase
{
    private DatabaseContext _context { get; set; }

    public PersonController(DatabaseContext context)
    {
        this._context = context;
    }

    //antes de qualquer método precisa dizer que tipo de requisição http ele vai usar.
    [HttpGet] //Selecionar dados
    public ActionResult<List<Pessoa>> Get()
    {
        var result = _context.pessoas.Include(p => p.contratos).ToList();

        if (result.Any()) return Ok(result);

        return NoContent();

    }

    [HttpPost] //Enviar dados
    public Pessoa Post([FromBody] Pessoa pessoa)
    {
        _context.pessoas.Add(pessoa);
        _context.SaveChanges();
        return pessoa;
    }

    [HttpPut("{id}")] //Atualizar informações
    public string Update([FromRoute] int id, [FromBody] Pessoa pessoa)
    {
        _context.pessoas.Update(pessoa);
        _context.SaveChanges();
        return "Dados do ID " + id + " atualizados.";
    }

    [HttpDelete("{id}")] //Deletar dados.
    public ActionResult<Object> Delete([FromRoute] int id)
    {
        var result = _context.pessoas.SingleOrDefault(e => e.id == id);

        if (result is null) return BadRequest(new {msg = "ID inesistente."});

        _context.pessoas.Remove(result);
        _context.SaveChanges();
        return Ok(new {msg = "deleteado pessoa de ID " + id});
    }
}