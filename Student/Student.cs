using System;

namespace Student
{
    public class Student
    {
        int Id;
        string GivenName;
        string Surname;
        readonly Status status;
        
        DateTime StartDate; //DD.MM.YY
        DateTime EndDate; 
        DateTime Graduation;

        public override string ToString()
        {
            return GivenName + " " + Surname + " (" + id + "): " + status + " [Enrolled: " + StartDate + ", Enddate: " + EndDate + ", Expected Graduation: " + Graduation + "]";
        }

         public int id
        {
            get; init;
        }
        
        public enum Status
        {
            New, 
            Active, 
            Droupout, 
            Gratuated
        }
    }
}