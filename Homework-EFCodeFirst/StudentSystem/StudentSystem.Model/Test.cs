namespace StudentSystem.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema; 

    public class Test
    {
        //one-to-one relationship to Student
        [ForeignKey("Student")]
        public int Id { get; set; }

        public string Name { get; set; }
      
        public virtual Student Student { get; set; }
    }
}
