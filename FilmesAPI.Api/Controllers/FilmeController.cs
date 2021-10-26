using FilmesAPI.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FilmesAPI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmeController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();
        private static int id = 1;


        [HttpPost] //Criar recurso no sistema
        public IActionResult AdcionarFilme([FromBody]Filme filme)
        {
            filme.Id = id++;
            filmes.Add(filme);
            return CreatedAtAction(nameof(RecuperaFilmePorId), new { Id = filme.Id}, filme); // Código de status(201)--> Ok - Retornando o status da requisição e onde o recurso foi criado no formato Json
        }


        [HttpGet] //Retorna recurso do sistema
        public IActionResult RecuperaFilme()
        {  
            return Ok(filmes);
        }


        [HttpGet("{id}")] //Retorna recurso do sistema por ID
        public IActionResult RecuperaFilmePorId(int id)
        {
            //return filmes.FirstOrDefault(filme => filme.Id ==id); //Recurso da sintax c# -> using System.Linq;
            Filme filme = filmes.FirstOrDefault(filme => filme.Id ==id);
            if (filme != null)
            {
                Ok(filme); //Código de status (200)--> Ok - Retornando uma lista de livros no formato Json
            }
            return NotFound(); //Código de status (404)-->not found
        }
    }
}
