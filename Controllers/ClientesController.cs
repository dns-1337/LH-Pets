using LHPets.Models;
using Microsoft.AspNetCore.Mvc;

namespace LHPets.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientesController : ControllerBase
{
    // static para a lista continuar na memoria entre as requisicoes
    private static List<Cliente> clientes = new List<Cliente>();

    [HttpGet]
    public IActionResult GetClientes()
    {
        return Ok(clientes);
    }

    [HttpPost]
    public IActionResult PostCliente(Cliente cliente)
    {
        cliente.Id = clientes.Count + 1;
        clientes.Add(cliente);
        return Ok(cliente);
    }
}
