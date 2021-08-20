using System;
using System.Collections.Generic;
using System.Text;
using ExamenP3PM2.Models;
using System.Threading.Tasks;
namespace ExamenP3PM2.Services
{
    public interface repPagos
    {
        Task<bool> AddPagoAsync(Pagos pago);

        Task<bool> UpdatePagoAsync(Pagos pago);
        Task<bool> DeletePagoAsync(int id);
       

        Task<IEnumerable<Pagos>> GetPagosAsync();

    }
}
