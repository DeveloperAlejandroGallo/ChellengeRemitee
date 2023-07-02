using AutoMapper;
using ChellengeRemitee.DTOs;
using ChellengeRemitee.Models;
using ChellengeRemitee.Repository;


namespace ChellengeRemitee.Services
{
    public class CuentaService : ICuentaService
    {
        private ICuentaRespository _cuentaRepository;
        IMapper _mapper; 

        public CuentaService(ICuentaRespository cuentaRespository, IMapper mapper) {
            _cuentaRepository = cuentaRespository;
            _mapper = mapper;
        }


        public async Task<ServiceResponse<GetSaldoResponse>> ExtraerSaldo(int id, decimal cantidad)
        {
            var result = new ServiceResponse<GetSaldoResponse>();
            try
            {
                var cuenta = await _cuentaRepository.GetCuentaById(id);

                if (cuenta != null)
                {
                    cuenta.saldo -= Math.Abs(cantidad); //por si manda un neg
                    
                    var resultActualiza = await _cuentaRepository.UpdateCuenta(cuenta);

                    if(resultActualiza == 0)
                    {
                        result.Success = false;
                        result.Message = "No se actualizao la cta en la bd";
                        return result;
                    }
                    result.Data = _mapper.Map<GetSaldoResponse>(cuenta);
                }
                else
                {
                    result.Success = false;
                    result.Message = "No se encontró la cuenta";
                }

            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = ex.Message;
            }
            return result;
        }

        public async Task<ServiceResponse<GetSaldoResponse>> GetSaldoById(int id)
        {
            var result = new ServiceResponse<GetSaldoResponse>();
            try
            {
                var cuenta = await _cuentaRepository.GetCuentaById(id);

                if (cuenta != null)
                {
                    result.Data = _mapper.Map<GetSaldoResponse>(cuenta);

                }
                else
                {
                    result.Success = false;
                    result.Message = "No se encontró la cuenta";
                }

            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = ex.Message;
            }
            return result;
        }
    }
}
