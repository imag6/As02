using System;
using Xunit;
using StatusNamespace;

namespace Student.Tests
{
    public class StudentTest
    {
        [Fact]
        public void printingOutCorrectString()
        {
            //var student = new Student(123456, "Sanne", "Hansen", "Active", new DateTime(2020, 08, 30), new DateTime(2023, 06, 30), new DateTime(2023, 06, 30));
            var student = new Student
            {
                Id = 123456,
                GivenName = "Sanne",
                Surname = "Hansen",
                status = Status.Active,
                StartDate = new DateTime(2020, 08, 30), //datetime formatting
                EndDate = new DateTime(2023, 06, 30),
                Graduation = new DateTime(2023, 06, 30)
            };
                
            var output = student.ToString(); 

            var expected = "Sanne Hansen (123456): Active [Enrolled: 30.08.2020, Enddate: 30.06.23], Expected Graduation: 15.06.23";
           
            Assert.Equal(expected, output);
        }
    }
}
