using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseVsEnemy
{
    class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public OutsideWithDoor(string name, bool hot, string DoorDescription)
            : base(name, hot)
        {
            this.DoorDescription = DoorDescription;
        }
        public string DoorDescription { get; set; }
        public Location DoorLocation { get; set; }

        public override string Description => base.Description
            +" and the Door is " + DoorDescription +".";
    }
}
