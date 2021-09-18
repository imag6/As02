using System;

namespace Student
{
    public record ImmutableStudent
    {
        public int Id { get; init; }
        public string GivenName{ get; init; }
        public string Surname{ get; init; }
        public Status status { get; init; }
        public DateTime StartDate { get; init; }
        public DateTime EndDate { get; init; }
        public DateTime Graduation { get; init; }
    }
}