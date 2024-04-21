using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EditorTexto.Models
{
    public class Documento
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o Título")]
        public string Titulo { get; set; } = string.Empty;

        [Required(ErrorMessage = "Digite o Conteúdo")]
        public string Conteudo { get; set; } = string.Empty;
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;
    }
}