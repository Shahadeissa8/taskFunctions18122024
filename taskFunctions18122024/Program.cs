Console.WriteLine("===========================================SHAHD EISSA================================================");
Console.WriteLine("===========================================TASK 5================================================");

//Task 1
#region task 1
string greetings(string name)
{
    return "Welcome, " + name;
}
Console.WriteLine("enter you name: ");
string theName = Console.ReadLine();
Console.WriteLine(greetings(theName));
#endregion

Console.WriteLine("===========================================TASK 2================================================");

//Task 2
#region task 2
double volume(double length, double width, double height)
{
    double valoumeCalc;
    valoumeCalc = length * width * height;
    return valoumeCalc;
}
Console.WriteLine("enter length: ");
double length = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter width: ");
double width = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter height: ");
double height = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(volume(length, width, height));
#endregion

Console.WriteLine("===========================================TASK 3================================================");
//Task 3
#region task 3
int numberTaken(int num)
{
    if (num % 2 == 3)
        return num * num;
    else
        return num * 2;
    return num;
}
Console.WriteLine("enter a number to test if its even or odd: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(numberTaken(num));
#endregion
Console.WriteLine("===========================================TASK 4================================================");
//Task 4
#region task 4
double temp(double tempreture)
{

    double F = (tempreture * 1.8) + 32;
    return F;
}
Console.WriteLine("enter the tempreture in Celsius: ");
double tempreture = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(temp(tempreture));
#endregion

Console.WriteLine("===========================================TASK 5================================================");
//Task 5
#region task 5
//      SOLUTION WITH BONUS WITHOUT HELP
string testLetter(char tested)
{
    if (tested >= 'a' && tested <= 'z')
    {
        if (tested == 'a' || tested == 'o' || tested == 'u' || tested == 'i' || tested == 'e' || tested == 'A' || tested == 'O' || tested == 'U' || tested == 'I' || tested == 'E')
        {
            return "vowel";//vowel!
        }
        else
        {
            return "consonant";
        }
    }
    else
        return "non alphabitical";

}

/*         SOLUTION WITH BONUS WITH HELP
string testLetter(char tested) {

    string vowel = "aoieouAOIEU";

    if (char.IsLetter(tested))
    {

        return vowel.Contains(tested) ? "vowel" : "not vowel";
    }
    return "not a char";
}
*/

/*            SOLUTION WITHOUT BONUS WITHOUT HELP
 * string testLetter (char tested){
    if (tested == 'a' || tested == 'o' || tested == 'u' || tested == 'i' || tested == 'e' || tested == 'A' || tested == 'O' || tested == 'U' || tested == 'I' || tested == 'E') {
        return "vowel";//vowel!
    }
    else{
        return "consonant";
    }
}*/


/*             SOLUTION 2 WITHOUT BONUS WITHOUT HELP
char testLetter (char tested){
if (tested == 'a' || tested == 'o' || tested == 'u' || tested == 'i' || tested == 'e' || tested == 'A' || tested == 'O' || tested == 'U' || tested == 'I' || tested == 'E') {
        return 'v';  
    }
else
    {
        return 'c';
    }
}
*/
Console.WriteLine("enter a letter: ");
char tested = Convert.ToChar(Console.ReadLine());
Console.WriteLine(testLetter(tested));
#endregion

Console.WriteLine("===========================================TASK 6================================================");

//Task 6
#region task 6
double currency(double OriginalAmount, double ConversionRate)
{
    double convertedAmount = OriginalAmount * ConversionRate;
    return convertedAmount;
}
Console.WriteLine("enter the amount you want to convert: ");
double OriginalAmount = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter the conversion rate: ");
double ConversionRate = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(currency(OriginalAmount, ConversionRate));
#endregion