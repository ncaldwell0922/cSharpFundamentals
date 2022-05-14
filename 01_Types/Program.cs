//! Comments
/* 
    -Clarify code
        -detailing different concepts
        -Reference
    -Communicate to other developers / future you
    -Track history
*/

// Single Line
/*
    Mult-Line
*/

/*
!Solution
    When we create a solution file, the basic implementation of the command will grab the name of the parent directory and assign it to the solution that it is generating.
        - In our case: dotnet new sln = cSharpFundamentals.sln
        - Two ways to start it:
            - dotnet new sln - [name.sln]
            - dotnet new sln (while inside folder)
    
    The solution will go on to group together the bulk of our notes

*   What's in the package?
        -cproj: CSharp project file - holds the SDK (Software Development Kit) for us to run our projects.
        -obj [folder]: Various packages that help out code run (not a high concern right now)
        -cs: Where we write our code
*/

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/* 
! Variables

    datatype variableName = value;

    -Must start with datatype and be given a name.
    -doesnt need to be assigned a value right away.
*/

/*
!  Booleans

    -bool: 1byte
        -stores true/false value
*/

bool isDeclared = true;
bool isNotDeclared;
// Console.WriteLine(isNotDeclared); Breaks our build because a default value is not provided.

isNotDeclared = false;
// cw
System.Console.WriteLine(isNotDeclared);

/*
! Characters
    =Char: 2 bytes
        sStores single character/letter, surround y a single qote ' '
*/

char character = 'a';
char symbol = '?';
char number = '7';
char whitespace = ' ';
char specialChararcter = '\n';

/*
! string

    =string
        - Stores a sequenece of characters, surround by double quotes " ".

*/

string stringSample = "Sample Text";
System.Console.WriteLine(stringSample);

/*
!  Numbers
    -int: 4 bytes
    -long: 8 bytes
*/

byte byteExample = 255; // anything between 0 - 225 due to binary code
sbyte sByteMin = -128; // between -128 through 127 (128 x 2 while accounting for zero)
short shortExample = 32767; // max
int intMin = -2147483648;
Int32 intMax = 2147483647; // fits a 32 bit
long longExample = 9223372036854775807;
Int64 longMin = -9223372036854775808;

byte numByte = 78;
System.Console.WriteLine(numByte);

//* casting:
System.Console.WriteLine((char) numByte);  //We are tanslating the byte into a character. This changes the value into the list of characters
System.Console.WriteLine((long) numByte);

/* 
!  Decimals
        -float: 4 bytes
            - stores fractional numbers. Sufficient for storing 6 to 7 decimal digits.
        double: 8 bytes
            - stores fractional numbers. Sufficient for storing 15 decimal digits
*/

float floatExample = 1.0443534f; // The digits are respresented in binary except for the period. We us the "f"at the end to detail that we are storing a float value.
double doubleExample = 1.73245463456345; // like a float but double the space.
double defaultDouble = 198271; // When referring decimal numbers, this is default expectation and doesn't require a "d". For consistency, it is best place for it.
decimal decimalExample = 1.248372628472727484927328m; // heighest form of number. Typicallt used for currency. We use a "m" to detail that htis value is meant for a decimal.

System.Console.WriteLine("Float: " + 1.248372628472727484927328f);
System.Console.WriteLine("Double: " + 1.248372628472727484927328d);
System.Console.WriteLine("Decimal: " + 1.248372628472727484927328m);

/*
!  Structs
    Data Structures
*/

int age = 42;
DateTime today = DateTime.Today;
System.Console.WriteLine(today);

DateTimeOffset todayUTC = DateTimeOffset.Now;
System.Console.WriteLine(todayUTC);

DateTime birthday = new DateTime (2015, 1, 7);
System.Console.WriteLine(birthday);