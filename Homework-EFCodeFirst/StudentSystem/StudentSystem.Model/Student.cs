namespace StudentSystem.Model
{
    using System; 
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
 
    
    public class Student
    {
        private ICollection<Course> courses;
        private ICollection<Homework> homeworks;
        private ICollection<Student> trainees;
       

        public Student()
        {
            this.courses = new HashSet<Course>();
            this.homeworks = new HashSet<Homework>();
            this.trainees = new HashSet<Student>();
        }

   
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public DateTime? RegistrationDate { get; set; }

        public DateTime? Birthday { get; set; }
       
        //one-to-one relationship
        public virtual Test Test { get; set; }

        //self-relation
        public virtual Student Trainer { get; set; }

        [InverseProperty("Trainer")]
        public virtual ICollection<Student> Trainees
        {
            get
            {
                return this.trainees;
            }
            set
            {
                this.trainees = value;
            }
        }

        public virtual ICollection<Course> Courses 
        {
            get
            {
                return this.courses;
            }
            set
            {
                this.courses = value;
            }
        }

        public virtual ICollection<Homework> Homeworks
        {
            get
            {
                return this.homeworks;
            }
            set
            {
                this.homeworks = value;
            }
        }
    }
}
