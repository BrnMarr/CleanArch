using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Entities
{
    public class Perfil
    {
        [Key]
        public int idPerfil { get; set; }        
        public int idUsuario { get; set; }
       //ublic int? idTipoPerfil { get; set; }
        public string Nome { get; set; }
       // public DateTime? DataExpiracao { get; set; }
      //  public DateTime? HorarioInicio { get; set; }
      //  public DateTime? HorarioFim { get; set; }
     // public bool SemanaTodos { get; set; }
     // public bool Segunda { get; set; }

     // public bool Quarta { get; set; }
 
     // public bool Quinta { get; set; }
 
     // public bool Sexta { get; set; }
   
     // public bool Sabado { get; set; }

     // public bool Domingo { get; set; }
    
     // public bool Feriado { get; set; }
   
     // public bool Alteracao { get; set; }
   
     // public bool Inserir { get; set; }
     // public bool Deletar { get; set; }

     // public bool Consultar { get; set; }

     // public bool Ativo { get; set; }
       
    }
}
