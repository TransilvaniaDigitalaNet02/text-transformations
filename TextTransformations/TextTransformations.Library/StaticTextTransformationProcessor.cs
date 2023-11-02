namespace TextTransformations.Library
{
    public static class StaticTextTransformationProcessor
    {
        public static string ApplyAllTransformationRules(
            string input,
            params ITransformationRule[] rules)
        {
            string result = input;

            foreach (ITransformationRule rule in rules)
            {
                result = rule.Transform(result);
            }

            return result;
        }
    }
}
