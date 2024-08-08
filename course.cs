public class Course
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public int Credits { get; set; }

    //-----------------one cardinality from teacher--------------
    public int TeacherId { get; set; }
    public Teacher Teacher { get; set; }
    //-----------------one cardinality from teacher--------------

    //-----------------many cardinality from student--------------
    public ICollection<Student> Students { get; set; }

    //-----------------many cardinality from student--------------
}
