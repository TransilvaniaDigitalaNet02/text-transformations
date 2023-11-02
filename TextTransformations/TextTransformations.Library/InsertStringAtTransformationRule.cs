namespace TextTransformations.Library
{
    public class InsertStringAtTransformationRule : TransformationRule
    {
        public InsertStringAtTransformationRule(
            int index,
            string text)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            if (text is null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            Index = index;
            Text = text;
        }

        public int Index { get; }

        public string Text { get; }

        public override string Transform(string input)
        {
            if (input is null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            if (Index >=  input.Length)
            {
                throw new IndexOutOfRangeException(nameof(Index));
            }

            string result = input.Insert(Index, Text);

            return result;
        }
    }
}
