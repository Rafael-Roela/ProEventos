using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] {
                new Evento {
                    EventoId = 1,
                    Local = "Belo Horizonte",
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    Tema = "Angular 11 + .Net5",
                    QtdPessoas = 250,
                    Lote = "1° Lote"
                },
                new Evento {
                    EventoId = 2,
                    Local = "São Paulo",
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    Tema = "Angular 12 + .Net7",
                    QtdPessoas = 275,
                    Lote = "2° Lote"
                }
            };
        public EventoController() {}

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
            
        }
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
            
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
    }
}