using System.Text.Json;
using System.Xml.Serialization;

namespace Assignment_10._1;

public partial class Form1 : Form
{
    private Student student;
    private string jsonFilePath = Path.Combine(Application.StartupPath, "student.json");
    private string xmlFilePath = Path.Combine(Application.StartupPath, "student.xml");
    public Form1()
    {
        InitializeComponent();
    }

    private void buttonCreateStudent_MouseClick(object sender, MouseEventArgs e)
    {
        try
        {
            student = new Student(
                int.Parse(textBoxStudentId.Text),
                textBoxFirstName.Text,
                textBoxLastName.Text,
                float.Parse(textBoxGpa.Text),
                textBoxAddress.Text
            );
        }
        catch (FormatException)
        {
            MessageBox.Show("Please enter valid numeric values for Student ID and GPA.", "Invalid Input", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error creating student: {ex.Message}", "Error", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        MessageBox.Show(student.ToString(), "Student Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void buttonSerJson_Click(object sender, EventArgs e)
    {
        try
        {
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            var jsonString = JsonSerializer.Serialize(student, options);
            File.WriteAllText(jsonFilePath, jsonString);
        }
        catch (Exception exception)
        {
            throw new InvalidOperationException($"JSON serialization failed: {exception.Message}", exception);
        }
    }

    private void buttonSerXml_Click(object sender, EventArgs e)
    {
        try
        {
            var serializer = new XmlSerializer(typeof(Student));
            using var writer = new StreamWriter(xmlFilePath);
            serializer.Serialize(writer, student);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"XML serialization failed: {ex.Message}", ex);
        }
    }

    private void buttonDeSerJson_Click(object sender, EventArgs e)
    {
        try
        {
            if (!File.Exists(jsonFilePath))
            {
                MessageBox.Show("JSON file not found!", "File Not Found", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string jsonString = File.ReadAllText(jsonFilePath);
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
        
            student = JsonSerializer.Deserialize<Student>(jsonString, options);
        
            if (student != null)
            {
                textBoxStudentId.Text = student.StudentID.ToString();
                textBoxFirstName.Text = student.FirstName;
                textBoxLastName.Text = student.LastName;
                textBoxGpa.Text = student.GPA.ToString();
                textBoxAddress.Text = student.Address;
            
                MessageBox.Show("Student loaded from JSON successfully!", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to deserialize student data.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"JSON deserialization failed: {ex.Message}", "Error", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonDeSerXML_Click(object sender, EventArgs e)
    {
        try
        {
            if (!File.Exists(xmlFilePath))
            {
                MessageBox.Show("XML file not found!", "File Not Found", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var serializer = new XmlSerializer(typeof(Student));
            using var reader = new StreamReader(xmlFilePath);
            student = (Student)serializer.Deserialize(reader);
        
            if (student != null)
            {
                textBoxStudentId.Text = student.StudentID.ToString();
                textBoxFirstName.Text = student.FirstName;
                textBoxLastName.Text = student.LastName;
                textBoxGpa.Text = student.GPA.ToString();
                textBoxAddress.Text = student.Address;
            
                MessageBox.Show("Student loaded from XML successfully!", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"XML deserialization failed: {ex.Message}", "Error", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}