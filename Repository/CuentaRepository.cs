using ChellengeRemitee.Context;
using ChellengeRemitee.Models;
using Microsoft.EntityFrameworkCore;

namespace ChellengeRemitee.Repository
{
    public class CuentaRepository : ICuentaRespository
    {
        private readonly DataContext _dataContext;

        public CuentaRepository(DataContext dataContext)
        {

            _dataContext = dataContext;

        }
        public async Task<Cuenta?> GetCuentaById(int id)
        {
            return await _dataContext.Cuentas.FirstOrDefaultAsync(c => c.id == id);

        }

        public async Task<int> UpdateCuenta(Cuenta cuenta)
        {
            _dataContext.Cuentas.Update(cuenta);
            return await _dataContext.SaveChangesAsync();
            
        }
    }
}
