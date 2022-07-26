using ProblemSolving.Core;

namespace ProblemSolving.Test
{
    public class Am_Pm_Timer_Test
    {
        [Theory]
        [InlineData("12:00:00AM", "00:00:00")]
        [InlineData("12:00:00PM", "12:00:00")]
        [InlineData("07:05:45PM", "19:05:45")]
        [InlineData("07:05:45AM", "07:05:45")]
        public void Convert12TimerTo24Timer(string timer, string result)
        {
            var timerIn24 = Am_Pm_Timer.TimeConversion(timer);
            Assert.Equal(result, timerIn24);
        }
    }
}
