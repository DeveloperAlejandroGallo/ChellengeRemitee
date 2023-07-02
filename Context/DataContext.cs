using ChellengeRemitee.Models;
using Microsoft.EntityFrameworkCore;

namespace ChellengeRemitee.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Cuenta> Cuentas => Set<Cuenta>();

        //public List<Cuenta> CuentasList = new List<Cuenta> {
        //    new Cuenta {id = 1, saldo = 1000},
        //    new Cuenta {id = 2, saldo = 5000},
        //};

    }
}
