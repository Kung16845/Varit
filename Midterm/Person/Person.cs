public class Person 
{
    private string Pronouns;
    private string Name;
    private string Surname;
    private int Age;
    private string Allergy;
    private string Religion;

    public Person(string Pronouns,string Name,string Surname,int Age,string Allergy,string Religion )
    {
        this.Pronouns = Pronouns;
        this.Name = Name;
        this.Surname = Surname;
        this.Age = Age;
        this.Allergy = Allergy;
        this.Religion = Religion;
    }
    public string GetPronouns()
    {
        return this.Pronouns;
    }
    public string GetName()
    {
        return this.Name;
    }
    public string GetSurname()
    {
        return this.Surname;
    }
}