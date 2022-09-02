using System;
using System.ComponentModel.DataAnnotations;

namespace PontosTuristicos.Models
{
    public class Pontos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [MaxLength(100)]
        public string Descricao { get; set; }
        public string Localizacao { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
