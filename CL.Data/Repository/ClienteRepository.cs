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
        
        public async Task<Cliente> InsertClienteAsync(Cliente cliente)
        {
            await context.Clientes.AddAsync(cliente);
            await context.SaveChangesAsync();
            return cliente;
        }

        public async Task<Cliente> UpdateClienteAsync(Cliente cliente)
        {
            var clienteConsultado = await context.Clientes.FindAsync(cliente.Id);
            if (clienteConsultado == null)
            {
                return null;
            }
            context.Entry(clienteConsultado).CurrentValues.SetValues(cliente);
            await context.SaveChangesAsync();
            return clienteConsultado;
        }

        public async Task DeleteClienteAsync(int Id)
        {
            var clienteConsultado = await context.Clientes.FindAsync(Id);
            context.Clientes.Remove(clienteConsultado);
            await context.SaveChangesAsync();
        }
    }
}
