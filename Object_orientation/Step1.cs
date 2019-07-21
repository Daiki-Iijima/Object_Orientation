using System;

namespace Object_orientation
{
    /// <summary>
    /// 入力された文字列の中から指定の文字がいくつ含まれているか検索する
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// メインの処理
        /// </summary>
        /// <param name="args">起動引数が入る</param>
        public static void Main(string[] args)
        {
            //  検索する文字を入力してもらう為のアナウンス
            Console.WriteLine("Please Input Serch Word");

            //  入力してもらう
            var serchChar= Console.ReadLine();

            //  対象の文字列を入力してもらう為のアナウンス
            Console.WriteLine("Please Input Target Word");

            //  検索対象を入力してもらう
            var targetWord = Console.ReadLine();

            //  検索したい文字の出現数をカウントする
            //  文字列の長さから、文字列の中からカウントしたい文字を消した文字列の長さを引く
            var count = targetWord.Length - targetWord.Replace(serchChar, "").Length;

            //  出力する
            Console.WriteLine(count);
        }
    }
}
