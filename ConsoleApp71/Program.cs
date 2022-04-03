using System;

namespace ConsoleApp71
{
    internal class Program
    {
        static void Main(string[] args)
        {
           MeetingSchedule meetingSchedule = new MeetingSchedule();
            {
                meetingSchedule.SetMeeting("Rehberlik ile gorus", new DateTime(2022, 04, 3, 14, 00, 00), new DateTime(2022, 05, 15, 16, 00, 00));
            }
            Console.WriteLine(meetingSchedule);
        }
    }
}
