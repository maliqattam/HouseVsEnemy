using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseVsEnemy
{
    class RoomWithDoor : RoomWithHidingPlace, IHasExteriorDoor
    {
        public RoomWithDoor(string name,string decoration, string DoorDescription) 
            : base(name,decoration)
        {
            this.DoorDescription = DoorDescription;
        }

        public string DoorDescription { get; set; }
        public Location DoorLocation { get; set; }
        public override string Description { get
            {
                return base.Description + " and the door is" + DoorDescription;
            } 
        }
    }
}
