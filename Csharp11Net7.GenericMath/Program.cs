

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

int[] numbers = new[] { 3, 1, 6, 9 };
double[] numbersDouble = new[] { 3.4, 1.2, 6.0, 9.9 };

long[] numbersLong = new long[] { 3, 1, 6, 9 };

var sum = Sum(numbers);
var sumDouble = Sum(numbersDouble);
var sumLong = Sum(numbersLong);

Console.WriteLine($"Sum: {sum}");

T Sum<T>(IEnumerable<T> numbers) where T: INumber<T>
{
    T total = T.Zero;

    foreach (var number in numbers)
    {
        total += number;
    }

    return total;
}

//double SumDouble(IEnumerable<double> numbers)
//{
//    double total = 0;

//    foreach (var number in numbers)
//    {
//        total += number;
//    }

//    return total;
//}


//class NewClass : INumber<int>
//{
//    public static int One => 1;
//    public static int Radix { get; }
//    public static int Zero => 0;
//    public static int AdditiveIdentity { get; }
//    public static int MultiplicativeIdentity { get; }

//    public static int Abs(int value)
//    {
//        throw new NotImplementedException();
//    }

//    public static bool IsCanonical(int value)
//    {
//        throw new NotImplementedException();
//    }

//    public static bool IsComplexNumber(int value)
//    {
//        throw new NotImplementedException();
//    }

//    public static bool IsEvenInteger(int value)
//    {
//        throw new NotImplementedException();
//    }

//    public static bool IsFinite(int value)
//    {
//        throw new NotImplementedException();
//    }

//    public static bool IsImaginaryNumber(int value)
//    {
//        throw new NotImplementedException();
//    }

//    public static bool IsInfinity(int value)
//    {
//        throw new NotImplementedException();
//    }

//    public static bool IsInteger(int value)
//    {
//        throw new NotImplementedException();
//    }

//    public static bool IsNaN(int value)
//    {
//        throw new NotImplementedException();
//    }

//    public static bool IsNegative(int value)
//    {
//        throw new NotImplementedException();
//    }

//    public static bool IsNegativeInfinity(int value)
//    {
//        throw new NotImplementedException();
//    }

//    public static bool IsNormal(int value)
//    {
//        throw new NotImplementedException();
//    }

//    public static bool IsOddInteger(int value)
//    {
//        throw new NotImplementedException();
//    }

//    public static bool IsPositive(int value)
//    {
//        throw new NotImplementedException();
//    }

//    public static bool IsPositiveInfinity(int value)
//    {
//        throw new NotImplementedException();
//    }

//    public static bool IsRealNumber(int value)
//    {
//        throw new NotImplementedException();
//    }

//    public static bool IsSubnormal(int value)
//    {
//        throw new NotImplementedException();
//    }

//    public static bool IsZero(int value)
//    {
//        throw new NotImplementedException();
//    }

//    public static int MaxMagnitude(int x, int y)
//    {
//        throw new NotImplementedException();
//    }

//    public static int MaxMagnitudeNumber(int x, int y)
//    {
//        throw new NotImplementedException();
//    }

//    public static int MinMagnitude(int x, int y)
//    {
//        throw new NotImplementedException();
//    }

//    public static int MinMagnitudeNumber(int x, int y)
//    {
//        throw new NotImplementedException();
//    }

//    public static int Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider)
//    {
//        throw new NotImplementedException();
//    }

//    public static int Parse(string s, NumberStyles style, IFormatProvider? provider)
//    {
//        throw new NotImplementedException();
//    }

//    public static int Parse(ReadOnlySpan<char> s, IFormatProvider? provider)
//    {
//        throw new NotImplementedException();
//    }

//    public static int Parse(string s, IFormatProvider? provider)
//    {
//        throw new NotImplementedException();
//    }

//    public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out int result)
//    {
//        throw new NotImplementedException();
//    }

//    public static bool TryParse([NotNullWhen(true)] string? s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out int result)
//    {
//        throw new NotImplementedException();
//    }

//    public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out int result)
//    {
//        throw new NotImplementedException();
//    }

//    public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out int result)
//    {
//        throw new NotImplementedException();
//    }

//    public int CompareTo(object? obj)
//    {
//        throw new NotImplementedException();
//    }

//    public int CompareTo(int other)
//    {
//        throw new NotImplementedException();
//    }

//    public bool Equals(int other)
//    {
//        throw new NotImplementedException();
//    }

//    public string ToString(string? format, IFormatProvider? formatProvider)
//    {
//        throw new NotImplementedException();
//    }

//    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
//    {
//        throw new NotImplementedException();
//    }
//}

//void Test2<T>() where T: BaseClass
//{
//    INumberBase.Radix
//    t.TestValue;

//    Test(baseClass);
//}

//void Test(BaseClass baseClass)
//{
//    Console.WriteLine(baseClass.TestValue);
//}

//class BaseClass
//{
//    public int TestValue { get; set; }
//}


//interface ITBAddable<T>
//{
//    T Add(T left, T right);
//}

//interface ITBSummable<T>
//{ 
//    T Sum(IEnumerable<T> numbers);
//}

//class TBNumber
//    : ITBAddable<int>,
//      ITBAddable<double>,
//      ITBAddable<long>,
//      ITBSummable<int>,
//      ITBSummable<double>
//{
//    public int Add(int left, int right)
//    {
//        return left + right;
//    }

//    public double Add(double left, double right)
//    {
//        return left + right;
//    }

//    public long Add(long left, long right)
//    {
//        return left + right;
//    }

//    public int Sum<T>(IEnumerable<T> numbers)
//    {
//        int total = T.StaringValue;

//        foreach (var number in numbers)
//        {
//            total += number;
//        }

//        return total;
//    }

//    public double Sum(IEnumerable<double> numbers)
//    {
//        double total = 0;

//        foreach (var number in numbers)
//        {
//            total += number;
//        }

//        return total;
//    }
//}

//class TBIntAddable : ITBAddable<int>
//{
//    public int Add(int left, int right)
//    {
//        return left + right;
//    }
//}

//class TBDoubleAddable : ITBAddable<double>
//{
//    public double Add(double left, double right)
//    {
//        return left + right;
//    }
//}
