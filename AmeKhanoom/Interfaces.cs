using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmeKhanoom
{
    interface Ifile
    {
        void Save();
        void Load();
        string Filepath { get; set; }
    }
    interface ISubs
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int SubsCode { get; set; }
        string PhoneNumber { get; set; }
        string CreditCardNumber { get; set; }
        void Add(string firstName, string lastName, string creditCardNumber, string phoneNumber, int subsCode);
        void Remove();
        void Edit(int subsCode, string firstName, string lastName, string creditCardNumber, string phoneNumber);
    }
    interface ICreditCard
    {
        void AddCredit(int subsCode, int credit);
        int Credits { get; set; }
    }
}
