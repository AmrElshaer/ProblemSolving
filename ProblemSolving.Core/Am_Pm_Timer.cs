namespace ProblemSolving.Core
{
    public class Am_Pm_Timer
    {
        public static string TimeConversion(string? s)
        {

            ArgumentNullException.ThrowIfNull(s);
            // return DateTime.Parse(s).ToString("HH:mm:ss");
            var time = s.Split(":");
            int hour = Convert.ToInt32(time[0]);
            var timerIsPM = time[2].Contains("PM");
            var timerIsAM = time[2].Contains("AM");
            if (hour == 12 && timerIsAM) time[0] = "00";
            else if (hour != 12 && timerIsPM) time[0] = (hour + 12).ToString();
            time[2] = time[2].TrimEnd('A', 'M', 'P');
            return Generate24Hour(time);


        }

        private static string Generate24Hour(string[] time)
        {
            return time.Aggregate((a, b) => a + ":" + b);
        }
    }
}
