using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIAluno.Models
{
    [Table("Alunos")]
    public class Aluno
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Dt_Birth { get; set; }
    }
}
