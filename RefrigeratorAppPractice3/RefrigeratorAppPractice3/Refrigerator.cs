using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
    class Refrigerator
    {
        double maxWeightLimit;
        int itemsNo;
        double weightKgunit;
        double currentWeight;

        //get set Method
        public double MaxWeightLimit { get => maxWeightLimit; set => maxWeightLimit = value; }
        public int ItemsNo { get => itemsNo; set => itemsNo = value; }
        public double WeightKgunit { get => weightKgunit; set => weightKgunit = value; }
        public double CurrentWeight { get => currentWeight; set => currentWeight = value; }

        public double GetCurrentWeight()
        {
            this.currentWeight = ItemsNo * weightKgunit;
            return currentWeight;
        }

        public double GetRemainingWeight()
        {
            double remainingWeight = MaxWeightLimit - currentWeight;
            return remainingWeight;
        }

        public bool validation()
        {
            bool validation = false;
            double currentWeight = ItemsNo * weightKgunit;
            if (currentWeight > maxWeightLimit)
            {
                validation = true;
            }
            return validation;
        }


    }
}
