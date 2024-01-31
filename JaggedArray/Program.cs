namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] happines = new int[] { 4,6,8,2,9};
            sunShine(happines);
            foreach (int num in happines)
            {
                Console.Write(num + " ");
            }
            jaggedArray();
        }

        public static void jaggedArray() 
        {
            string[][] familyBoys = new string[][]
                {
                    new string[]{ "Samson","Gakinya"},
                    new string[]{ "Nolan", "Myles"},
                    new string[]{ "Margaret", "Muchai"}
                };
            Console.WriteLine("Hello {0}, Please meet {1}", familyBoys[0][1], familyBoys[2][0]);
        }

        public static void sunShine(int[] happyDay) 
        {
            for (int x = 0; x < happyDay.Length; x++) 
            {
                happyDay[x] += 2;
            }
        }


    }
}
