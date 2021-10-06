namespace Baldesamo_Franco_ASS3
{
    internal class Class1
    {
        public string name;
        public string address;
        public long tel_Num;
        public int quanty;

        public static bool ClassValid(string a, int b)
        {
            //method 1
            if (a.Length <= b)
            {
                return true;
            }
            else
            {
                System.Console.WriteLine("should not more than {0}", b);
                return false;
            }
        }

        public static bool ClassValidInt(long a)
        {
            if (a.ToString().Length <= 11)
            {
                return true;
            }
            else
            {
                return false;
            }



        }
    }
}