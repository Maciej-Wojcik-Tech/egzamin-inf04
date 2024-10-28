using System.ComponentModel.DataAnnotations;

namespace baza_danych.Models
{
    public class Samochody
    {
        public int SamochodyID { get; set; }
//ustawianie ID samochodu
        [Required(ErrorMessage = "Wymagane podanie Imienia")]// Wymag podania Imienia
        public string Marka { get; set; }
        //kolumna Marka Samochodu
        [Required(ErrorMessage = "Wymagane podanie Nazwiska")] // Wymaga podania Nazwiska
        public string Model { get; set; }
        //kolumna Model
        [EmailAddress(ErrorMessage = "Nieprawidłowy adres e-mail")]
        public int Rocznik { get; set; }
            //rocznik
    }
}
