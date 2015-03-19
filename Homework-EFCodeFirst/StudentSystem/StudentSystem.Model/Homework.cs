namespace StudentSystem.Model
{
    using System;

    public class Homework
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public ContentType ContentType { get; set; }

        public DateTime DateAndTime { get; set; }


        public Guid CourseId { get; set; }

        public virtual Course Course { get; set; }


        public int StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
