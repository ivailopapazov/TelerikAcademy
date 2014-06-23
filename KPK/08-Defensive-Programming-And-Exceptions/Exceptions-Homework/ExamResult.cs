using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException("Grade cannot be less than 0.");
        }

        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException("Minimal grade cannot be less than 0.");
        }

        if (maxGrade <= minGrade)
        {
            throw new ArgumentOutOfRangeException("Maximal grade cannot be less than minimal grade.");
        }

        if (comments == null || comments == "")
        {
            throw new ArgumentException("The comment cannot be null or empty string.");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
