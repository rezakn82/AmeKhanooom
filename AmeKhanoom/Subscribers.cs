using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmeKhanoom
{
    class Subscribers: ISubs,ICreditCard
    {
        public Subscribers(string firstName, string lastName, string creditCardNumber, string phoneNumber, int subsCode)
        {
            FirstName = firstName;
            LastName = lastName;
            CreditCardNumber = creditCardNumber;
            PhoneNumber = phoneNumber;
            SubsCode = subsCode;
            Credits = 0;
        }

        public int SubsCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string CreditCardNumber { get; set; }
        public string PhoneNumber { get; set; }
        public int Credits { get; set; }
        public void Add(string firstName, string lastName, string creditCardNumber, string phoneNumber, int subsCode)
        {
            Lists.subscribers.Add(new Subscribers(firstName, lastName, creditCardNumber, phoneNumber, subsCode));
        }
        public void Remove() { }
        public void Edit(int subsCode, string firstName, string lastName, string creditCardNumber, string phoneNumber)
        {
            var FindSubQuery = from i in Lists.subscribers
                           where i.SubsCode == subsCode
                           select i;
            Subscribers EditingSub = FindSubQuery.FirstOrDefault();
            if (EditingSub != null)
            {
                EditingSub.FirstName = firstName;
                EditingSub.LastName = lastName;
                EditingSub.CreditCardNumber = creditCardNumber;
                EditingSub.PhoneNumber = phoneNumber;
                Lists.UpdateList();
            }
            else
            {
                MessageBox.Show("Subsciber not found!", "Invalid Input");
            }
        }
        public void AddCredit(int subsCode,int credit)
        {
            if (CheckExistSubs(subsCode))
            {
                var FindSubQuery = from i in Lists.subscribers
                                   where i.SubsCode == subsCode
                                   select i;
                Subscribers AddcreditSub = FindSubQuery.FirstOrDefault();
                AddcreditSub.Credits += credit;
                Lists.UpdateList();
            }
            else
            {
                MessageBox.Show("Subsciber not found!", "Invalid Input");
            }
        }
        public bool CheckExistSubs(int subsCode)
        {
            foreach (var item in Lists.subscribers)
            {
                if (item.SubsCode == subsCode)
                {
                    return true;
                }
            }
            return false;
        }
        public Subscribers FindSub(int subsCode)
        {
            foreach (var item in Lists.subscribers)
            {
                if (item.SubsCode == subsCode)
                {
                    return item;
                }
            }
            return null;
        }
        
    }
}
