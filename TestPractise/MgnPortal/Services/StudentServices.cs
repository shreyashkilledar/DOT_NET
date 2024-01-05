namespace services;
using dal;

public class StudentServices:IStudentServices{

    public List<Student>? DisplayStudentService()
    {
        var res = StudentDBManager.DisplayStudentsDao();
        return res;
    }
    public bool AddStudentService(Student std)
    {
        var res = StudentDBManager.AddNewStudentDao(std);
        return res;
    }
    public bool UpdateStudentService(Student std)
    {
        var res = StudentDBManager.UpdateStudentDao(std);
        return res;
    }
    public bool DeleteStudentService(int rollno)
    {
        var res = StudentDBManager.DeleteStudentDao(rollno);
        return res;
    }
}