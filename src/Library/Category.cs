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
        //El metodo AddService que recibe un parametro de tipo service va a agregar a la lista de servicios un servicio.
        {
            ServiceList.Add(service);
        }
    }
}