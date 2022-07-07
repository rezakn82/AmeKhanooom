using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmeKhanoom
{
    class Subscribers : ISubs
    {
        public Subscribers(string firstName, string lastName, string creditCardNumber, string phoneNumber, int subsCode, int credit)
        {
            FirstName = firstName;
            LastName = lastName;
            CreditCardNumber = creditCardNumber;
            PhoneNumber = phoneNumber;
            SubsCode = subsCode;
            Credits = credit;
        }

        public int SubsCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string CreditCardNumber { get; set; }
        public string PhoneNumber { get; set; }
        public int Credits { get; set; }
        public void Add(string firstName, string lastName, string creditCardNumber, string phoneNumber, int subsCode, int credit)
        {
            BaseData.subscribers.Add(new Subscribers(firstName, lastName, creditCardNumber, phoneNumber, subsCode, credit));
        }
        public void Remove(int subsCode)
        {
            if (CheckExistSubs(subsCode))
            {
                ISubs DeletingSub = FindSub(subsCode);
                BaseData.subscribers.Remove(DeletingSub);
                BaseData.UpdateListSubs();
            }
            else
            {
                SubNotFound();
            }
        }
        public void Edit(int subsCode, string firstName, string lastName, string creditCardNumber, string phoneNumber)
        {
            ISubs EditingSub = FindSub(subsCode);
            EditingSub.FirstName = firstName;
            EditingSub.LastName = lastName;
            EditingSub.CreditCardNumber = creditCardNumber;
            EditingSub.PhoneNumber = phoneNumber;
            BaseData.UpdateListSubs();
        }
        public void AddCredit(int subsCode, int credit)
        {
            if (CheckExistSubs(subsCode))
            {
                ISubs AddcreditSub = FindSub(subsCode);
                ((Subscribers)AddcreditSub).Credits += credit;
                BaseData.UpdateListSubs();
            }
            else
            {
                SubNotFound();
            }
        }
        public bool CheckExistSubs(int subsCode)
        {
            var FindSubQuery = from i in BaseData.subscribers
                               where i.SubsCode == subsCode
                               select i;
            if (FindSubQuery.FirstOrDefault() != null)
            {
                return true;
            }

            return false;
        }
        public ISubs FindSub(int subsCode)
        {

            var FindSubQuery = from i in BaseData.subscribers
                               where i.SubsCode == subsCode
                               select i;
            if (FindSubQuery.FirstOrDefault() != null)
            {
                ISubs WantedSub = FindSubQuery.FirstOrDefault();
                return WantedSub;
            }

            return null;
        }
        public void SubNotFound()
        {
            MessageBox.Show("Subsciber not found!", "Invalid Input");
        }
    }

    class Orders : IOrder
    {
        public Orders(int number, string deliveryCode, int customerSubsCode, int price,
                      int cookieSi, int cookieSa, int cookieCh, int cookieRa, int cookieGi, string deliveryTime)
        {
            Number = number;
            DeliveryCode = deliveryCode;
            CustomerSubsCode = customerSubsCode;
            Price = price;
            DeliveryTime = deliveryTime;
            CookieSi = cookieSi;
            CookieSa = cookieSa;
            CookieCh = cookieCh;
            CookieRa = cookieRa;
            CookieGi = cookieGi;
            subscriber = new Subscribers("", "", "", "", 0,0);
        }

        public int Number { get; set; }
        public string DeliveryCode { get; set; }
        public int CustomerSubsCode { get; set; }
        public int Price { get; set; }
        public string DeliveryTime { get; set; }
        public int CookieSi { get; set; }
        public int CookieSa { get; set; }
        public int CookieCh { get; set; }
        public int CookieRa { get; set; }
        public int CookieGi { get; set; }
        private Subscribers subscriber { get; set; }

        public void Add(int number, string deliveryCode, int customerSubsCode, int price,
                      int cookieSi, int cookieSa, int cookieCh, int cookieRa, int cookieGi, string deliveryTime)
        {
            int Allcookies = cookieCh + cookieGi + cookieRa + cookieSa + cookieSi;
            if (subscriber.CheckExistSubs(customerSubsCode) && CheckDeliveryTime(deliveryTime, Allcookies))
            {
                BaseData.orders.Add(new Orders(number, deliveryCode, customerSubsCode, price,
                       cookieSi, cookieSa, cookieCh, cookieRa, cookieGi, deliveryTime));
                ApplyPrice(customerSubsCode, price);
                MessageBox.Show($"Delivery Code : {deliveryCode}\nDo not forget it!!", "Delivety Code");
            }
            else if (!subscriber.CheckExistSubs(customerSubsCode))
            {
                subscriber.SubNotFound();
            }
            else if (!CheckDeliveryTime(deliveryTime, Allcookies))
            {

                TimeisFull(deliveryTime, Allcookies);
            }
        }

        public void Edit(string deliveryCode, int price, int cookieSi, int cookieSa, int cookieCh, int cookieRa, int cookieGi, string deliveryTime, int number)
        {
            Orders Editingorder = Findorder(deliveryCode, number);
            int DifferenceInPrice = price - Editingorder.Price;
            int DifferenceAmountCookie = cookieCh + cookieGi + cookieRa + cookieSa + cookieSi - Editingorder.CookieRa - Editingorder.CookieSi - Editingorder.CookieSa - Editingorder.CookieCh - Editingorder.CookieGi;
            if (Editingorder.DeliveryTime != deliveryTime && CheckDeliveryTime(deliveryTime, cookieCh + cookieGi + cookieRa + cookieSa + cookieSi))
            {
                Editingorder.DeliveryTime = deliveryTime;
                Editingorder.CookieSi = cookieSi;
                Editingorder.CookieSa = cookieSa;
                Editingorder.CookieCh = cookieCh;
                Editingorder.CookieRa = cookieRa;
                Editingorder.CookieGi = cookieGi;
                ApplyPrice(Editingorder.CustomerSubsCode, DifferenceInPrice);
                BaseData.UpdateListOrders();

            }
            else if (Editingorder.DeliveryTime == deliveryTime && CheckDeliveryTime(deliveryTime, DifferenceAmountCookie))
            {
                Editingorder.CookieSi = cookieSi;
                Editingorder.CookieSa = cookieSa;
                Editingorder.CookieCh = cookieCh;
                Editingorder.CookieRa = cookieRa;
                Editingorder.CookieGi = cookieGi;
                ApplyPrice(Editingorder.CustomerSubsCode, DifferenceInPrice);
                BaseData.UpdateListOrders();
            }
            else
            {
                TimeisFull(deliveryTime, cookieCh + cookieGi + cookieRa + cookieSa + cookieSi);
            }

        }

        public void Remove(string deliveryCode, int number)
        {
            Orders DeletingOrder = Findorder(deliveryCode,number);
            if (DeletingOrder != null)
            {
                ReturnMoney(DeletingOrder.CustomerSubsCode, DeletingOrder.Price);
                BaseData.orders.Remove(DeletingOrder);
                BaseData.UpdateListOrders();
            }
            else
            {
                OrderNotFound();
            }
        }
        public bool CheckDeliveryTime(string deliveryTime, int cookies)
        {
            int cookiesordered = CookiesofDeliveryTime(deliveryTime);
            if (cookiesordered + cookies > 1000)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public int CookiesofDeliveryTime(string deliveryTime)
        {
            int cookies = 0;
            var DeliveryTimeQuery = from i in BaseData.orders
                                    where i.DeliveryTime == deliveryTime
                                    select i;
            if (DeliveryTimeQuery.FirstOrDefault() != null)
            {
                foreach (var item in DeliveryTimeQuery)
                {
                    cookies += item.CookieSi;
                    cookies += item.CookieSa;
                    cookies += item.CookieCh;
                    cookies += item.CookieRa;
                    cookies += item.CookieGi;
                }
                return cookies;
            }
            else
            {
                return cookies;
            }
        }
        public int CalcPrice(int cookieSi, int cookieSa, int cookieCh, int cookieRa, int cookieGi)
        {
            int price = 0;
            price += cookieSi * BaseData.cookies[0].Price;
            price += cookieSa * BaseData.cookies[1].Price;
            price += cookieCh * BaseData.cookies[2].Price;
            price += cookieRa * BaseData.cookies[3].Price;
            price += cookieGi * BaseData.cookies[4].Price;
            return price;
        }
        public bool CheckCredit(int subsCode, int price)
        {
            ISubs customer = subscriber.FindSub(subsCode);
            if (customer.Credits < price)
            {
                return false;
            }
            return true;
        }
        public void ApplyPrice(int subsCode, int price)
        {
            ISubs customer = subscriber.FindSub(subsCode);
            customer.Credits -= price;
            BaseData.UpdateListOrders();
        }
        public void ReturnMoney(int subsCode, int price)
        {
            ISubs customer = subscriber.FindSub(subsCode);
            customer.Credits += price;
            BaseData.UpdateListOrders();
        }
        public void TimeisFull(string deliveryTime, int cookies)
        {
            int dt = Convert.ToInt32(deliveryTime);
            int time = 0;
            while (dt < 21)
            {
                dt++;
                if (CheckDeliveryTime((dt).ToString(), cookies))
                {
                    time = dt;
                    break;
                }
            }
            if (time == 0)
            {
                dt = Convert.ToInt32(deliveryTime);
                while (dt > 7)
                {
                    dt--;
                    if (CheckDeliveryTime((dt).ToString(), cookies))
                    {
                        time = dt;
                        break;
                    }
                }
            }
            if (time != 0)
            {
                MessageBox.Show($"Selected Delivery Time is full!\n Our suggestion is {time}", "Time is Full");
            }
            else if (time == 0)
            {
                MessageBox.Show("Your order is more than our capacity in 1 hour.\n please duplicate it.", "Time is Full");
            }
        }
        public Orders Findorder(string deliveryCode, int number)
        {
            var Findwantedorderquery = from i in BaseData.orders
                                       where i.DeliveryCode == deliveryCode && i.Number == number
                                       select i;
            if (Findwantedorderquery.FirstOrDefault() != null)
            {
                return (Orders)Findwantedorderquery.FirstOrDefault();
            }
            return null;
        }
        public void OrderNotFound()
        {
            MessageBox.Show("Order not found!", "Invalid Input");
        }
        public void Deliver(string deliveryCode, int number)
        {
            Orders deliveredorder = Findorder(deliveryCode,number);
            if (deliveredorder != null)
            {
                BaseData.sold.Add(deliveredorder);
                BaseData.deliveredorders.Remove(deliveredorder);
                BaseData.UpdateListSubs();
                BaseData.UpdateListDorders();
            }
            else
            {
                OrderNotFound();
            }
        }
        public void Sell(string deliveryCode, int number)
        {
            Orders deliveredorder = Findorder(deliveryCode,number);
            if (deliveredorder != null)
            {
                ReturnMoney(deliveredorder.CustomerSubsCode, deliveredorder.Price);
                BaseData.sold.Add(deliveredorder);
                BaseData.deliveredorders.Remove(deliveredorder);
                BaseData.UpdateListSubs();
                BaseData.UpdateListDorders();
            }
            else
            {
                OrderNotFound();
            }
        }
    }

    class Cookies : ICookie
    {
        public Cookies(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public int Price { get; set; }
        public void Add()
        {
            if (BaseData.cookies.Count == 0)
            {
                BaseData.cookies.Add(new Cookies("Simple"));
                BaseData.cookies.Add(new Cookies("Saffron"));
                BaseData.cookies.Add(new Cookies("Chocolate"));
                BaseData.cookies.Add(new Cookies("Raisin"));
                BaseData.cookies.Add(new Cookies("Ginger"));
            }
        }
    }
}

