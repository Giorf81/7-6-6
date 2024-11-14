namespace _7_6_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Record<int, string>  record = new Record<int, string>();

            record.Id = 1;
            record.Value = "mnogo";
        }
    }

    class Record<T1, T2>
    {
        public T1 Id;
        public T2 Value;

        public DateTime Date;
    }
}
