using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeEsperaPacientes.Models
{
    public class Paciente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Paciente")]
        public string Nome { get; set; }


        [Required]
        [StringLength(15)]
        [DisplayName("Telefone")]
        public string Telefone { get; set; }


        [Required]
        [StringLength(50)]
        [EmailAddress(ErrorMessage = "Digite um e-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }


        [Required]
        [DisplayName("Data do Cadastro")]
        public DateTime DataCadastro { get; set; }

        [StringLength(200)]
        public string Observacao { get; set; }


        [DisplayName("Foi Agendado?")]
        public bool Finalizado { get; set; } = false;

    }
}
