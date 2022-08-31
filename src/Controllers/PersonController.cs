// Maneira de declarar que será usado o aspnet core.
using Microsoft.AspNetCore.Mvc;
using src.Models;
//Endereço de memoria virutal (o nome não faz diferença, usado dessa forma apenas para melhor interpretação)
namespace src.Controllers;

//Esta declaração indica ao .net que esta clase será uma API.
[ApiController] 

//Rota de acesso, usando o nome controller declarando dessa forma, ele vai utilizar a rota como o nome da classe sem usar a palavra controller.
[Route("[controller]")] 
public class PersonController : ControllerBase{
//antes de qualquer método precisa dizer que tipo de requisição http ele vai usar.
[HttpGet] //Selecionar dados
public Pessoa Get(){
    Pessoa pessoa = new Pessoa("eu", 15, "654321");
    Contrato novoContrato = new Contrato("abc123", 20.13);
    pessoa.contratos.Add(novoContrato);
    return pessoa;
}

[HttpPost] //Enviar dados
public Pessoa Post([FromBody]Pessoa pessoa){
    
    return pessoa;
}

[HttpPut("{id}")] //Atualizar informações
public string Update([FromRoute]int id){
    return "Dados do ID " + id +" atualizados.";
}

[HttpDelete("{id}")] //Deletar dados.
public string Delete([FromRoute]int id){
    return "deleteado pessoa de ID "+ id;
}
}