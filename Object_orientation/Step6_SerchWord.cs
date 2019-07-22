using System;
namespace Object_orientation
{
    public static class SerchWord
    {

        /// <summary>
        /// 検索したい文字列と表示する導線文を表示する
        /// </summary>
        /// <param name="wordSt"></param>
        /// <returns></returns>
        public static string GetWord(string wordSt)
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
        public static int WordCount(string targetSt, string serchSt)
        {
            return targetSt.Length - targetSt.Replace(serchSt, "").Length;
        }
    }
}
