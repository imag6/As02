using System.Reflection;
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
            var student = new Student
            {
                Id = 123456,
                GivenName = "Sanne",
                Surname = "Hansen",
                status = Status.Active,
                StartDate = new DateTime(2020, 08, 30), 
                EndDate = new DateTime(2023, 06, 30),
                Graduation = new DateTime(2023, 06, 15)
            };
                
            var output = student.ToString(); 

            var expected = "Sanne Hansen (123456): Active [Enrolled: 08/30/2020, Enddate: 06/30/2023, Expected Graduation: 06/15/2023]";
           
            Assert.Equal(expected, output);
        }

        [Fact]
        public void graduatedStudentPrintsCorrectSTring()
        {
            var student = new Student
            {
                Id = 123456,
                GivenName = "Hanne",
                Surname = "Jensen",
                status = Status.Graduated,
                StartDate = new DateTime(2017, 08, 30), 
                EndDate = new DateTime(2020, 06, 30),
                Graduation = new DateTime(2020, 06, 15)
            };
                
            var output = student.ToString(); 

            var expected = "Hanne Jensen (123456): Graduated [Enrolled: 08/30/2017, Enddate: 06/30/2020, Expected Graduation: 06/15/2020]";
           
            Assert.Equal(expected, output);
        }

        [Fact]
        public void equalFieldsEqualObjects() {
            var student1 = new ImmutableStudent
            {
                Id = 123456,
                GivenName = "Lise",
                Surname = "Sørensen",
                status = Status.Active,
                StartDate = new DateTime(2021, 08, 30), 
                EndDate = new DateTime(2024, 06, 30),
                Graduation = new DateTime(2024, 06, 15)
            };

            var student2 = new ImmutableStudent
            {
                Id = 123456,
                GivenName = "Lise",
                Surname = "Sørensen",
                status = Status.Active,
                StartDate = new DateTime(2021, 08, 30), 
                EndDate = new DateTime(2024, 06, 30),
                Graduation = new DateTime(2024, 06, 15)
            };

            var output = student1.Equals(student2);
            Assert.True(output);

            output = student1 == student2;
            Assert.True(output);
        }

        [Fact]
        public void notEqualFieldsNotEqualObjects()
        {
            var student1 = new ImmutableStudent
            {
                Id = 123456,
                GivenName = "Hanne",
                Surname = "Sørensen",
                status = Status.Active,
                StartDate = new DateTime(2021, 08, 30), 
                EndDate = new DateTime(2024, 06, 30),
                Graduation = new DateTime(2024, 06, 15)
            };

            var student2 = new ImmutableStudent
            {
                Id = 123456,
                GivenName = "Lise",
                Surname = "Sørensen",
                status = Status.Active,
                StartDate = new DateTime(2021, 08, 30), 
                EndDate = new DateTime(2024, 06, 30),
                Graduation = new DateTime(2024, 06, 15)
            };

            var output = student1.Equals(student2);
            Assert.False(output);

            output = student1 == student2;
            Assert.False(output);
        }

        [Fact]
        public void recordToStringPrintsFields() 
        {
            var student = new ImmutableStudent
            {
                Id = 123456,
                GivenName = "Hanne",
                Surname = "Sørensen",
                status = Status.Active,
                StartDate = new DateTime(2021, 08, 30), 
                EndDate = new DateTime(2024, 06, 30),
                Graduation = new DateTime(2024, 06, 15)
            };

            var expected = "ImmutableStudent { Id = 123456, GivenName = Hanne, Surname = Sørensen, status = Active, StartDate = 08/30/2021 00.00.00, EndDate = 06/30/2024 00.00.00, Graduation = 06/152024 00.00.00 }";

            var output = student.ToString();

            Assert.Equal(expected,output);
        }
    }
}
