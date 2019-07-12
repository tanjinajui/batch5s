using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
    class ShowWeight
    {
        
            double maxWeightLimit;
            int itemsNo;
            double weight__Kg_unit;
            double currentWeight;


            public double MaxWeightLimit
            {
                get { return maxWeightLimit; }
                set { maxWeightLimit = value; }
            }

            public int ItemsNo
            {
                get { return itemsNo; }
                set { itemsNo = value; }

            }

            public double Weight__Kg_Unit
            {
                get { return weight__Kg_unit; }
                set { weight__Kg_unit = value; }
            }

            public double GetCurrentWeight()
            {
                this.currentWeight = ItemsNo * Weight__Kg_Unit;
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
                double currentWeight = ItemsNo * Weight__Kg_Unit;
                if (currentWeight > maxWeightLimit)
                {
                    validation = true;
                }

                return validation;
            }

        }
    }


    

