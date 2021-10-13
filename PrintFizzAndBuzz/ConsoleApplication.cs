using PrintInformation;

namespace PrintFizzAndBuzz
{
    public class ConsoleApplication
    {
        public static void Main()
        {
            Library.Library.PrintFizzAndBuzz(new PrintInformation<object>() { EndNumber = 200, WordFor3 = "Hola", WordFor5 = 99999 });
        }
    }
}
