public class Grade {
    private int score;
    private string grade;
    public Grade(int score) 
    {
        this.score = score;
        this.grade = ConvertScoreToGrade(score);
    }
    public string ShowGrade() 
    {
        return this.grade;
    }
    public int ShowScore() 
    {
        return this.score;
    }
    public string ConvertScoreToGrade(int score) 
    {
        if (score > 100) { 
        throw new Exception("Please input data 0 - 100"); }
        if (IsGradeA(score)) {
            return "Grade A";
        } else if (IsGradeBPlus(score)) {
            return "Grade B+";
        } else if (IsGradeB(score)) {
            return "Grade B";
        } else if (IsGradeCPlus(score)) {
            return "Grade C+";
        } else if (IsGradeC(score)) {
            return "Grade C";
        } else if (IsGradeDPlus(score)) {
            return "Grade D+";
        } else if (IsGradeD(score)) {
            return "Grade D";
        } else if (IsGradeF(score)){
            return "Grade F";
        } else {
            throw new Exception("Please input data 0 - 100");
        }
    }

    public bool IsGradeA(int score)
    {
        return score >= 80;
    }
    public bool IsGradeBPlus(int score)
    {
        return score < 80 && score >= 75;
    }
    public bool IsGradeB(int score)
    {
        return score < 75 && score >= 70;
    }
    public bool IsGradeCPlus(int score) 
    {
        return score < 70 && score >= 65;
    }
    public bool IsGradeC(int score) 
    {
        return score < 65 && score >= 60;
    }
    public bool IsGradeDPlus(int score) 
    {
        return score < 60 && score >= 55;
    }
    public bool IsGradeD(int score) 
    {
        return score <= 54 && score >= 50;
    }
    public bool IsGradeF(int score) 
    {
        return score < 50 && score >= 0;
    }    
}