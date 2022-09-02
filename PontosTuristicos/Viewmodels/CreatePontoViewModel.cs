using System.ComponentModel.DataAnnotations;

namespace PontosTuristicos.Viewmodels
{
    public class CreatePontoViewModel
    {
        [Required]
        public string Nome { get; set; }
        public string Localizacao { get; set; }
        public string Descricao { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
