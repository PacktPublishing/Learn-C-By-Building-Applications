namespace CSharp7Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryLiteralsAndDigitSeparators binaryLiteralsAndDigitSeparators = new BinaryLiteralsAndDigitSeparators();
            binaryLiteralsAndDigitSeparators.Run();

            RefLocalsAndReturns refLocalsAndReturns = new RefLocalsAndReturns();
            refLocalsAndReturns.Run();

            Deconstruction deconstruction = new Deconstruction();
            deconstruction.Run();

            PatternMatching patternMatching = new PatternMatching();
            patternMatching.Run();

            Tuples tuples = new Tuples();
            tuples.Run();
        }   
    }
}
