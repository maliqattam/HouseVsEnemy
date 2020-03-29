using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseVsEnemy
{
    class Outside : Location
    {
        private bool hot { get; set; }
        public Outside(string name, bool hot) : base(name)
        {
            this.hot = hot;
        }
        public override string Description { get
            {
                if (hot)
                    return base.Description + " it's hot here " + Name;
                else
                    return base.Description + "it's not hot here" + Name;
            }
                 }
    }
}
