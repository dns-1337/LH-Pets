using LHPets.Models;
using Microsoft.AspNetCore.Mvc;

namespace LHPets.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PetsController : ControllerBase
{
    private static List<Pet> pets = new List<Pet>();

    [HttpGet]
    public IActionResult GetPets()
    {
        return Ok(pets);
    }

    [HttpPost]
    public IActionResult PostPet(Pet pet)
    {
        pet.Id = pets.Count + 1;
        pets.Add(pet);
        return Ok(pet);
    }

    [HttpGet("cliente/{clienteId}")]
    public IActionResult GetPetsPorCliente(int clienteId)
    {
        var petsDoCliente = pets.Where(p => p.ClienteId == clienteId).ToList();
        return Ok(petsDoCliente);
    }
}
