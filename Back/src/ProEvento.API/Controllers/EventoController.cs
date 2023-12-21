using Microsoft.AspNetCore.Mvc;
using ProEvento.API.Models;
using ProEventos.API.Data;

namespace ProEvento.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    // public IEnumerable<Evento>_evento = new Evento[]
    // {
    //     new Evento()
    //     {   
    //         EventoId = 1,
    //         Tema = "Angular 11 e .Net 5",
    //         Local = "Belo Horizonte",
    //         Lote = "1° Lote",
    //         QtdPessoas = 250,
    //         DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
    //         ImagemURL ="foto.png"
    //     },
    //     new Evento(){   
    //         EventoId = 2,
    //         Tema = "Angular e suas Novidades",
    //         Local = "São Paulo",
    //         Lote = "2° Lote",
    //         QtdPessoas = 350,
    //         DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
    //         ImagemURL ="fot2.png"
    //     }
           
    // };

    private readonly DataContext _context;
    public EventoController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IEnumerable <Evento> Get()
    {
        return _context.Eventos;
    }

[HttpGet("{id}")]
    public IEnumerable <Evento> GetById(int id){
        return _context.Eventos.Where(evento=>evento.EventoId==id);
    }

     [HttpPost]
    public string Post()
    {
        return "Exemplo Post";
    }


     [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"Exemplo Put {id}";
    }

     [HttpDelete("{id}")]
    public string Delete(int id)
    {
       return $"Exemplo Delete {id}";
    }

}
