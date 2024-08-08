public class StudentAddress
{
    public int StudentAddressId { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }


   // Foreign key for the Student
    public int studentId { get; set; }
    public Student Student { get; set; }
}