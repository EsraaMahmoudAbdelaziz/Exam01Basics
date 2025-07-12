static void Main(string[] args)
{
    
}

#region Q1

/*Question 1:
            Write a program that asks the user to enter their age and nationality. If the age is 18 or above
            and nationality is "Egyptian", print "Eligible to vote", otherwise print "Not eligible"
**/


Console.WriteLine("Enter Your Age");
int.TryParse(Console.ReadLine(), out int age);

Console.WriteLine("Enter Your Nationality");
string nationality = Console.ReadLine();


if (age == 18 || age > 18 && nationality.ToUpper() == "Egyptian")
    Console.WriteLine("Eligible to vote");
else Console.WriteLine("Not eligible");
#endregion