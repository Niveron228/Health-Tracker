using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    namespace Project
    {
        public class LiftingExercise
        {
            public DateTime Date { get; set; }
            public double Weight { get; set; }
            public double WorkWeight { get; set; }
            public double MaxWeight { get; set; }
            public double Reps { get; set; }
            public double Duration { get; set; }

            public string Musсle { get; set; }
            public LiftingExercise(DateTime date, double weight, double workWeight, double maxWeight, double reps, double duration, string musсle)
            {
                Date = date;
                Weight = weight;
                WorkWeight = workWeight;
                MaxWeight = maxWeight;
                Reps = reps;
                Duration = duration;
                Musсle = musсle;
            }
        }
    }
}
