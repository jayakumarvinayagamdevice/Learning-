namespace LiskovSubstitutionPrinciple
{
    public abstract class Fruit
    {
        public abstract string GetColor();
    }

    public class OldFruit
    {
        public string GetColor()
        {
            return string.Empty;
        }
    }
}
