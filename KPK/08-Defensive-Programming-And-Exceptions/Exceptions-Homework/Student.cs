using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    private string firstName = string.Empty;
    private string lastName = string.Empty;

    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("First name cannot be null.");
            }

            if (value == string.Empty)
            {
                throw new ArgumentException("First name cannot be empty string.");
            }

            this.firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }
        set
        {
            if (lastName == null)
            {
                throw new ArgumentNullException("Last name cannot be null.");
            }

            if (value == string.Empty)
            {
                throw new ArgumentException("Last name cannot be empty string.");
            }

            this.lastName = value;
        }
    }

    public IList<Exam> Exams { get; set; }

    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public IList<ExamResult> CheckExams()
    {
        if (this.Exams == null)
        {
            throw new NullReferenceException(string.Format("The exams list is not initialized(null) for student {0} {1}",
                this.FirstName, this.LastName));
        }

        if (this.Exams.Count == 0)
        {
            throw new ApplicationException(string.Format("There are no exams for student {0} {1}",
                this.FirstName, this.LastName));
        }

        IList<ExamResult> results = new List<ExamResult>();
        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        if (this.Exams == null)
        {
            // Cannot calculate average on missing exams
            throw new NullReferenceException(string.Format("The exams list is not initialized(null) for student {0} {1}",
                this.FirstName, this.LastName));
        }

        if (this.Exams.Count == 0)
        {
            // No exams --> return -1;
            throw new ApplicationException(string.Format("There are no exams for student {0} {1}",
                this.FirstName, this.LastName));
        }

        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = CheckExams();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] = 
                ((double)examResults[i].Grade - examResults[i].MinGrade) / 
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }
}