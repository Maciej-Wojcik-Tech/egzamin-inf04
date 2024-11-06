using System.ComponentModel.DataAnnotations;

namespace ZBazamiDanychProjekt.Models
{
    public class Zadanie
    {
        public int Id { get; set; }

        [Required]
        public int Waznosc { get; set; }

        [Required]
        public int Grupa { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data wykonania")]
        public DateTime? DataWykonania { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data przypomnienia")]
        public DateTime? DataPrzypomnienia { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data zakończenia")]
        public DateTime? DataZakonczenia { get; set; }

        public string Tresc { get; set; }
    }
}