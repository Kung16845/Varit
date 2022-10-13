using System.Collections.Generic;
using System;

public class PersonList 
{
    private List<Person> personList;
    public PersonList()
    {
        this.personList = new List<Person>();
    }
    public void AddNewPerson(Person person)
    {
        this.personList.Add(person);
    }
    public string CheckAllName(string Pronoun,string Name,string Surname)
    {
        string n = "0";
        foreach (Person persons in this.personList)
        {
            string Pronouns = Pronoun;
            string Names = Name;
            string SurNames = Surname;
            if(Pronouns == persons.GetPronouns() && Names == persons.GetName() && SurNames == persons.GetSurname())
            {
                n = null;
                return n;
            }
            else
            {               
                n = "1";
                return n;
            }
        }
        return n;
    }
    public void ShowPersonCollegian()
    {
        Console.WriteLine("Information of AllPeopleCollegian");
        foreach (Person person in this.personList)
        {
           if (person is Collegian)
           {
                Console.WriteLine("Type Collegian \n {0} {1} {2}",person.GetPronouns(),person.GetName(),person.GetSurname());
           }          
        }
    }
    public void ShowPersonStudent()
    {
        Console.WriteLine("Information of AllPeopleStudent");
        foreach (Person person in this.personList)
        {
            if (person is Student)
           {
                Console.WriteLine("Type Student \n {0} {1} {2}",person.GetPronouns(),person.GetName(),person.GetSurname());
           }
        }
    }
    public void ShowPersonTeacher()
    {
        Console.WriteLine("Information of AllPeopleTeacher");
        foreach (Person person in this.personList)
        {
            if (person is Teacher)
           {
                Console.WriteLine("Type Teacher \n {0} {1} {2}",person.GetPronouns(),person.GetName(),person.GetSurname());
           }
        }
    }
}