using System;

public static class TwoFer
{
    // In order to get the tests running, first you need to make sure the Speak method 
    // can be called both without any arguments and also by passing one string argument.
    public static string Speak(String name = "you")
    {
        //throw new NotImplementedException("You need to implement this function.");
        if (name is null)
        {
            name = "you";
        }

        return ("One for " + name + ", one for me.");
    }

}