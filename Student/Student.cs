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
            return GivenName + " " + Surname + " (" + Id + "): " + status + " [Enrolled: " + StartDate.ToString("dd.MM.yyyy") + ", Enddate: " + EndDate.ToString("dd.MM.yyyy") + ", Expected Graduation: " + Graduation.ToString("dd.MM.yyyy") + "]";
        }

        //where to put the condition, in a constructor? or in the creation of the object?
        //if EndDate < Graduation - Dropout
        //if EndDate > DateTime.Now > StartDate - Active
        //if Graduation > DateTime.Now - Graduated
        //if 1 > DateTime.Now > StartDate - New ?
        public Status CreateStatus() 
        {
            if(DateTime.Compare(EndDate, Graduation) < 0) 
            {
                return Status.Dropout;
            } 
            else if(DateTime.Compare(StartDate.AddDays(14),DateTime.Now) > 0 && DateTime.Compare(StartDate, DateTime.Now) < 0) 
            {
                return Status.New;
            }
            else if(DateTime.Compare(EndDate,DateTime.Now) > 0 && DateTime.Compare(StartDate, DateTime.Now) < 0) 
            {
                return Status.Active;
            }
            else if(DateTime.Compare(Graduation, DateTime.Now) > 0) 
            {
                return Status.Graduated;
            }
            return Status.None;
        }

    }
}