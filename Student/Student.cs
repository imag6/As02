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
        public string GivenName;
        public string Surname;
        public Status status {get; init;} //readonly
        
        public DateTime StartDate; 
        public DateTime EndDate; 
        public DateTime Graduation;

        public override string ToString()
        {
            return GivenName + " " + Surname + " (" + Id + "): " + status + " [Enrolled: " + StartDate.ToString("MM/dd/yyyy") + ", Enddate: " + EndDate.ToString("MM/dd/yyyy") + ", Expected Graduation: " + Graduation.ToString("MM/dd/yyyy") + "]";
        }

    }
}