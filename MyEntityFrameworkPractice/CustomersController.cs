using MyEntityFrameworkPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEntityFrameworkPractice {
    public class CustomersController {

        private readonly ZsalesDbContext _context;

        public CustomersController() {
            _context = new ZsalesDbContext();
        }

        public Customer GetByID(int id) {
            var customer = _context.Customers.Find(id);
            if (customer == null) {
                throw new Exception("Id not found!");
            }
            return customer;
        }

        public List<Customer> GetAll() {
            return _context.Customers.ToList();
        }

    }
}
