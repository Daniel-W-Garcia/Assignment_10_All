namespace Assignment_10._1;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        labelFirstName = new System.Windows.Forms.Label();
        textBoxFirstName = new System.Windows.Forms.TextBox();
        textBoxLastName = new System.Windows.Forms.TextBox();
        labelLastName = new System.Windows.Forms.Label();
        textBoxStudentId = new System.Windows.Forms.TextBox();
        labelStudentId = new System.Windows.Forms.Label();
        textBoxAddress = new System.Windows.Forms.TextBox();
        labelAddress = new System.Windows.Forms.Label();
        textBoxGpa = new System.Windows.Forms.TextBox();
        labelGpa = new System.Windows.Forms.Label();
        buttonCreateStudent = new System.Windows.Forms.Button();
        buttonSerJson = new System.Windows.Forms.Button();
        buttonSerXml = new System.Windows.Forms.Button();
        buttonDeSerJson = new System.Windows.Forms.Button();
        buttonDeSerXML = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // labelFirstName
        // 
        labelFirstName.Location = new System.Drawing.Point(260, 59);
        labelFirstName.Name = "labelFirstName";
        labelFirstName.Size = new System.Drawing.Size(100, 23);
        labelFirstName.TabIndex = 0;
        labelFirstName.Text = "First Name";
        // 
        // textBoxFirstName
        // 
        textBoxFirstName.Location = new System.Drawing.Point(397, 59);
        textBoxFirstName.Name = "textBoxFirstName";
        textBoxFirstName.Size = new System.Drawing.Size(183, 23);
        textBoxFirstName.TabIndex = 1;
        // 
        // textBoxLastName
        // 
        textBoxLastName.Location = new System.Drawing.Point(397, 106);
        textBoxLastName.Name = "textBoxLastName";
        textBoxLastName.Size = new System.Drawing.Size(183, 23);
        textBoxLastName.TabIndex = 3;
        // 
        // labelLastName
        // 
        labelLastName.Location = new System.Drawing.Point(260, 106);
        labelLastName.Name = "labelLastName";
        labelLastName.Size = new System.Drawing.Size(100, 23);
        labelLastName.TabIndex = 2;
        labelLastName.Text = "Last Name";
        // 
        // textBoxStudentId
        // 
        textBoxStudentId.Location = new System.Drawing.Point(397, 157);
        textBoxStudentId.Name = "textBoxStudentId";
        textBoxStudentId.Size = new System.Drawing.Size(183, 23);
        textBoxStudentId.TabIndex = 5;
        // 
        // labelStudentId
        // 
        labelStudentId.Location = new System.Drawing.Point(260, 157);
        labelStudentId.Name = "labelStudentId";
        labelStudentId.Size = new System.Drawing.Size(100, 23);
        labelStudentId.TabIndex = 4;
        labelStudentId.Text = "Student ID";
        // 
        // textBoxAddress
        // 
        textBoxAddress.Location = new System.Drawing.Point(397, 202);
        textBoxAddress.Name = "textBoxAddress";
        textBoxAddress.Size = new System.Drawing.Size(183, 23);
        textBoxAddress.TabIndex = 7;
        // 
        // labelAddress
        // 
        labelAddress.Location = new System.Drawing.Point(260, 202);
        labelAddress.Name = "labelAddress";
        labelAddress.Size = new System.Drawing.Size(100, 23);
        labelAddress.TabIndex = 6;
        labelAddress.Text = "Address";
        // 
        // textBoxGpa
        // 
        textBoxGpa.Location = new System.Drawing.Point(397, 242);
        textBoxGpa.Name = "textBoxGpa";
        textBoxGpa.Size = new System.Drawing.Size(183, 23);
        textBoxGpa.TabIndex = 9;
        // 
        // labelGpa
        // 
        labelGpa.Location = new System.Drawing.Point(260, 242);
        labelGpa.Name = "labelGpa";
        labelGpa.Size = new System.Drawing.Size(100, 23);
        labelGpa.TabIndex = 8;
        labelGpa.Text = "GPA";
        // 
        // buttonCreateStudent
        // 
        buttonCreateStudent.Location = new System.Drawing.Point(397, 293);
        buttonCreateStudent.Name = "buttonCreateStudent";
        buttonCreateStudent.Size = new System.Drawing.Size(183, 31);
        buttonCreateStudent.TabIndex = 10;
        buttonCreateStudent.Text = "Create Student";
        buttonCreateStudent.UseVisualStyleBackColor = true;
        buttonCreateStudent.MouseClick += buttonCreateStudent_MouseClick;
        // 
        // buttonSerJson
        // 
        buttonSerJson.Location = new System.Drawing.Point(260, 353);
        buttonSerJson.Name = "buttonSerJson";
        buttonSerJson.Size = new System.Drawing.Size(111, 31);
        buttonSerJson.TabIndex = 11;
        buttonSerJson.Text = "Serialize JSON";
        buttonSerJson.UseVisualStyleBackColor = true;
        buttonSerJson.Click += buttonSerJson_Click;
        // 
        // buttonSerXml
        // 
        buttonSerXml.Location = new System.Drawing.Point(469, 353);
        buttonSerXml.Name = "buttonSerXml";
        buttonSerXml.Size = new System.Drawing.Size(111, 31);
        buttonSerXml.TabIndex = 12;
        buttonSerXml.Text = "Serialize XML";
        buttonSerXml.UseVisualStyleBackColor = true;
        buttonSerXml.Click += buttonSerXml_Click;
        // 
        // buttonDeSerJson
        // 
        buttonDeSerJson.Location = new System.Drawing.Point(260, 390);
        buttonDeSerJson.Name = "buttonDeSerJson";
        buttonDeSerJson.Size = new System.Drawing.Size(111, 31);
        buttonDeSerJson.TabIndex = 13;
        buttonDeSerJson.Text = "De-Serialize JSON";
        buttonDeSerJson.UseVisualStyleBackColor = true;
        buttonDeSerJson.Click += buttonDeSerJson_Click;
        // 
        // buttonDeSerXML
        // 
        buttonDeSerXML.Location = new System.Drawing.Point(469, 390);
        buttonDeSerXML.Name = "buttonDeSerXML";
        buttonDeSerXML.Size = new System.Drawing.Size(111, 31);
        buttonDeSerXML.TabIndex = 14;
        buttonDeSerXML.Text = "DeSerialize XML";
        buttonDeSerXML.UseVisualStyleBackColor = true;
        buttonDeSerXML.Click += buttonDeSerXML_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(buttonDeSerXML);
        Controls.Add(buttonDeSerJson);
        Controls.Add(buttonSerXml);
        Controls.Add(buttonSerJson);
        Controls.Add(buttonCreateStudent);
        Controls.Add(textBoxGpa);
        Controls.Add(labelGpa);
        Controls.Add(textBoxAddress);
        Controls.Add(labelAddress);
        Controls.Add(textBoxStudentId);
        Controls.Add(labelStudentId);
        Controls.Add(textBoxLastName);
        Controls.Add(labelLastName);
        Controls.Add(textBoxFirstName);
        Controls.Add(labelFirstName);
        Text = "Students";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button buttonDeSerXML;
    private System.Windows.Forms.Button buttonDeSerJson;

    private System.Windows.Forms.Button buttonCreateStudent;
    private System.Windows.Forms.Button buttonSerJson;

    private System.Windows.Forms.Button buttonSerXml;

    private System.Windows.Forms.Label labelFirstName;
    private System.Windows.Forms.TextBox textBoxFirstName;
    private System.Windows.Forms.Label labelLastName;
    private System.Windows.Forms.TextBox textBoxLastName;
    private System.Windows.Forms.Label labelStudentId;
    private System.Windows.Forms.TextBox textBoxStudentId;
    private System.Windows.Forms.Label labelAddress;
    private System.Windows.Forms.TextBox textBoxAddress;
    private System.Windows.Forms.Label labelGpa;
    private System.Windows.Forms.TextBox textBoxGpa;



    #endregion
}