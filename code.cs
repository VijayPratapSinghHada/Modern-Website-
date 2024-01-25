// // Variable to store your own age
// int myAge;

// // Variable to keep track of Arun’s personal income
// double income;

// // Variable to store temperature in degree Celsius
// float temp_c;

// // Variable to store temperature in Kelvin
// float temp_k;

// // Variable to store Aum’s full name
// string name;




// using System;

// class Test {
//     static void Main() {
//         double x = 3.0, y = 2.0;
//         int a = 10, b = 2;

//         // Console.WriteLine(a); --------- 10
//         Console.WriteLine(a);

//         // Console.WriteLine(x+a);
//         Console.WriteLine(x + a);

//         // Console.WriteLine(a/b);
//         Console.WriteLine(a / b);

//         // Console.WriteLine(y/x);
//         Console.WriteLine(y / x);

//         // Console.WriteLine(y%x);
//         Console.WriteLine(y % x);

//         // Console.WriteLine((a+b)/b%a);
//         Console.WriteLine((a + b) / b % a);

//         // Console.WriteLine(9.0/5.0*(a-x));
//         Console.WriteLine(9.0 / 5.0 * (a - x));

//         // Console.WriteLine(x+y-x*y%x);
//         Console.WriteLine(x + y - x * y % x);

//         // Console.WriteLine(57%50/25);
//         Console.WriteLine(57 % 50 / 25);

//         Console.ReadLine();
//     }
// }







// using System;

// class NumberCheck {
//     static void Main() {
//         // Input: You can change the value of 'number' to test different scenarios
//         int number = 24;

//         // Check if the number is even or odd
//         if (number % 2 == 0) {
//             Console.WriteLine($"{number} is even.");
//         } else {
//             Console.WriteLine($"{number} is odd.");
//         }

//         // Check if the number is positive or negative
//         if (number > 0) {
//             Console.WriteLine($"{number} is positive.");
//         } else if (number < 0) {
//             Console.WriteLine($"{number} is negative.");
//         } else {
//             Console.WriteLine($"{number} is zero.");
//         }

//         // Check if the number is a multiple of 6
//         if (number % 6 == 0) {
//             Console.WriteLine($"{number} is a multiple of 6.");
//         } else {
//             Console.WriteLine($"{number} is not a multiple of 6.");
//         }

//         // Check if the number is a multiple of 100
//         if (number % 100 == 0) {
//             Console.WriteLine($"{number} is a multiple of 100.");
//         } else {
//             Console.WriteLine($"{number} is not a multiple of 100.");
//         }
//     }
// }




// using System;

// class QuadrantIdentifier {
//     static void Main() {
//         Console.WriteLine("Please input X:");
//         float x = float.Parse(Console.ReadLine());

//         Console.WriteLine("Please input Y:");
//         float y = float.Parse(Console.ReadLine());

//         if (x > 0 && y > 0) {
//             Console.WriteLine($"({x}, {y}) is in Q1");
//         } else if (x < 0 && y > 0) {
//             Console.WriteLine($"({x}, {y}) is in Q2");
//         } else if (x < 0 && y < 0) {
//             Console.WriteLine($"({x}, {y}) is in Q3");
//         } else if (x > 0 && y < 0) {
//             Console.WriteLine($"({x}, {y}) is in Q4");
//         } else if (x == 0 && y == 0) {
//             Console.WriteLine($"({x}, {y}) is at the origin");
//         } else {
//             Console.WriteLine($"({x}, {y}) is on an axis. I don't know the quadrant.");
//         }
//     }
// }



// using System;

// class AirtimeFeeCalculator {
//     static void Main() {
//         Console.WriteLine("Enter the number of minutes:");
//         int numberOfMinutes = int.Parse(Console.ReadLine());

//         int initialCostPerMinute = 5;  // Cost for the first two minutes
//         int remainingCostPerMinute = 2;  // Cost for the remaining minutes

//         int totalAirtimeFee;

//         if (numberOfMinutes <= 0) {
//             Console.WriteLine("Invalid input. Number of minutes must be greater than zero.");
//         } else if (numberOfMinutes <= 2) {
//             // For the first two minutes
//             totalAirtimeFee = numberOfMinutes * initialCostPerMinute;
//             Console.WriteLine($"The airtime fee is {totalAirtimeFee} paise.");
//         } else {
//             // For the first two minutes and the remaining minutes
//             totalAirtimeFee = 2 * initialCostPerMinute + (numberOfMinutes - 2) * remainingCostPerMinute;
//             Console.WriteLine($"The airtime fee is {totalAirtimeFee} paise.");
//         }
//     }
// }



// using System;

// class BMICalculator {
//     static void Main() {
//         Console.WriteLine("Enter your weight (in kg):");
//         double weight = double.Parse(Console.ReadLine());

//         Console.WriteLine("Enter your height (in meters):");
//         double height = double.Parse(Console.ReadLine());

//         double bmi = CalculateBMI(weight, height);

//         Console.WriteLine($"Your BMI is {bmi:F2}.");

//         string status = GetBMIStatus(bmi);
//         Console.WriteLine($"You are {status}.");
//     }

//     static double CalculateBMI(double weight, double height) {
//         return weight / (height * height);
//     }

//     static string GetBMIStatus(double bmi) {
//         if (bmi < 18.5) {
//             return "underweight";
//         } else if (bmi >= 18.5 && bmi < 25) {
//             return "normal";
//         } else if (bmi >= 25 && bmi < 30) {
//             return "overweight";
//         } else {
//             return "obese";
//         }
//     }
// }



// using System;

// class IntegerCheck {
//     static void Main() {
//         Console.WriteLine("Enter a number:");
//         double userInput = double.Parse(Console.ReadLine());

//         // Using Math.Round to check if the number is an integer
//         double roundedValue = Math.Round(userInput);

//         if (userInput == roundedValue) {
//             Console.WriteLine($"{userInput} is an integer.");
//         } else {
//             Console.WriteLine($"{userInput} is not an integer.");
//         }
//     }
// }




// using System;

// class LetterToNumberTranslator {
//     static void Main() {
//         Console.WriteLine("Please input a letter:");
//         char inputLetter = Console.ReadLine().ToUpper()[0]; // Convert to uppercase for simplicity

//         int correspondingNumber = TranslateToNumber(inputLetter);

//         if (correspondingNumber != -1) {
//             Console.WriteLine($"The corresponding number of {inputLetter} is {correspondingNumber}.");
//         } else {
//             Console.WriteLine($"There is no corresponding number for {inputLetter}.");
//         }
//     }

//     static int TranslateToNumber(char letter) {
//         switch (letter) {
//             case 'A':
//             case 'B':
//             case 'C':
//                 return 2;
//             case 'D':
//             case 'E':
//             case 'F':
//                 return 3;
//             case 'G':
//             case 'H':
//             case 'I':
//                 return 4;
//             case 'J':
//             case 'K':
//             case 'L':
//                 return 5;
//             case 'M':
//             case 'N':
//             case 'O':
//                 return 6;
//             case 'P':
//             case 'Q':
//             case 'R':
//             case 'S':
//                 return 7;
//             case 'T':
//             case 'U':
//             case 'V':
//                 return 8;
//             case 'W':
//             case 'X':
//             case 'Y':
//             case 'Z':
//                 return 9;
//             default:
//                 return -1; // No corresponding number for other characters
//         }
//     }
// }




using System;

class BookShippingCostCalculator {
    static void Main() {
        Console.WriteLine("Enter the weight of the book package (in grams):");
        double packageWeight = double.Parse(Console.ReadLine());

        double shippingCost = CalculateShippingCost(packageWeight);

        Console.WriteLine($"The shipping cost is {shippingCost:F2} paise.");
    }

    static double CalculateShippingCost(double weight) {
        const double regularFirstRate = 0.50;
        const double regularAfterRate = 0.75;
        const double expressFee = 50;

        double cost = 0;

        if (weight <= 0) {
            Console.WriteLine("Invalid input. Weight must be greater than zero.");
            return 0;
        } else if (weight <= 2000) {
            cost = weight * regularFirstRate;
        } else {
            cost = 2000 * regularFirstRate + (weight - 2000) * regularAfterRate;
        }

        // Add express fee for express shipping
        Console.WriteLine("Choose shipping type (1 for Regular, 2 for Express):");
        int shippingType = int.Parse(Console.ReadLine());

        if (shippingType == 2) {
            cost += expressFee;
        }

        return cost;
    }
}
