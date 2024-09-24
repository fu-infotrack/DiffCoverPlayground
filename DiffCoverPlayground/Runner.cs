namespace DiffCoverPlayground
{
    public class Runner
    {
        public void RunTested_Original()
        {
            Console.WriteLine(nameof(RunTested_Original));
        }

        public void RunNotTested_Original()
        {
            Console.WriteLine(nameof(RunNotTested_Original));
        }

        public void RunTested_New()
        {
            Console.WriteLine(nameof(RunTested_New));
        }

        public void RunNotTested_New()
        {
            Console.WriteLine(nameof(RunNotTested_New));
        }
    }
}
