public class Program 
{
    public static void Main(string[] args) 
    {
        User[] users = InputUsers();
        PrintUsersInformation(users);
    }
    public static User[] InputUsers() 
    {
        User[] users = new User[8];
        for(int index = 0; index < users.Length; index++) 
        {
            Console.WriteLine("******** Input User Number: {0} ********", index + 1);
            User user = new User(InputName(),
            InputSurname(),
            InputStudentID(),
            InputScore());
            users[index] = user;
            Console.WriteLine("****************************************");
            Console.WriteLine();
        }
        return users;
    }
    public static void PrintUsersInformation(User[] users) 
    {
        Array.ForEach(users, user => Console.WriteLine(user.PrintUserInformation()));
    }
    public static string InputName() 
    {
        Console.Write("Input Name: ");
        return Console.ReadLine();
    }
    public static int InputScore() 
    {
    Console.Write("Input Score: ");
    string scoreText = Console.ReadLine();
    if (int.TryParse(scoreText, out int number)) 
        {
            return number;
        }
        throw new Exception("Please input decimal data."); 
    }
    public static string InputStudentID()
    {
        Console.Write("Input StudentID: ");
        return Console.ReadLine();
    }
    public static string InputSurname() 
    {
        Console.Write("input Surname:");
        return Console.ReadLine();
    }
}
