using FilmesAPI.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace FilmesAPI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmeController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();


        [HttpPost] //Criar recurso no sistema
        public void AdcionarFilme([FromBody]Filme filme)
        {
            ////Validação simples e manual dos parâmetros recebidos, ineficiente --> sobrecarregar a controller
            //if (!string.IsNullOrEmpty(filme.Titulo))
            //    filmes.Add(filme);
            //else
            //    Console.WriteLine("Não pode ter titulo em branco");

            filmes.Add(filme);
            //Console.WriteLine(filme.Titulo);
        }



    }
}
