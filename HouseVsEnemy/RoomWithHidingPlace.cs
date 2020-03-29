using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseVsEnemy
{
    class RoomWithHidingPlace : Room, IHidingPlace
    {
        public string nameOfHidingPlace { get; set; }
        public RoomWithHidingPlace(string name, string decoration) : base(name, decoration)
        {
            
        }
    }
}
