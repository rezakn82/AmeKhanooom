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
        void Remove(int subsCode);
        void Edit(int subsCode, string firstName, string lastName, string creditCardNumber, string phoneNumber);
        void AddCredit(int subsCode, int credit);
        int Credits { get; set; }
    }
    interface ICookie
    {
        string Name { get; set; }
        int Price { get; set; }
        void Add();
        void EditPrice();

    }
    interface IOrder
    {
        int Number { get; set; }
        int DeliveryCode { get; set; }
        int CustomerSubsCode { get; set; }
        int Price { get; set; }
        string DeliveryTime { get; set; }
        int CookieSi { get; set; }
        int CookieSa { get; set; }
        int CookieCh { get; set; }
        int CookieRa { get; set; }
        int CookieGi { get; set; }
        void Add(int number, int deliveryCode, int customerSubsCode, int prise,
                      int cookieSi, int cookieSa, int cookieCh, int cookieRa, int cookieGi, string deliveryTime);
        void Remove();
        void Edit();

    }
}
