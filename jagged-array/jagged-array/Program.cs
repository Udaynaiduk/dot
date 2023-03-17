namespace jagged_array
{
    internal class Program
    {
        static void Main(string[] args)
        {

          
            int[][] temprature = new int[2][];
            temprature[0] = new int[3];
            temprature[1] = new int[5];

            for(int i = 0; i < temprature.Length; i++)
            {
                Console.WriteLine(i);
                for(int j = 0; j < temprature[i].Length; j++)
                {
                    temprature[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            for (int i = 0; i < temprature.Length; i++)
            {
                var result = GetStateWiseAverage(i,temprature);
                Console.WriteLine(result);
            }
        }

        /* 
         * Method calculates average of temperature for the state whose position is provided
         */

        public static int GetStateWiseAverage(int index,params int[][] temprature)
        {
            if (index < 0 || index >= temprature.Length)
            {
                throw new IndexOutOfRangeException("Invalid state Index");
            }
            int sum = 0;
            int[] temp = temprature[index];

            foreach (int i in temp)
            {
                sum += i;

            }


            // put here logic to calculate average
            return sum / temp.Length;
        }
    }
}
