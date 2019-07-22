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
            var getTargetSt = GetWord("Please Input Target Word");

            var getSerchSt = GetWord("Please Input Serch Word");

            var count = WordCount(getTargetSt, getSerchSt);

            Console.WriteLine(count);
        }

        /// <summary>
        /// 検索したい文字列と表示する導線文を表示する
        /// </summary>
        /// <param name="wordSt"></param>
        /// <returns></returns>
        private static string GetWord(string wordSt)
        {
            Console.WriteLine(wordSt);

            var getSt = Console.ReadLine();

            return getSt;
        }

        /// <summary>
        /// 文字数のカウント
        /// </summary>
        /// <param name="targetSt">検索対象の文字列</param>
        /// <param name="serchSt">検索したい文字列</param>
        /// <returns>検索したい文字列が含まれている数</returns>
        private static int WordCount(string targetSt, string serchSt)
        {
            return targetSt.Length - targetSt.Replace(serchSt, "").Length;
        }
    }
}
