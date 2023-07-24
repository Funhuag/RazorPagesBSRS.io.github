using System.ComponentModel.DataAnnotations;

namespace RazorPagesBSRS.Model
{
    public class BSRS
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="請輸入此欄位")]
        [MaxLength(8,ErrorMessage ="請輸入8碼")]
        [MinLength(8,ErrorMessage ="最多輸入8碼")]
        public string PatientID { get; set; } = string.Empty;

        [Required(ErrorMessage ="請輸入此欄位")]
        [MinLength(6, ErrorMessage = "最少輸入6碼")]
        [MaxLength(7,ErrorMessage ="最多輸入7碼")]
        public string Professionalnum { get; set; } = string.Empty;

        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public int Score3 { get; set; }
        public int Score4 { get; set; }
        public int Score5 { get; set; }
        public int Score6 { get; set; }

        public DateTime Time { get; set; }
    }
}
