namespace TextTransformations.Library
{
    public class ReplaceStringTransformationRule : TransformationRule
    {
        public ReplaceStringTransformationRule(string oldValue, string newValue)
        {
            if (oldValue is null)
            {
                throw new ArgumentNullException(nameof(oldValue));
            }

            if (string.IsNullOrEmpty(oldValue))
            {
                throw new ArgumentException("Value cannot be empty string.", nameof(oldValue));
            }

            OldValue = oldValue;
            NewValue = newValue;
        }

        public string OldValue { get; }

        public string NewValue { get; }

        public sealed override string Transform(string input)
        {
            string result = input?.Replace(OldValue, NewValue) ?? string.Empty;

            return result;
        }
    }
}
