# .NET- Calculator
Calculator Class: This class is defined with four methods: Add, Subtract, Multiply, and Divide. Each method takes two double type parameters and performs the corresponding arithmetic operation. If the Divide method detects a division by zero, it throws a DivideByZeroException.

Program Class: This class contains the Main method, which is the entry point of the application.

Main Method: This method starts by creating an instance of the Calculator class. It then prompts the user to enter two numbers and an operator.

It uses Console.ReadLine to read user input and Convert.ToDouble to convert the input into a double type.

It then uses a switch statement to determine which calculator method to call, based on the operator that the user entered. The result is printed to the console.

If the user enters an operator other than +, -, *, or /, the program prints "Invalid operator".

Exception Handling: The code in the Main method is wrapped in a try/catch block, which is used for exception handling. If a DivideByZeroException is thrown (which could happen if the user enters zero as the second number and the operator is /), the program catches this exception and prints a message to the console. If any other type of Exception is thrown, the program catches it and prints a generic error message.

In summary, this code defines a simple calculator program that performs addition, subtraction, multiplication, and division. It's a good example of how to create a class, define methods, use a switch statement, read user input, and handle exceptions in C#.
