using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Model
{
    public class OutputUrl
    {
        public int Id { get; set; }
        public string RedirectUrl { get; set; }
        public string DeleteToken { get; set; }
        public DateTime DateCreated { get; set; }

        //public DateTime TokenDuration { get; set; }
        [ForeignKey("InputModelId")]
        public int InputModelId { get; set; }

    }
}
