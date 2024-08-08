public class Student
{
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }


    // student idan course eke patthe cardinality eke balanna
      // Navigation property for the many-to-many relationship with Course
   //-----------------many cardinality from courses--------------
    public ICollection<Course> Courses { get; set; }
    //-----------------many cardinality from courses--------------




    // Navigation property for the related StudentAddress
    public StudentAddress Address { get; set; }




      public int GradeId { get; set; }
      public Grade Grade { get; set; }
}
