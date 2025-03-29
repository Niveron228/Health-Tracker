using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class AddGoalClass
    {
        public string firstParam {  get; set; }
        public int secondParam { get; set; }

        public AddGoalClass(string firstParam, int secondParam)
        {
            this.firstParam = firstParam;
            this.secondParam = secondParam;
        }
    }
}
