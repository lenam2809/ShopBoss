using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebAPI.Entities;
using WebAPI.Models;
using WebAPI.Repository;

namespace WebAPI.Services
{
    public class CustomerService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Customer> _customerRepository;

        public CustomerService(IMapper mapper, IRepository<Customer> customerRepository)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }

        public async Task<List<CustomerDTO>> GetCustomersAsync()
        {
            var customers = await _customerRepository.GetAll().ToListAsync();
            return _mapper.Map<List<CustomerDTO>>(customers);
        }

        public async Task<CustomerDTO> GetCustomerByIdAsync(Guid customerId)
        {
            var customer = await _customerRepository.GetByIdAsync(customerId);
            return _mapper.Map<CustomerDTO>(customer);
        }

        public async Task AddCustomerAsync(CustomerDTO customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);
            await _customerRepository.AddAsync(customer);
        }

        public async Task UpdateCustomerAsync(CustomerDTO customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);
            await _customerRepository.UpdateAsync(customer);
        }

        public async Task DeleteCustomerAsync(CustomerDTO customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);
            await _customerRepository.DeleteAsync(customer);
        }
    }
}
