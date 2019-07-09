using System;

namespace ConsoleApp
{
    static class FreightCoach
    {
        /// <summary>
        /// Checks the correct number of freight coach.
        /// Freight coach number consists of 8 digits.
        /// </summary>
        /// <param name="coach_number">The number of freight coach</param>
        /// <returns></returns>
        public static bool IsDigit(string coach_number)
        {
            if (coach_number.Length != 8)
                return false;

            for (int i = 0; i < 8; i++)
                if (!char.IsDigit(coach_number[i]))
                    return false;

            return true;
        }


        /// <summary>
        /// Check the number of the freight coach.
        /// </summary>
        /// <param name="coach_number">The number of freight coach</param>
        /// <param name="true_number">For the correct check digit</param>
        /// <returns></returns>
        public static bool IsFreightCoach(string coach_number, out int true_number)
        {
            int first_7_number = Convert.ToInt32(coach_number.Substring(0, 7));
            int last_number = Convert.ToInt32(coach_number[7].ToString());

            int sum = 0;
            int step = 0;
            while (first_7_number > 0)
            {
                int temp = 0;
                if (step % 2 == 0)
                    temp = (first_7_number % 10) * 2;
                else
                    temp = first_7_number % 10;

                while (temp >= 10)
                {
                    sum += temp % 10;
                    temp /= 10;
                }

                sum += temp;
                first_7_number /= 10;

                step++;
            }


            // If sum % 10 is 0, then last number is 0
            if (sum % 10 == 0)
            {
                true_number = 0;
                return 0 == last_number;
            }

            // If last number is 0, then sum % 10 is 0
            if (last_number == 0)
            {
                true_number = 10 - (sum % 10);
                return 10 - (sum % 10) == 0;
            }


            true_number = 10 - (sum % 10);
            return true_number == last_number;
        }
    }
}
