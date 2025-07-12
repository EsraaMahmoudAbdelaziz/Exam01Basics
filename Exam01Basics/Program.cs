#region Q1

/*Question 1:
            Write a program that asks the user to enter their age and nationality. If the age is 18 or above
            and nationality is "Egyptian", print "Eligible to vote", otherwise print "Not eligible"
**/


//Console.WriteLine("Enter Your Age");
//int.TryParse(Console.ReadLine(), out int age);

//Console.WriteLine("Enter Your Nationality");
//string nationality = Console.ReadLine();


//if (age == 18 || age > 18 && nationality.ToUpper() == "Egyptian")
//    Console.WriteLine("Eligible to vote");
//else Console.WriteLine("Not eligible");
#endregion


#region Q2

/**
 Question 2:
            Create a calculator function that takes two numbers and an operator (+, -, *, /) as input. Use a
            switch statement to perform the operation and return the result. Handle division by zero.
*/

//Console.WriteLine("Enter num01");
//int.TryParse(Console.ReadLine(), out int num01);

//Console.WriteLine("Enter num02");
//int.TryParse(Console.ReadLine(), out int num02);

//Console.WriteLine("Select operator (+, -, *, /)");
//string sympol = Console.ReadLine();


//switch(sympol)
//{
//    case "+":
//        int sum = num01 + num02;
//        Console.WriteLine($"Sum = {sum}");
//        break;

//    case "-":
//        int sub = num01 - num02;
//        Console.WriteLine($"sub = {sub}");
//        break;

//    case "*":
//        int multi = num01 * num02;
//        Console.WriteLine($"multi = {multi}");
//        break;

//    case "/":
//        int divide = num01 / num02;
//        Console.WriteLine($"divide = {divide}");
//        break;
//}
#endregion

#region Q3

/**Question 3:
                Write a method that takes an integer n and prints the multiplication table from 1 to n. Each row
                should show the result of multiplying the current number by 1 through 10.**/


static void multiplication(int n)
{
    for (int i = 1; i <= n; i++) 
    {
        Console.WriteLine(i);
        for (int j = 1; j <= 10; j++)
        {
            Console.WriteLine($"multiplication = {i * j} ");
        }
    }


}

Console.WriteLine("Enter number");
int.TryParse(Console.ReadLine(), out int n);

multiplication(n);
#endregion