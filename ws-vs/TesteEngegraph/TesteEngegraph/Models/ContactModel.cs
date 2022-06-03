using System;

namespace TesteEngegraph.Models
{
    public class ContactModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Sexo { get; set; }
        public TypeModel Tipo { get; set; }
        public Boolean Ativo { get; set; }
    }
}
