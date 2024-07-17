namespace Test.Task_02;

public static class IntExtension
{
    public static string IntToString(this int i)
    {
        var s = i.ToString();

        var result = string.Empty;
        
        foreach (var c in s)
        {
            switch (c)
            {
                case '0':
                    result += "ноль ";
                    break;
                case '1':
                    result += "один ";
                    break;
                case '2':
                    result += "два ";
                    break;
                case '3':
                    result += "три ";
                    break;
                case '4':
                    result += "четыре ";
                    break;
                case '5':
                    result += "пять ";
                    break;
                case '6':
                    result += "шесть ";
                    break;
                case '7':
                    result += "семь ";
                    break;
                case '8':
                    result += "восемь ";
                    break;
                case '9':
                    result += "девять ";
                    break;
                default:
                    break;
                
            }
        }
        return result.Trim();
    }
}