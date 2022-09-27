using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class Category
    {
        public string Name { get; set; }
        public List<Service> ServiceList { get; set; }
        public Category(string name)
        {
            this.Name = name;
        }
        public void AddService(Service service)
        {
            ServiceList.Add(service);
        }
    }
}