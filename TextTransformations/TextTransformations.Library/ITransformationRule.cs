namespace TextTransformations.Library
{
    public interface ITransformationRule
    {
        string Transform(string input);
    }
}