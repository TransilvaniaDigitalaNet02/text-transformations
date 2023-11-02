namespace TextTransformations.Library
{
    public class TextTransformationProcessor
    {
        public TextTransformationProcessor(params ITransformationRule[] rules)
        {
            Rules = rules;
        }

        public ITransformationRule[] Rules { get; }

        public string ApplyAllTransformationRules(string input)
        {
            string result = input;

            foreach (ITransformationRule rule in Rules)
            { 
                result = rule.Transform(result);
            }

            return result;
        }
    }
}
