using ChellengeRemitee.DTOs;
using ChellengeRemitee.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChellengeRemitee.Services
{
    public interface ICuentaService
    {
        Task<ServiceResponse<GetSaldoResponse>> ExtraerSaldo(int id, decimal cantidad);
        Task<ServiceResponse<GetSaldoResponse>> GetSaldoById(int id);
    }
}
    