using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmeKhanoom
{
    class Orders: IOrder
    {
        public Orders(int number, int deliveryCode, int customerSubsCode, int price,
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
            subscriber = new Subscribers("", "", "", "", 0);
        }

        public int Number { get; set; }
        public int DeliveryCode { get; set; }
        public int CustomerSubsCode { get; set; }
        public int Price { get; set; }
        public string DeliveryTime { get; set; }
        public int CookieSi { get; set; }
        public int CookieSa { get; set; }
        public int CookieCh { get; set; }
        public int CookieRa { get; set; }
        public int CookieGi { get; set; }
        private Subscribers subscriber { get; set; }

        public void Add(int number, int deliveryCode, int customerSubsCode, int prise,
                      int cookieSi, int cookieSa, int cookieCh, int cookieRa, int cookieGi, string deliveryTime)
        {
            int Allcookies = cookieCh + cookieGi + cookieRa + cookieSa + cookieSi;
            if (subscriber.CheckExistSubs(customerSubsCode) && CheckDeliveryTime(deliveryTime, Allcookies))
            {
                Lists.orders.Add(new Orders(number, deliveryCode, customerSubsCode, prise,
                       cookieSi, cookieSa, cookieCh, cookieRa, cookieGi, deliveryTime));
            }
        }

        public void Edit()
        {
            
        }

        public void Remove()
        {
            
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
            var DeliveryTimeQuery = from i in Lists.orders
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
            
        }
    }
}
