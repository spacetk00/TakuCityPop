using System;

namespace TakuCityPop.Models
{
    public class Usuario
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Email {get; set;}
        public DateTime DataNascimento {get; set;}
    }
}