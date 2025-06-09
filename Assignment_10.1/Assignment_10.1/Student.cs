using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Assignment_10._1;


[Serializable]
[XmlRoot("Student")]
public class Student
{
    [XmlElement("StudentID")]
    [JsonPropertyName("StudentID")]
    public int StudentID { get; set; }
    
    [XmlElement("FirstName")]
    [JsonPropertyName("FirstName")]
    public string FirstName { get; set; }
    
    [XmlElement("LastName")]
    [JsonPropertyName("LastName")]
    public string LastName { get; set; }
    
    [XmlElement("GPA")]
    [JsonPropertyName("GPA")]
    public float GPA { get; set; }
    
    [XmlElement("Address")]
    [JsonPropertyName("Address")]
    public string Address { get; set; }
    
    public Student(int studentId, string firstName, string lastName, float gpa, string address)
    {
        StudentID = studentId;
        FirstName = firstName;
        LastName = lastName;
        GPA = gpa;
        Address = address;
    }

    public Student() { } // primary constructor

    public override string ToString()
    {
        return $"ID: {StudentID}, Name: {FirstName} {LastName}, GPA: {GPA:F2}, Address: {Address}";
    }
}