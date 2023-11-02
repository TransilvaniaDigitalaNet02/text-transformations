namespace TextTransformations.Library
{
    public class RemoveAllStringTransformationRule : TransformationRule
    {
        public RemoveAllStringTransformationRule(string text)
        {
            if (text is null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentException("Value cannot be empty string.", nameof(text));
            }

            Text = text;
        }

        public string Text { get; }

        public override string Transform(string input)
        {
            string result = input.Replace(Text, null);
            return result;
        }
    }
}
