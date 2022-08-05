using CL.Core.Domain;
using CL.Data.Context;
using CL.Manager;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CL.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ClContext context;

        public ClienteRepository(ClContext context)
        {
            this.context = context;           
        }

        public async Task<IEnumerable<Cliente>> GetClientesAsync()
        {
            return await context.Clientes.AsNoTracking().ToListAsync();
        }

        public async Task<Cliente> GetClientesAsync(int Id)
        {
            return await context.Clientes.FindAsync(Id);
        }   
   
    }
}
