﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Usuario { get; set; } 
        public string Senha { get; set; }

        public List<Turma> Turmas { get; set; }


    }
}

