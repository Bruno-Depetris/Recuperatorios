using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorios.Recup_Parcial2 {
    public class Venta {
      
    public int Id { get; set; }
    public int PerfumeId { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Cuit { get; set; }
    public int Cantidad { get; set; }


    }
}
