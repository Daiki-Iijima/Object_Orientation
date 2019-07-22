using System;
namespace Object_orientation
{
    public class Step7
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(
                SerchWord.WordCount(
                    SerchWord.GetWord("Please Input Target Word"),
                    SerchWord.GetWord("Please Input Serch Word")
                    )
                );
        }
    }
}
