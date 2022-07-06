using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace AmeKhanoom
{
    static class Lists
    {
        public static BindingList<ISubs> subscribers = new BindingList<ISubs>();
        public static BindingList<IOrder> orders = new BindingList<IOrder>();
        public static void UpdateList()
        {
            subscribers.Add(new Subscribers("", "", "", "", 0));
            subscribers.RemoveAt(subscribers.Count - 1);
            orders.Add(new Orders(0, 0, 0, 0, 0, 0, 0, 0, 0, ""));
            orders.RemoveAt(orders.Count - 1);
        }
    }
}
