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


//static void multiplication(int n)
//{
//    for (int i = 1; i <= n; i++)
//    {
//        Console.WriteLine($" multi of {i} * {n} = {i * n}");
//    }
//}

//Console.WriteLine("Enter number");
//int.TryParse(Console.ReadLine(), out int n);

//multiplication(n);
#endregion

#region Q4

/**Question 4:
              Write a program that accepts an array of integers and counts how many of them are prime
              numbers.**/

//static void primearr (int[] arr )
//{
//    for(int i = 0; i < arr.Length; i++)
//    {
//        int number = arr[i];
//        bool isPrime = true;

//        if (number <= 1) 
//        {
//            isPrime = false;
//        }

//        else
//        {
//            for (int j = 2; j <= number / 2; j++)
//            {
//                if (number % j == 0)
//                {
//                    isPrime = false;
//                }
//            }
//        }

//        if (isPrime)
//            Console.WriteLine($"{number} prime");
//        else
//            Console.WriteLine($"{number} not prime");

//    }

//}

//int[] arr = { 1,2,3,4,5,6,7,8,9 };
//primearr(arr);
#endregion

#region Q5

/***Question 5:
                Ask the user to input 10 integers and store them in an array. Find and print the maximum value
                and its index.***/

Console.WriteLine("Enter 10 number");
long.TryParse(Console.ReadLine(), out long numarr);

int[] arr = new int[10];

for (int i = 9; i >= 0; i--)
{
    arr[i] = (int)(numarr % 10);
    numarr = numarr / 10;
}

Console.WriteLine("Array =");
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i] + " ");
  
}
Console.WriteLine($"max = {arr.Max()}");
Console.WriteLine($"index of max value = {Array.IndexOf(arr, arr.Max())}");

#endregion