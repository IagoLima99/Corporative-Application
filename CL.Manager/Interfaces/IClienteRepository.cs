using CL.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CL.Manager
{
    public interface IClienteRepository
    {
       Task<IEnumerable<Cliente>> GetClientesAsync();
       Task<Cliente> GetClientesAsync(int Id);
    }
}
