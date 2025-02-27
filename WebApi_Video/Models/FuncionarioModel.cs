﻿using WebApi_Video.Enums;

namespace WebApi_Video.Models
  
{
    public class FuncionarioModel
    {
        public  int id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DepartamentoEnum Departamento { get; set; }
        public bool Ativo { get; set; }
        public TurnoEnum turno{ get; set; }
        public DateTime DataDeCriacao{ get; set; } =DateTime.Now.ToLocalTime();
        public DateTime DataDeAlteracao { get; set; } = DateTime.Now.ToLocalTime();


    }
}
