namespace Lanches.MVC.Core.Models
{
    public class LanchesModels
    {
        public int ID { get; set; }
        public string Cliente { get; set; }
        public string Lanche { get; set; }
        public DateTime DataUltimaAtualizacao { get; set; } = DateTime.Now;

    }
}
