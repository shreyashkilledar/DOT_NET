public class Student{
    public int? RollNo{ get; set; }
    public string? Fname{ get; set; }
    public string? Lname{ get; set; }

    public Student():this(00, "student_0", "student_0"){}
    public Student(int rollno, string fname, string lname){
        this.RollNo = rollno;
        this.Fname = fname;
        this.Lname = lname;
    }
}