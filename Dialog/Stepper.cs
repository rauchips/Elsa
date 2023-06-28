namespace Namespace;
public class Stepper
{
    public static string Step(int step)
    {
        string output = step switch
        {
            1 => "Enter your name, email address and password in that order.",
            2 => "Enter your email address and password in that order.",
            _ => "Wrong input, please try again.",
        };
        return output;
    }
}
