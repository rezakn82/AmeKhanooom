using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AmeKhanoom
{
    class BackupSubs: Ifile
    {
        public string Filepath { get; set; }
        public void Save()
        {
            string path = "";
            SaveFileDialog sd1 = new SaveFileDialog();
            sd1.Title = "Save Subs to CSV";
            sd1.Filter = "CSV File |*.csv";
            sd1.ShowDialog();
            if (sd1.FileName != "")
            {
                path = Path.GetFullPath(sd1.FileName);
/*                string[] paths = { @"", path };
                string path1 = Path.Combine(paths);*/
                string CSVExport = "SubsCode, FirstName, LastName, CreditCard, PhoneNumber, Credits\r\n";
                foreach (var item in BaseData.subscribers)
                {
                    string CSVExport1 = $"{item.SubsCode},{item.FirstName},{item.LastName},{item.CreditCardNumber},{item.PhoneNumber},{item.Credits}\r\n";
                    CSVExport += CSVExport1;
                }
                using (var writer = new StreamWriter(@"//Test.csv"))
                {
                    writer.WriteLine(CSVExport.Remove(CSVExport.Length - 2, 2));
                }
            }
        }
        public void Load()
        {
            OpenFileDialog sd2 = new OpenFileDialog();
            sd2.Title = "Load Subs from CSV";
            sd2.Filter = "CSV File |*.csv";
            sd2.ShowDialog();

            if (sd2.FileName != "")
            {
                Filepath = Path.GetFullPath(sd2.FileName);

                string[] paths = { @"", Filepath };
                string path = Path.Combine(paths);
                using (var reader = new StreamReader(path))
                {
                    reader.ReadLine();
                    while (!reader.EndOfStream && reader.ToString() != "")
                    {
                        var line = reader.ReadLine();
                        var SubInfo = line.Split(',');
                        BaseData.subscribers.Add(new Subscribers(SubInfo[1], SubInfo[2], SubInfo[3], SubInfo[4],Convert.ToInt32(SubInfo[0]), Convert.ToInt32(SubInfo[5])));
                    }
                }
            }
        }
        
    }
    class BackupOrders : Ifile
    {
        public string Filepath { get; set; }
        public void Save()
        {
            string path = "";
            SaveFileDialog sd1 = new SaveFileDialog();
            sd1.Title = "Save Orders to CSV";
            sd1.Filter = "CSV File |*.csv";
            sd1.ShowDialog();
            if (sd1.FileName != "")
            {
                path = Path.GetFullPath(sd1.FileName);
                string[] paths = { @"", path };
                string path1 = Path.Combine(paths);
                string CSVExport = "Number,DeliveryCode,CustomerSubsCode,Price,DeliveryTime,Si,Sa,Ch,Ra,Gi\r\n";
                foreach (var item in BaseData.orders)
                {
                    string CSVExport1 = $"{item.Number},{item.DeliveryCode},{item.CustomerSubsCode},{item.Price},{item.DeliveryTime}," +
                                        $"{item.CookieSi},{item.CookieSa},{item.CookieCh},{item.CookieRa},{item.CookieGi}\r\n";
                    CSVExport += CSVExport1;
                }
                using (var writer = new StreamWriter(path))
                {
                    writer.WriteLine(CSVExport.Remove(CSVExport.Length - 2, 2));
                }
            }
        }
        public void Load()
        {
            OpenFileDialog sd2 = new OpenFileDialog();
            sd2.Title = "Load Orders from CSV";
            sd2.Filter = "CSV File |*.csv";
            sd2.ShowDialog();

            if (sd2.FileName != "")
            {
                Filepath = Path.GetFullPath(sd2.FileName);

                string[] paths = { @"", Filepath };
                string path = Path.Combine(paths);
                using (var reader = new StreamReader(path))
                {
                    reader.ReadLine();
                    while (!reader.EndOfStream && reader.ToString() != "")
                    {
                        var line = reader.ReadLine();
                        var OrderInfo = line.Split(',');
                        BaseData.orders.Add(new Orders(Convert.ToInt32(OrderInfo[0]), OrderInfo[1], Convert.ToInt32(OrderInfo[2]), Convert.ToInt32(OrderInfo[3]),
                                                        Convert.ToInt32(OrderInfo[5]), Convert.ToInt32(OrderInfo[6]), Convert.ToInt32(OrderInfo[7]), Convert.ToInt32(OrderInfo[8]),
                                                        Convert.ToInt32(OrderInfo[9]), OrderInfo[4]));
                    }
                }
            }
        }

    }

    class AutoBackupSubs : Ifile
    {
        public void Save()
        {

            string CSVExport = "SubsCode, FirstName, LastName, CreditCard, PhoneNumber, Credits\r\n";
            foreach (var item in BaseData.subscribers)
            {
                string CSVExport1 = $"{item.SubsCode},{item.FirstName},{item.LastName},{item.CreditCardNumber},{item.PhoneNumber},{item.Credits}\r\n";
                CSVExport += CSVExport1;
            }
            using (var writer = new StreamWriter($"Subscribers.csv"))
            {
                writer.WriteLine(CSVExport.Remove(CSVExport.Length - 2, 2));
            }

        }
        public void Load()
        {

            using (var reader = new StreamReader($"Subscribers.csv"))
            {
                reader.ReadLine();
                while (!reader.EndOfStream && reader.ToString() != "")
                {
                    var line = reader.ReadLine();
                    var SubInfo = line.Split(',');
                    BaseData.subscribers.Add(new Subscribers(SubInfo[1], SubInfo[2], SubInfo[3], SubInfo[4], Convert.ToInt32(SubInfo[0]), Convert.ToInt32(SubInfo[5])));
                }
            }

        }
    }
    class AutoBackupOrders : Ifile
    {
        public void Save()
        {

            string CSVExport = "Number,DeliveryCode,CustomerSubsCode,Price,DeliveryTime,Si,Sa,Ch,Ra,Gi\r\n";
            foreach (var item in BaseData.orders)
            {
                string CSVExport1 = $"{item.Number},{item.DeliveryCode},{item.CustomerSubsCode},{item.Price},{item.DeliveryTime}," +
                                    $"{item.CookieSi},{item.CookieSa},{item.CookieCh},{item.CookieRa},{item.CookieGi}\r\n";
                CSVExport += CSVExport1;
            }
            using (var writer = new StreamWriter($"Orders.csv"))
            {
                writer.WriteLine(CSVExport.Remove(CSVExport.Length - 2, 2));
            }

        }
        public void Load()
        {

            using (var reader = new StreamReader($"Orders.csv"))
            {
                reader.ReadLine();
                while (!reader.EndOfStream && reader.ToString() != "")
                {
                    var line = reader.ReadLine();
                    var OrderInfo = line.Split(',');
                    BaseData.orders.Add(new Orders(Convert.ToInt32(OrderInfo[0]), OrderInfo[1], Convert.ToInt32(OrderInfo[2]), Convert.ToInt32(OrderInfo[3]),
                                                    Convert.ToInt32(OrderInfo[5]), Convert.ToInt32(OrderInfo[6]), Convert.ToInt32(OrderInfo[7]), Convert.ToInt32(OrderInfo[8]),
                                                    Convert.ToInt32(OrderInfo[9]), OrderInfo[4]));
                }
            }

        }
        public void LoadtoDeliver()
        {
            using (var reader = new StreamReader($"Orders.csv"))
            {
                reader.ReadLine();
                while (!reader.EndOfStream && reader.ToString() != "")
                {
                    var line = reader.ReadLine();
                    var OrderInfo = line.Split(',');
                    BaseData.deliveredorders.Add(new Orders(Convert.ToInt32(OrderInfo[0]), OrderInfo[1], Convert.ToInt32(OrderInfo[2]), Convert.ToInt32(OrderInfo[3]),
                                                    Convert.ToInt32(OrderInfo[5]), Convert.ToInt32(OrderInfo[6]), Convert.ToInt32(OrderInfo[7]), Convert.ToInt32(OrderInfo[8]),
                                                    Convert.ToInt32(OrderInfo[9]), OrderInfo[4]));
                }
            }
        }
        public void SaveSolds()
        {
            DateTime now = DateTime.Today;
            string name = now.ToString("ddMMyyyy");
            string CSVExport = "Number,DeliveryCode,CustomerSubsCode,Price,DeliveryTime,Si,Sa,Ch,Ra,Gi\r\n";
            foreach (var item in BaseData.orders)
            {
                string CSVExport1 = $"{item.Number},{item.DeliveryCode},{item.CustomerSubsCode},{item.Price},{item.DeliveryTime}," +
                                    $"{item.CookieSi},{item.CookieSa},{item.CookieCh},{item.CookieRa},{item.CookieGi}\r\n";
                CSVExport += CSVExport1;
            }
            using (var writer = new StreamWriter($"{name}.csv"))
            {
                writer.WriteLine(CSVExport.Remove(CSVExport.Length - 2, 2));
            }

        }
        public void LoadSolds()
        {
            DateTime now = DateTime.Today;
            string name = now.ToString("ddMMyyyy");
            using (var reader = new StreamReader($"{name}.csv"))
            {
                reader.ReadLine();
                while (!reader.EndOfStream && reader.ToString() != "")
                {
                    var line = reader.ReadLine();
                    var OrderInfo = line.Split(',');
                    BaseData.sold.Add(new Orders(Convert.ToInt32(OrderInfo[0]), OrderInfo[1], Convert.ToInt32(OrderInfo[2]), Convert.ToInt32(OrderInfo[3]),
                                                    Convert.ToInt32(OrderInfo[5]), Convert.ToInt32(OrderInfo[6]), Convert.ToInt32(OrderInfo[7]), Convert.ToInt32(OrderInfo[8]),
                                                    Convert.ToInt32(OrderInfo[9]), OrderInfo[4]));
                }
            }
        }

    }
    class Archieve
    {
        public string Filepath { get; set; }
        public void Load()
        {
            OpenFileDialog sd2 = new OpenFileDialog();
            sd2.Title = "Load Orders from CSV";
            sd2.Filter = "CSV File |*.csv";
            sd2.ShowDialog();

            if (sd2.FileName != "")
            {
                Filepath = Path.GetFullPath(sd2.FileName);

                string[] paths = { @"", Filepath };
                string path = Path.Combine(paths);
                using (var reader = new StreamReader(path))
                {
                    reader.ReadLine();
                    while (!reader.EndOfStream && reader.ToString() != "")
                    {
                        var line = reader.ReadLine();
                        var OrderInfo = line.Split(',');
                        BaseData.archieve.Add(new Orders(Convert.ToInt32(OrderInfo[0]), OrderInfo[1], Convert.ToInt32(OrderInfo[2]), Convert.ToInt32(OrderInfo[3]),
                                                        Convert.ToInt32(OrderInfo[5]), Convert.ToInt32(OrderInfo[6]), Convert.ToInt32(OrderInfo[7]), Convert.ToInt32(OrderInfo[8]),
                                                        Convert.ToInt32(OrderInfo[9]), OrderInfo[4]));
                    }
                }
            }
        }
    }
    class Configs: Ifile
    {
        public Char YN { get; set; }
        public void Save()
        {
            using (var writer = new StreamWriter($"Config.txt"))
            {
                writer.WriteLine(this.YN);
            }
        }
        public void Load()
        {
            using (var reader = new StreamReader($"Config.txt"))
            {
                var line = reader.ReadLine();
                this.YN = Char.Parse(line);
            }
        }
    }
    class CookiePrice
    {
        public void Save()
        {
            string CSVExport = "Si,Sa,Ch,Ra,Gi\r\n";
            string CSVExport1 = $"{BaseData.cookies[0].Price},{BaseData.cookies[1].Price},{BaseData.cookies[2].Price},{BaseData.cookies[3].Price},{BaseData.cookies[4].Price}";
            CSVExport += CSVExport1;
            using (var writer = new StreamWriter($"Price.csv"))
            {
                
                writer.WriteLine(CSVExport1);
            }
        }
        public void Load()
        {
            using (var reader = new StreamReader($"Price.csv"))
            {
                var line = reader.ReadLine();
                var PriceInfo = line.Split(',');

                    BaseData.cookies[0].Price = Convert.ToInt32(PriceInfo[0]);
                    BaseData.cookies[1].Price = Convert.ToInt32(PriceInfo[1]);
                    BaseData.cookies[2].Price = Convert.ToInt32(PriceInfo[2]);
                    BaseData.cookies[3].Price = Convert.ToInt32(PriceInfo[3]);
                    BaseData.cookies[4].Price = Convert.ToInt32(PriceInfo[4]);
               

            }
        }
    }
}
