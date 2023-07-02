using ChellengeRemitee.Models;

namespace ChellengeRemitee.Repository
{
    public interface ICuentaRespository
    {
        Task<Cuenta?> GetCuentaById(int id);
        Task<int> UpdateCuenta(Cuenta cuenta);

    }
}
