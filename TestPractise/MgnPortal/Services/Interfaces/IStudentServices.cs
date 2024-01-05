namespace services;
using dal;

public interface IStudentServices{

    public List<Student>? DisplayStudentService();
    public bool AddStudentService(Student std);
    public bool UpdateStudentService(Student std);
    public bool DeleteStudentService(int rollno);
}