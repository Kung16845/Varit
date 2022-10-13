public class Collegian : Person 
{
    private string StudentID;
    public Collegian(string Pronouns,string Name,string Surname,int Age,string Allergy,string Religion,
    string StudentID) : base (Pronouns,Name,Surname,Age,Allergy,Religion)
    {
        this.StudentID = StudentID;
    }
}