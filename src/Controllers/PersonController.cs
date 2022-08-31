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
[HttpGet]
public Pessoa Get(){
    Pessoa pessoa = new Pessoa("eu", 15, "654321");

    return pessoa;
}
}