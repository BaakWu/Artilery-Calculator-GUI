using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artilery_Computer
{
   public static class ArmaMath // library of trignometric math methods 
    {

        public static int findAngle(int angleA, int angleB) //finds the angle difference between two compass bearings
        {
            int resultAngle = 0;
            /* local variable declaration */

            if (angleA > 180 && angleB > 180) //Conditions to find the difference based on location of a 360 degree compass
            {
                if (angleB > angleA)
                    resultAngle = angleB - angleA;
                else
                    resultAngle = angleA - angleB;
            }
            else if (angleB > 180)
                resultAngle = 360 - angleB + angleA;
            else if (angleA > 180)
                resultAngle = 360 - angleA + angleB;
            else if (angleB > angleA)
                resultAngle = angleB - angleA;
            else if (angleA >= angleB)
                resultAngle = angleA - angleB;
            return resultAngle;
        }

        public static int lawOfCos(int angleC, int ST, int SA) // law of cos function that returns the distance between A-T using distances of S-T and S-A as well as angle between S-T and S-A
        {

            int AT = 0;
            double radianC = (Math.PI / 180) * angleC;
            AT = (int)Math.Sqrt(Math.Pow(ST, 2) + Math.Pow(SA, 2) - (2 * ST * SA * Math.Cos(radianC)));
            return AT;
        }

        public static int lawofcosA(int ST, int SA, int AT) //uses the inverse of law of cos a to find the third radian angle
        {

            double BR = Math.Acos((Math.Pow(ST,2)-Math.Pow(SA,2)- Math.Pow(AT, 2)) /(-2* AT * SA));
            double angBR = ((BR * 180) / Math.PI);
            return (int)angBR;
        }
        public static int angleCalcShoot(int angleA, int angleB, int angBR) // uses the 3 angles to produce a compass bearing for the shooter
        {
            int bearing;
            int angleB2;
            if (angleB >= 180)
                angleB2 = angleB - 180;
            else
                angleB2 = angleB + 180;
            if (angleB > angleB2)
                bearing = angleB2 + angBR;
            else
                bearing = angleB2 - angBR;
            return bearing;

        }

    }
}
