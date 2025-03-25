using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class CardioExercise
    {
        public DateTime Date { get; set; } 
        public double Weight { get; set; } 
        public string CardioType { get; set; }
        public double Duration { get; set; }
        public double Distance { get; set; }
        public double CaloriesBurned { get; set; }


        public CardioExercise(DateTime date, double weight, string cardiotype, double duration, double distance, double caloriesBurned)
        {
            Date = date;
            Weight = weight;
            CardioType = cardiotype;
            Duration = duration;
            Distance = distance;
            CaloriesBurned = caloriesBurned;
        }
    }

}
