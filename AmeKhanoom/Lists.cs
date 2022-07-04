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
        public static BindingList<Subscribers> subscribers = new BindingList<Subscribers>();
        public static void UpdateList()
        {
            subscribers.Add(new Subscribers("", "", "", "", 0));
            subscribers.RemoveAt(subscribers.Count - 1);
        }
    }
}
