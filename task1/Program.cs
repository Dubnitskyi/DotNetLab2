Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;
System.Globalization.CultureInfo customCulture =
(System.Globalization.CultureInfo)
System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

Console.WriteLine("Введіть рядок: ");
string str = Console.ReadLine();
Console.WriteLine("Введіть cимвол: ");
string alfa = Console.ReadLine();
char[] symbol = alfa.ToCharArray();

Console.WriteLine($"\n1.Iнвертування рядка\n {str.Inverso()}\n2.Підрахунок кількості входжень\n { symbol[0]} зустрічається { str.CharCount(symbol)} рази ");
 int[] aray = {10, 9, 2, 6, 2, 20, 3, 4, 5, 2, 9, 15, 6};
int[] moved = aray.removeDuplicates();
string[] word = { "Піца", "Бургер", "Ходдог", "Чебурек", "Бургер", "Картошка", "Піца"};
string[] remove = word.removeDuplicates();
Console.WriteLine("\nРобота з масивами");

Console.WriteLine("Задані масиви різних типів:");
foreach (var val in aray)
Console.Write($"{val}; ");
Console.WriteLine();
foreach (var values in word)
Console.Write($"{values}; ");
Console.WriteLine($"\n\n1.Підрахунок кількості входжень\nЧисло 2 зустрічається { aray.SymbolsCount(2)} рази\nСлово Піца зустрічається {word.SymbolsCount("Піца")} рази\n2.Видалення повторів\n{String.Join(", ", moved)}\n { String.Join(", ", remove)}");

 public static class StringEx
{
    public static int CharCount(this string str, char[] c)
    {
        int count = 0;
        for (int i = 0; i < str.Length; i++){
            if (str[i] == c[0])
                count++;
        }
        return count;
    }
    public static string Inverso(this string str)
    {
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}
public static class ArrayEx
{
    public static int SymbolsCount<T>(this T[] arr, T s) where T : IEquatable<T>
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++){
            if (arr[i].Equals(s))
                count++;
        }
        return count;
    }
    public static T[] removeDuplicates<T>(this T[] array)
    {
        HashSet<T> set = new HashSet<T>(array);
        T[] result = new T[set.Count];
        set.CopyTo(result);
        return result;
    }
}
