using MandhegParkingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandhegParkingSystem.Utils
{
    internal class Vars
    {
        public static MandhegParkingSystemEntities db = new MandhegParkingSystemEntities();
        public static Employee employee = new Employee();
    }
}
