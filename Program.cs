// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("I am learning C#");
Console.WriteLine("It is awesome");
Console.WriteLine(3 + 3);
Console.Write("Hello World! ");
Console.Write("I will print on the same line. ");
//This is a comment
Console.WriteLine("Hello World! ");
Console.WriteLine("Hello World! "); //This is a comment
/* The code bellow will print the words Hello World
    to the screen, and it is amazing*/
Console.WriteLine("Hello World! ");
String name = "Jhon";
Console.WriteLine(name);
int myNum = 15;
Console.WriteLine(myNum);
int myNum2;
myNum2 = 15;
Console.WriteLine(myNum2);
myNum = 20; // myNum is now 20
Console.WriteLine(myNum);
//const int myNum = 15;
//myNum = 20; (Error al estar ya asignada Como constante)
double myDoubleNum = 5.99D;
Console.WriteLine(myDoubleNum);
string name2 = "Jhon"; //No me deja volver a asignar el string name
Console.WriteLine("Hello " + name2);
string firstName = "Jhon ";
string lastName = "Doe";
string fullName = firstName + lastName;
Console.WriteLine(fullName);
int x = 5;
int y = 6;
Console.WriteLine(x + y); //Print the value of x + y
int x1 = 5, y2 = 6, z3 = 50;
Console.WriteLine(x1 + y2 + z3);
//You can also assign the same valur to multiple variables in one line
int z;
x = y = z = 50;
Console.WriteLine(x + y + z);
//Good
int minutesPerHour = 60;
// OK, but not easy to understand what m actually is
int m = 60;
// C# Data Types
int myNum3 = 5; //Integer (whole number)
double myDoubleNu3 = 5.99D; //Floating point number
char myLetter = 'D'; //Character
bool myBool = true; //Boolean
string myText = "Hello"; //String
int myNum4 = 100000;
Console.WriteLine(myNum4);
long myNum5 = 15000000000L; //you should end the value with an "L"
Console.WriteLine(myNum);
float myNum6 = 7.74F; //you should end the value with an "F"
Console.WriteLine(myNum6); // 6 or 7 decimal digits
double myNum7 = 19.99D; //you should end the valur with a "D" for doubles
Console.WriteLine(myNum7); //15 digits

float f1 = 35e3F; // e to indicate the power of 10
double d1 = 12E4D;
Console.WriteLine(f1);
Console.WriteLine(d1);

bool isCSharpFun = true;
bool isFishTasty = false;
Console.WriteLine(isCSharpFun);
Console.WriteLine(isFishTasty);

char myGrade = 'B';
Console.WriteLine(myGrade);

string greeting = "Hello World";
Console.WriteLine(greeting);

//C# Type Casting

int myInt = 9;
double myDouble = myInt;
Console.WriteLine(myInt);
Console.WriteLine(myDouble);

double myDouble2 = 9.78;
int myInt2 = (int)myDouble2; //Manual casting: double to int
Console.WriteLine(myDouble2); //Outputs 9.78
Console.WriteLine(myInt2); //Outputs 9

int myInt3 = 10;
double myDouble3 = 5.25;
bool myBool3 = true;
Console.WriteLine(Convert.ToString(myInt3)); //convert int to string
Console.WriteLine(Convert.ToDouble(myInt3)); //convert int to double
Console.WriteLine(Convert.ToInt32(myDouble3)); //convert double to int
Console.WriteLine(Convert.ToString(myBool3)); // convert bool to string