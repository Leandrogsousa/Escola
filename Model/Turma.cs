using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Atividade> Atividades { get; set; }
    }
}
