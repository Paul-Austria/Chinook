using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Persistence
{
    public interface IEmployee : IIdentifiable
    {
        string LastName { get; set; }
        string FirstName { get; set; }
        string Title { get; set; }
        string ReportsTo { get; set; }
        string BirthDate { get; set; }
        string HireDate { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string State { get; set; }
        string Country { get; set; }
        string PostalCode { get; set; }
        string Phone { get; set; }
        string Fax { get; set; }
        string Email { get; set; }
    }
}
