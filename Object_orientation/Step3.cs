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

            var getSerchSt = Console.ReadLine();

            Console.WriteLine("Please Input Target Word");

            var getTargetSt = Console.ReadLine();

            var count = WordCount(getTargetSt,getSerchSt);

            Console.WriteLine(count);
        }

        /// <summary>
        /// 文字数のカウント
        /// </summary>
        /// <param name="targetSt">検索対象の文字列</param>
        /// <param name="serchSt">検索したい文字列</param>
        /// <returns>検索したい文字列が含まれている数</returns>
        private static int WordCount(string targetSt,string serchSt)
        {
            return targetSt.Length - targetSt.Replace(serchSt, "").Length;
        }
    }
}
