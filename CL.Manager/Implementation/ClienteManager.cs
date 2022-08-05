using CL.Core.Domain;
using CL.Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CL.Manager.Implementation
{
    public class ClienteManager : IClienteManager
    { 
        private IClienteRepository clienteRepository;

        public ClienteManager(IClienteRepository clienteRepository)
        {
            this.clienteRepository = clienteRepository;                                
        }

        public async Task<IEnumerable<Cliente>> GetClientesAsync()
        {
            return await clienteRepository.GetClientesAsync();
        }

        public async Task<Cliente> GetClientesAsync(int Id)
        {
            return await clienteRepository.GetClientesAsync(Id);
        }

        public async Task DeleteClienteAsync(int Id)
        {
            await clienteRepository.DeleteClienteAsync(Id);
        }

        public async Task<Cliente> InsertClienteAsync(Cliente cliente)
        {
            return await clienteRepository.InsertClienteAsync(cliente);
        }

        public async Task<Cliente> UpdateClienteAsync(Cliente cliente)
        {
            return await clienteRepository.UpdateClienteAsync(cliente);
        }
    }
}
