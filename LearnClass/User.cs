public class User 
{
    public string name;
    public string surname;
    public string studentID;
    private Grade gradeInformation;
    public User(string name, string surname, string studentID, int score) 
    {
        this.name = name;
        this.surname = surname;
        this.studentID = studentID;
        this.gradeInformation = new Grade(score);
    }
    public string PrintGrade() 
    {
        return this.gradeInformation.ShowGrade();
    }
    public int PrintScore() 
    {
        return this.gradeInformation.ShowScore();
    }
    public string PrintUserInformation()
    {
        return "User information is : " + this.name + " " + this.surname + " " +
            this.studentID + " Score is: " + this.gradeInformation.ShowScore() + " Grade is:" +
            this.gradeInformation.ShowGrade();
    }
}    