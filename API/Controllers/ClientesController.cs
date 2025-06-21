using System;
using Core.Entities;
using Infraestructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientesController : ControllerBase
{
    private readonly StoreContext _context;

    public ClientesController(StoreContext context)
    {
        _context = context;
    }

    // GET: api/clientes
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
    {
        return await _context.Clientes.ToListAsync();
    }

    // GET: api/clientes/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Cliente>> GetCliente(int id)
    {
        var cliente = await _context.Clientes.FindAsync(id);

        if (cliente == null)
        {
            return NotFound();
        }

        return cliente;
    }

    // POST: api/clientes
    [HttpPost]
    public async Task<ActionResult<Cliente>> CreateCliente(Cliente cliente)
    {
        _context.Clientes.Add(cliente);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetCliente), new { id = cliente.Id }, cliente);
    }
}