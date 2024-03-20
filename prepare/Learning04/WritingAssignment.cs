using System.Security.Cryptography;

public class WritingAssignemnt : Assignment
{
    private string _title;

    public WritingAssignemnt(string studentName, string topic, string title)
        :base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}