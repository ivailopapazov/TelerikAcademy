using System;

public class CSharpExam : Exam
{
    public int Score { get; private set; }

    public CSharpExam(int score)
    {
        if (score < 0)
        {
            throw new ArgumentOutOfRangeException("The score must be greater than 0.");
        }

        this.Score = score;
    }

    public override ExamResult Check()
    {
        if (0 > this.Score || this.Score > 100)
        {
            throw new InvalidOperationException("The score must be between 0 and 100.");
        }
        else
        {
            return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }
}
