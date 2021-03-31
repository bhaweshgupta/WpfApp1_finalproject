using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1_finalproject
{
    class Productviewmodel
    {
        Datahandle datahandle;
        public Command ProductCommand { get; set; }
        public ObservableCollection<Product> plist { get; set; }
        public  Product p { get; set; }
        Product pp;
        public Productviewmodel()
        {

            ProductCommand = new Command(insertupdatedelte, truefun);
            plist = new ObservableCollection<Product>();
            datahandle = new Datahandle();
            DataTable dt=datahandle.getdata();
            if(dt!=null &&dt.Rows.Count>0)
            {
              
                foreach(DataRow dataRow in dt.Rows)
                {
                    Product ptemp = new Product();
                    ptemp.Type=dataRow["type"].ToString();
                    ptemp.Stock = Convert.ToInt32(dataRow["stock"].ToString());
                    ptemp.Company = dataRow["company"].ToString();
                    plist.Add(ptemp);
                }
                

            }

            p = new Product { Company = "defaultCompany", Type = "defaultType", Stock = 0 };
          


        }
    
     private void insertupdatedelte(object paramter)
     {
            switch(paramter)
            {
                case "Insert":
                    datahandle.insertdata(p);
                    break;
              




            }
     }
    
        private bool truefun(object paramter)
        {
            return true;
        }
    }
}
