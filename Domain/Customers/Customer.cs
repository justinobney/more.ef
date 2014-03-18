using System.Collections.Generic;
using Envoc.Mediator;

namespace Domain.Customers
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
    }

    public class GetAllCustomerQuery : IQuery<ICollection<Customer>>
    {
    }

    public class GetAllCustomerQueryHandler : IQueryHandler<GetAllCustomerQuery, ICollection<Customer>>
    {
        public GetAllCustomerQueryHandler()
        {
            _context = new MyContext();
        }
        public ICollection<Customer> Handle(GetAllCustomerQuery query)
        {
            
        }
    }
}