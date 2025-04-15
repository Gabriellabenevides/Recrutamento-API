﻿namespace Recrutamento.Domain.Entities
{
    public class Candidato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string CurriculoUrl { get; set; }

        public ICollection<ProcessoSeletivo> ProcessosSeletivos { get; set; }
    }
}
