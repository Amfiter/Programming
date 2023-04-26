using System.Diagnostics;
using System.Reflection;

namespace Programming.Models.Classes;

public static class Validator
{
    public static int AssertOnPositiveValue(int value)
    {
        StackTrace stackTrace = new StackTrace();
        MethodBase caller = stackTrace.GetFrame(1)?.GetMethod() ?? throw new InvalidOperationException();

        return value > 0
            ? value
            : throw new ArgumentException(String.Format("{0} не является подходящим числом для свойства {1}", value,
                caller.Name));
    }
    
    public static double AssertOnPositiveValue(double value)
    {
        StackTrace stackTrace = new StackTrace();
        MethodBase caller = stackTrace.GetFrame(1)?.GetMethod() ?? throw new InvalidOperationException();

        return value > 0.0d
            ? value
            : throw new ArgumentException(String.Format("{0} не является подходящим числом для свойства {1}", value,
                caller.Name));
    }
    
    public static int AssertOnPositiveValue(int value, int min, int max)
    {
        StackTrace stackTrace = new StackTrace();
        MethodBase caller = stackTrace.GetFrame(1)?.GetMethod() ?? throw new InvalidOperationException();

        return value >= min && value <= max
            ? value
            : throw new ArgumentException(String.Format("{0} не является подходящим числом для свойства {1}", value,
                caller.Name));
    }
}