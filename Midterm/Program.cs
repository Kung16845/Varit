enum Menu
{
    Collegien = 1,
    Student,
    Teacher
}
public class Program 
{
    static int countTeacher = 0,countStudent = 0,countCollegian = 0,countM4 = 0,countM5 = 0,countM6 = 0;
    static PersonList personList;
    static EmailList emailList;
    public static void Main(string[] args )
    {
        PreparPersonListAndEmilList();
        HomePage();       
    }
    static void PreparPersonListAndEmilList()
    {
        Program.personList = new PersonList();
        Program.emailList = new EmailList();
    }
    static void HomePage()
    {
        Console.Clear();
        Console.WriteLine("1 : Not Sign IN");
        Console.WriteLine("2 : Sign IN");
        int n = int.Parse(Console.ReadLine());
        if(n == 1)
        {
            HomePageBeforeLogin();
        }
        else if (n == 2)
        {
            HomePageAfterLogin();
        }
    }
    static void HomePageAfterLogin()
    {
        Console.Clear();
        Console.WriteLine("1 : Registration");
        Console.WriteLine("2 : ShowAllCollegien");
        Console.WriteLine("3 : ShowAllStudent");
        Console.WriteLine("4 : ShowAllTeacher");
        Console.WriteLine("exit : BackToHomeMain");
        string n = Console.ReadLine();
        if (n == "1")
        {
           ShowMainMenuRegistration(); 
        }
        else if (n == "2")
        {
            Program.personList.ShowPersonCollegian();
        }
        else if (n == "3")
        {
            Program.personList.ShowPersonStudent();
        }
        else if (n == "4")
        {
            Program.personList.ShowPersonTeacher();
        }
        else 
        {
            HomePage();
        }
    }
    static void HomePageBeforeLogin()
    {
        Console.Clear();
        Console.WriteLine("1 : Registration");
        Console.WriteLine("2 : ShowData");
        Console.WriteLine("3 : Log-In");
        int n = int.Parse(Console.ReadLine());
        if(n == 1)
        {
            ShowMainMenuRegistration();
        }
        else if (n == 2)
        {
            ShowNumberOfData();
        }
        else if (n == 3)
        {
            ShowLogInMenu();
        }
    }   
    static void ShowMainMenuRegistration()
    {
        Console.Clear();
        PrintAllMenuRegistration();
        InputMenu();
        HomePage();
    }
    static void ShowNumberOfData()
    {
        Console.Clear();
        Console.WriteLine("Number of Teacher : {0}",countTeacher);
        Console.WriteLine("Number of Student : {0}",countStudent);
        Console.WriteLine("Number of Collegian : {0}",countCollegian);
        Console.WriteLine("Number of StudentM4 : {0}",countM4);
        Console.WriteLine("Number of StudentM5 : {0}",countM5);
        Console.WriteLine("Number of StudentM6 : {0}",countM6);
        System.Threading.Thread.Sleep(5000);
        HomePage();
    }
    static void ShowLogInMenu()
    {
        Console.Clear();   
        string n = Program.emailList.CheckEmail(InputEmail(),InputPassword());
        if (n != null || n == "Back")
        {
            if(n == "Back")
            {
                HomePage();
            }
            else 
            {
                HomePageAfterLogin();
            }
        }
        else 
        {
            Console.WriteLine("Incorrect email or password. Please try again.");
            System.Threading.Thread.Sleep(5000);
            ShowLogInMenu();
        }
    }
    static void PrintAllMenuRegistration()
    {
        Console.WriteLine("1 : Registration Collegien");
        Console.WriteLine("2 : Registration Student");
        Console.WriteLine("3 : Registration Teacher");
    }
    static void InputMenu()
    {
        Console.Write("Please input Menu : ");
        Menu menu = (Menu)(int.Parse(Console.ReadLine()));

        PrintMenu(menu);
    }
    static void PrintMenu(Menu menu)
    {
        switch(menu)
        {
            case Menu.Collegien:
                countCollegian++;
                InputCollegien();
                break;
            case Menu.Student :
                countStudent++;
                InputStudent();
                break;
            case Menu.Teacher :
                countTeacher++;
                InputTeacher();
                break;
            default :
                break;
        }
    }
    public static void InputCollegien()
    {
        Console.Clear();
        Console.WriteLine("Collegien register");
        
        Collegian collegian = new Collegian (InputPronouns(),
        InputName(),InputSurName(),InputAge(),InputAllergy(),InputReligion(),InputStudentID());      
        if (Program.personList.CheckAllName(collegian.GetPronouns(),collegian.GetName(),collegian.GetSurname()) == null)
        {
            Console.WriteLine("User is already registered. Please try again.");
            System.Threading.Thread.Sleep(5000);
            InputCollegien();
        }
        if (Admin() == "Again") 
        {
            Console.WriteLine("Invalid email. Please try again.");
            System.Threading.Thread.Sleep(5000);
            InputCollegien();
        }
        
        Program.personList.AddNewPerson(collegian); 
    }
    
    public static void InputStudent()
    {
        Console.Clear();
        Console.WriteLine("Student register");
        
        Student student = new Student (InputPronouns(),
        InputName(),InputSurName(),InputAge(),InputLevelClass(),InputAllergy(),InputReligion(),InputSchool());
        if (Program.personList.CheckAllName(student.GetPronouns(),student.GetName(),student.GetSurname()) == null)
        {
            Console.WriteLine("User is already registered. Please try again.");
            System.Threading.Thread.Sleep(5000);
            InputStudent();
        }
        Program.personList.AddNewPerson(student); 
    }
    public static void InputTeacher()
    {
        Console.Clear();
        Console.WriteLine("Teacher register");

        Teacher teacher = new Teacher(InputPronouns(),
        InputName(),InputSurName(),InputAge(),InputPosition(),InputAllergy(),InputReligion());
        Car();
        if (Program.personList.CheckAllName(teacher.GetPronouns(),teacher.GetName(),teacher.GetSurname()) == null)
        {
            Console.WriteLine("User is already registered. Please try again.");
            System.Threading.Thread.Sleep(5000);
            InputTeacher();
        }
        if (Admin() == "Again")
        {
            Console.WriteLine("Invalid email. Please try again.");
            System.Threading.Thread.Sleep(5000);
            InputTeacher();
        }

        Program.personList.AddNewPerson(teacher); 
    }
    public static void Car()
    {
        Console.WriteLine("Cat in Project press 1,if not press 2");
        int n = int.Parse(Console.ReadLine());
        if (n == 1)
        {
            InputNumberCar();
        }
    }
    static string Admin()
    {
        string a = "0";
        Console.WriteLine("If you is Admin press 1,You is not Admin press 2");
        int n = int.Parse(Console.ReadLine());
        if (n == 1)
        {
            Email email = new Email(InputEmail(),InputPassword());   
            if (Program.emailList.CheckEmail(email.GetEmail(),email.GetPassword()) != "Again")
            {
                Program.emailList.AddNewEmail(email);
                a = "1";
                return a;
            }
            else 
            {             
                a = "Again";
                return a;
                
            }
        }
        return a;
    }
    public static string InputPronouns()
    {
        Console.WriteLine("Input your Pronouns is Mr press 1, Mrs press 2 , Miss press 3");
        int pronouns = int.Parse(Console.ReadLine());
        switch (pronouns)
        {
            case 1 :
                return "Mr";
            case 2 :
                return "Mrs";
            case 3 :
                return "Miss";
            default: 
                break;
        }
        return null;
    }
    public static string InputName()
    {
        Console.WriteLine("Input your Name");
        return Console.ReadLine();
    }
    public static string InputSurName()
    {
        Console.WriteLine("Input your SurName");
        return Console.ReadLine();
    }
    public static int InputAge()
    {
        Console.WriteLine("Input your Age");
        return int.Parse(Console.ReadLine());
    }
    public static string InputAllergy()
    {
        Console.WriteLine("Input your Allergy");
        return Console.ReadLine();
    }
    public static string InputReligion()
    {
       Console.WriteLine("Input your Religion is Buddhish press 1, Christianity press 2 , Islam press 3,Other press 4");
        int Religion = int.Parse(Console.ReadLine());
        switch (Religion)
        {
            case 1 :
                return "Buddhish";
            case 2 :
                return "Christianity";
            case 3 :
                return "Islam";
            case 4 : 
                return "Other";
            default: 
                break;
        }
        return null;
    }
    public static string InputEmail()
    {
        Console.WriteLine("Input your Email");
        return Console.ReadLine();
    }
    public static string InputPassword()
    {
        Console.WriteLine("Input your Password");
        return Console.ReadLine();
    }
    public static string InputLevelClass()
    {
        Console.WriteLine("Input your LevelClass is M.4 press 1, M.5 press 2 , M.6 press 3");
        int Level = int.Parse(Console.ReadLine());
        switch (Level)
        {
            case 1 :
                countM4++;
                return "M.4";
            case 2 :
                countM5++;
                return "M.5";
            case 3 :
                countM6++;
                return "M.6";
            default: 
                break;
        }
        return null;
    }
    public static string InputPosition()
    {
         Console.WriteLine("Input your Position is Dean press 1,Head of Department press 2 ,Full-Time Teacher press 3");
        int Position = int.Parse(Console.ReadLine());
        switch (Position)
        {
            case 1 :
                return "Dean";
            case 2 :
                return "Head of Department";
            case 3 :
                return "Full-Time Teacher";
            default: 
                break;
        }
        return null;
    }
    public static string InputNumberCar()
    {
        Console.WriteLine("Input your NumberCar : ");
        return Console.ReadLine();
    }
    public static string InputStudentID()
    {
        Console.WriteLine("Input your InputStudentID : ");
        return Console.ReadLine();
    }
    public static string InputSchool()
    {
        Console.WriteLine("Input your School");
        return Console.ReadLine();
    }
}
