namespace ExcelProblem
{
    internal class Program
    {
        public static int NumberBase = 26;

        public static int ColumnTitleToNumber(string columnTitle)
        {
            var result = 0;
            for (var i = 0; i < columnTitle.Length; i++)
            {
                var charValue = columnTitle[columnTitle.Length - i - 1] - 'A' + 1;
                result += charValue * (int)Math.Pow(NumberBase, i);
            }
            return result;
        }

        public static string TitleNumberToColumn(int columnNumber)
        {

            var result = string.Empty;
            while (columnNumber > 0)
            {
                var remainder = columnNumber % NumberBase;
                if (remainder == 0)
                {
                    remainder = NumberBase;
                    columnNumber--;
                }

                var character = (char)(remainder + 'A' - 1);
                result = character + result;
                columnNumber /= NumberBase;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ColumnTitleToNumber("A"));
            Console.WriteLine(ColumnTitleToNumber("Z"));
            Console.WriteLine(ColumnTitleToNumber("AA"));
            Console.WriteLine(ColumnTitleToNumber("AY"));

            Console.WriteLine();

            Console.WriteLine(TitleNumberToColumn(1));
            Console.WriteLine(TitleNumberToColumn(3));
            Console.WriteLine(TitleNumberToColumn(26));
            Console.WriteLine(TitleNumberToColumn(120));
        }
    }
}