public class Student : Person
{
    private string LevelClass;
    private string School;
    public Student(string Pronouns,string Name,string Surname,int Age,string LevelClass,string Allergy,string Religion,
    string School) : base(Pronouns,Name,Surname,Age,Allergy,Religion)
    {
        this.LevelClass = LevelClass;
        this.School = School;
    }
}