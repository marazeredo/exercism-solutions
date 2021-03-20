using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        int aux = 0;
        switch (color)
        {
            case "black":
                aux = 0;
                break;
            case "brown":
                aux = 1;
                break;
            case "red":
                aux = 2;
                break;
            case "orange":
                aux = 3;
                break;
            case "yellow":
                aux = 4;
                break;
            case "green":
                aux = 5;
                break;
            case "blue":
                aux = 6;
                break;
            case "violet":
                aux = 7;
                break;
            case "gray":
                aux = 8;
                break;
            case "white":
                aux = 9;
                break;
        }
        return aux;
        //return code;
    }
    public static string[] Colors()
    {
        string[] color = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
        return color;
    }
}