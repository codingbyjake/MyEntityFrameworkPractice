using MyEntityFrameworkPractice;
using MyEntityFrameworkPractice.Models;
using System.Linq;

var custCtrl = new CustomersController();

var customer = custCtrl.GetByID(36);
Console.WriteLine(customer);

var customers = custCtrl.GetAll().OrderBy(x => x.Name);
foreach(Customer c in customers) {
    Console.WriteLine(c);
}