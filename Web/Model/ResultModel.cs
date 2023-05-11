using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Model
{
    public class ResultModel
    {
        public int Id { get; set; }
        public string OutputUrl { get; set; }
        public string DeleteToken { get; set; }
        public DateTime DateCreated { get; set; }

        //public DateTime TokenDuration { get; set; }
        [ForeignKey("UrlModel")]
        public int UrlModelId { get; set; }

    }
}
