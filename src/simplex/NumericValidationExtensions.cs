namespace Simplex
{
    public static class NumericValidationExtensions
    {
        public static NumericValidationDefinition Must(this int @object)
        {
            return new NumericValidationDefinition(@object);
        }
    }
}