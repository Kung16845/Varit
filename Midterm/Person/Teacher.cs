public class Teacher: Person
{
    private string Position;
    private string NumberCar;
    
    public Teacher(string Pronouns,string Name,string Surname,int Age,string Position,string Allergy,
    string Religion): base(Pronouns,Name,Surname,Age,Allergy,Religion)
    {
        this.Position = Position;
    }
}