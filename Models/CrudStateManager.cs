using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MandhegParkingSystem.Models
{
    internal class CrudStateManager
    {
        public CrudState instance = CrudState.Idle;

        public void ToUpdate()
        {
            this.instance = CrudState.Update;
        }
        public void ToInsert()
        {
            instance = CrudState.Insert;
        }
        public void ToDelete()
        {
            instance = CrudState.Delete;
        }
        public void ToIdle()
        {
            instance = CrudState.Idle;
        }
    }
}
