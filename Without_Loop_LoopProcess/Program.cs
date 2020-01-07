using System;

namespace Without_Loop_LoopProcess
{
    class Program
    {
        static int num = 1;
        static void Main(string[] args)
        {
            #region

            // Variant A
            //if (num <= 10)
            //{
            //    Console.Write("{0}", num++);
            //    Main(null);
            //}


            // Variant B
            int count = 0;
        top:
            if (count >= 5)
            {
                goto bottom;
            }
            count++;
            Console.WriteLine(count);
            goto top;
        bottom: count++;


            // Variant C
            VariantC();


            // Variant D
            VariantD(0);
            #endregion



        }

        public static int VariantC()
        {
            int i = 0;
        begin:
            i = i + 1;
            Console.WriteLine(i);

            if (i < 5)
            {
                goto begin;
            }
            return 0;
        }

        public static void VariantD(int i)
        {
            if (i >= 0 && i < 5)
            {
                i = i + 1;
                Console.WriteLine(i + " ");

                VariantD(i);
            }
        }
    }
}
