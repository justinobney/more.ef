using System.Collections.Generic;
using System.Linq;
using Data;
using Data.Helpers;
using Envoc.Mediator;

namespace Domain.Customers
{
    public class GetAllCustomerQueryHandler : IQueryHandler<GetAllQuery<Customer>, IEnumerable<Customer>>
    {
        private readonly MyContext context;

        public GetAllCustomerQueryHandler()
        {
            context = new MyContext();
        }
        public IEnumerable<Customer> Handle(GetAllQuery<Customer> query)
        {
            return context.Customers.ToList();
        }
    }
}