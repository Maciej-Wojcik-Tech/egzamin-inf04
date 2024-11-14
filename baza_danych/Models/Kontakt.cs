using System.ComponentModel.DataAnnotations;

namespace baza_danych.Models
{
    public class Kontakt
    {
        public int KontaktID { get; set; }
//tworzenie tabeli Kontakt
//tworzenie kolumny imie
        [Required(ErrorMessage = "Wymagane podanie Imienia")]// Wymag podania Imienia
        public string Imie { get; set; }
        //dodawanie kolumny nazwisko
        [Required(ErrorMessage = "Wymagane podanie Nazwiska")] // Wymaga podania Nazwiska
        public string Nazwisko { get; set; }
        //dodawanie kolumny e-mail
        [EmailAddress(ErrorMessage = "Nieprawidłowy adres e-mail")]
        public string Email { get; set; }

    }
}
