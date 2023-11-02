namespace TextTransformations.Library
{
    public abstract class TransformationRule : ITransformationRule
    {
        // other logic

        public abstract string Transform(string input);
    }
}
