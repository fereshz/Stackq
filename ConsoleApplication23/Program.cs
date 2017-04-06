namespace Learning_Stackq
{
    public class Stackq1
    {
        private int Index = -1;
        private System.Collections.ArrayList Stackq = new System.Collections.ArrayList();

        public void push(int Data)
        {
            Index++;

            Stackq.Add(Data);
        }

        public int pop()
        {
            if (Index >= 0)
            {
                int result = (int)Stackq[0];

                Stackq.RemoveAt(0);

                Index--;

                return result;
            }
            else
            {
                return (-1);
            }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections.ArrayList olist = new System.Collections.ArrayList();
            //olist.Add(23);
            //olist.Add(43);
            //olist.Insert(1, 17);
            //olist.Add(4);
            //int pop = (int)olist[0];
            //olist.RemoveAt(0);
            //int x = olist.Count;
            //System.Console.WriteLine("x:" + x);
            //foreach (int i in olist)
            //{
            //    System.Console.WriteLine(i);
            //}

            Stackq1 ostackq = new Stackq1();
            ostackq.push(7);
            ostackq.push(21);
            ostackq.push(17);
            ostackq.push(15);

            int intData;

            intData = ostackq.pop();
            System.Console.WriteLine(intData);
            intData = ostackq.pop();
            System.Console.WriteLine(intData);

            System.Console.ReadLine();



        }
    }


}