using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace ExamenP3PM2.Models
{
   public class Pagos
    {
           [PrimaryKey, AutoIncrement]
        public int Id_pago { get; set; }
        public String Descripcion { get; set; }
        public Double Monto { get; set; }

     
        public String Fecha { get; set; } = DateTime.Now.ToString("dd/MM/yyyy");

    }
}
