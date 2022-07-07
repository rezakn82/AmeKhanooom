using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace AmeKhanoom
{
    static class BaseData
    {
        public static BindingList<ISubs> subscribers = new BindingList<ISubs>();
        public static BindingList<IOrder> orders = new BindingList<IOrder>();
        public static BindingList<IOrder> deliveredorders = new BindingList<IOrder>();
        public static BindingList<IOrder> sold = new BindingList<IOrder>();
        public static BindingList<IOrder> archieve = new BindingList<IOrder>();
        public static List<ICookie> cookies = new List<ICookie>();
        public static BackupSubs backupsubs = new BackupSubs();
        public static BackupOrders backuporders = new BackupOrders();
        public static void UpdateListSubs()
        {
            subscribers.Add(new Subscribers("", "", "", "", 0,0));
            subscribers.RemoveAt(subscribers.Count - 1);
        }
        public static void UpdateListOrders()
        {
            orders.Add(new Orders(0, "", 0, 0, 0, 0, 0, 0, 0, ""));
            orders.RemoveAt(orders.Count - 1);
        }
        public static void UpdateListDorders()
        {
            deliveredorders.Add(new Orders(0, "", 0, 0, 0, 0, 0, 0, 0, ""));
            deliveredorders.RemoveAt(orders.Count - 1);
        }
        public static void UpdateListSorders()
        {
            sold.Add(new Orders(0, "", 0, 0, 0, 0, 0, 0, 0, ""));
            sold.RemoveAt(orders.Count - 1);
        }
    }
}
