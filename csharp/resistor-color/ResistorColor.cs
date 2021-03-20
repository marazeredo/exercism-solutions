using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        int code = 0;
        switch (color)
        {
            case "black":
                code = 0;
                break;
            case "brown":
                code = 1;
                break;
            case "red":
                code = 2;
                break;
            case "orange":
                code = 3;
                break;
            case "yellow":
                code = 4;
                break;
            case "green":
                code = 5;
                break;
            case "blue":
                code = 6;
                break;
            case "violet":
                code = 7;
                break;
            case "gray":
                code = 8;
                break;
            case "white":
                code = 9;
                break;
        }
        return code;
    }
    public static string[] Colors()
    {
        string[] color = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
        return color;
    }
}