using ClassLibraryLab2;

Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;
System.Globalization.CultureInfo customCulture =
(System.Globalization.CultureInfo)
System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

static int CheckInt()
{
    bool ok;
    int x;
    do
    {
        ok = int.TryParse(Console.ReadLine(), out x);
        if (!ok)
        {
            Console.WriteLine("Помилка введення значення!");
        }
    } while (!ok);
    return x;
}

ExtendedDictionary<string, int, string> element = new ExtendedDictionary<string,
int, string>();
int num;
do
{
    Console.WriteLine("1.Додати елемент.\n2.Видалити елемент з заданим ключем.\n3.Перевірити наявність елемента за ключем.\n4.Перевірити наявність елемента із заданим значенням.\n5.Повернути елемент за заданим ключем.\n6.Повернути кількість елементів.\n0.Вихід");
   
    Console.Write("Введіть пункт меню: ");
    num = CheckInt();
    switch (num)
    {
        case 1:
            Console.Clear(); element.AddValues(Console.ReadLine(),
   Int32.Parse(Console.ReadLine()), Console.ReadLine()); break;
        case 2: Console.Clear(); element.RemoveValues(Console.ReadLine()); break;
        case 3: Console.Clear(); element.ContainsKey(Console.ReadLine()); break;
        case 4:
            Console.Clear();
            element.ContainsValue(Int32.Parse(Console.ReadLine()), Console.ReadLine()); break;
        case 5:
            Console.Clear();
            string key = Console.ReadLine();
            Console.WriteLine($"Перше значення: {element[key].Value1}, друге значення: { element[key].Value2}."); break;
    case 6:
            Console.Clear(); Console.WriteLine($"Кількість елементів у словнику: { element.AmountValues()}"); break;
    }
} while (num != 0);
