using TextTransformations.Library;

namespace TextTransformations.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit";

            TextTransformationProcessor processor1 = new TextTransformationProcessor(
                new ReplaceStringTransformationRule("ipsum", "ipsum456"),
                new RemoveAllStringTransformationRule("dolorem "));

            TextTransformationProcessor processor2 = new TextTransformationProcessor(
                new ReplaceStringTransformationRule("consectetur", "test"),
                new RemoveAllStringTransformationRule("Neque porro quisquam "),
                new InsertStringAtTransformationRule(3, " abc "));

            string result1 = processor1.ApplyAllTransformationRules(input);
            string result2 = processor2.ApplyAllTransformationRules(input);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
}