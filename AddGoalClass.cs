using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class AddGoalClass
    {
        public string goal {  get; set; }
        public int parameter { get; set; }


        public AddGoalClass(string goal, int parameter)
        {
            this.goal = goal;
            this.parameter = parameter;
        }
    }
}
