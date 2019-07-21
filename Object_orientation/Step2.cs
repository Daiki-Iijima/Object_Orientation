using System;
namespace Object_orientation
{
    /// <summary>
    /// 入力された文字列の中から指定の文字がいくつ含まれているか検索する
    /// </summary>
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Input Serch Word");

            var serchChar = Console.ReadLine();

            Console.WriteLine("Please Input Target Word");

            var targetWord = Console.ReadLine();

            var count = targetWord.Length - targetWord.Replace(serchChar, "").Length;

            Console.WriteLine(count);
        }
    }
}
