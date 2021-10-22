using System;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Api.Models
{
    public class Filme
    {
        //public int Id { get; set; }
        [Required] ////Validação eficiente sem sobrecarregar a controller
        public string Titulo { get; set; }

        [Required]
        public string Diretor { get; set; }

        [Required]
        public string Genero { get; set; }

        [Required]
        [Range(1, 5600)] ////Validação eficiente sem sobrecarregar tempo de exibição do filme
        public string Duracao { get; set; }
    }
}