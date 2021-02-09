using System;
using System.Collections.Generic;

namespace PlingPlangPlong_Code
{
    public class PlingPlangPlongCode
    {
        public List<int> ReturnFactors(int num)
        {
            var numFactors = new List<int>();

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0) numFactors.Add(i);
            }

            return numFactors;
        }

        public string PlingPlangPlong(int num)
        {
            var numFactors = new List<int>();
            var returnString = "";

            if (num < 0)
            {
                for (int i = -1; i >= num; i--)
                {
                    if (num % i == 0) numFactors.Add(i);
                }
                if (numFactors.Contains(-3)) returnString += "Pling";
                if (numFactors.Contains(-5)) returnString += "Plang";

                if (numFactors.Contains(-7)) returnString += "Plong";
                else if (!numFactors.Contains(-3) && !numFactors.Contains(-5)) return num.ToString();
            }
            else if (num == 0)
            {
                return "PlingPlangPlong";
            }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0) numFactors.Add(i);
                }
                if (numFactors.Contains(3)) returnString += "Pling";
                if (numFactors.Contains(5)) returnString += "Plang";

                if (numFactors.Contains(7)) returnString += "Plong";
                else if (!numFactors.Contains(3) && !numFactors.Contains(5)) return num.ToString();
            }
            return returnString;
        }

    }
}
