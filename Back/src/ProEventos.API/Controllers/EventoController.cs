﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] { 
            new Evento(){
                EventoId = 1,
                Tema = "angular 11 e .NET 5",
                Local = "Curitiba",
                Lote = "1º lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "foto.png"
            },
            new Evento(){
                EventoId = 2,
                Tema = "angular 11 e suas novidades",
                Local = "Floripa",
                Lote = "2º lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImagemURL = "foto1.png"
            }
            };
        public EventoController()
        {            
        }

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
            return $"Exempo de Put com id ={id}";
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exempo de Delete com id = {id}";
        }
    }
}
