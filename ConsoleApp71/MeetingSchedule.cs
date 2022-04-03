using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp71
{
    internal class MeetingSchedule
    {
        private List<Meeting> meetingList;
        public MeetingSchedule()
        {
            meetingList = new List<Meeting>();
        }

        public bool IsExistsMeetingByName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
                return true;
            else
            {
                foreach (Meeting meeting in meetingList)
                {
                    if (meeting.Name.Contains(name)) ;
                    return true;
                }
                return false;
            }
        }

        public void SetMeeting(string Fullname, DateTime todata, DateTime fromdata)
        {
            if (fromdata > todata)
            {
                Meeting meetings = new Meeting();
                meetings.Name = Fullname;
                meetings.Fromdate = fromdata;
                meetings.Todate = todata;
                if (meetingList == 0)
                {
                    meetingList.Add(meetings);
                }
                else
                {
                    bool hastrue = false;
                    foreach (var item in meetingList)
                    {
                        if (todata <= meetings.Fromdate || fromdata >= meetings.Todate)
                        {
                            hastrue = true;
                        }
                        else
                        {
                            throw new ErrorExceptions("Vaxt intervali duzgun deyil");
                        }
                    }
                    if (hastrue)
                    {
                        meetingList.Add(meetings);
                    }
                }
            }
        }
        public int FindMeetingscount(DateTime time)
        {
            if (time == null)
            {
                throw new ErrorExceptions("Vaxti duzgun daxil edin!");
            }
            else
            {
                int count = 0;
                foreach (Meeting item in meetingList)
                {

                    if (meetingList.Capacity > time)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
        public List<Meeting> Getexistmeeting(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ErrorExceptions("Duzgun parametr daxil edin");
            }
        }
    }
}
