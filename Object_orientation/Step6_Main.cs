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
            var getTargetSt = SerchWord.GetWord("Please Input Target Word");

            var getSerchSt = SerchWord.GetWord("Please Input Serch Word");

            var count = SerchWord.WordCount(getTargetSt, getSerchSt);

            Console.WriteLine(count);
        }

    }
}
