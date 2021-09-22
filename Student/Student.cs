using System;
using StatusNamespace;

namespace Student
{
    public class Student
    {
        public int Id
        {
            get; init;
        }
        public string GivenName {get; set;}
        public string Surname {get; set;}
        public Status status {get; init;} //readonly
        
        public DateTime StartDate {get; set;}
        public DateTime EndDate {get; set;}
        public DateTime Graduation{get; set;}

        public override string ToString()
        {
            return GivenName + " " + Surname + " (" + Id + "): " + status + " [Enrolled: " + StartDate.ToString("dd.MM.yyyy") + ", Enddate: " + EndDate.ToString("dd.MM.yyyy") + ", Expected Graduation: " + Graduation.ToString("dd.MM.yyyy") + "]";
        }
    }
}