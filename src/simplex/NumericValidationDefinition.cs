using System;

namespace Simplex
{
    public class NumericValidationDefinition : ValidationDefinition<int>
    {
        private NumericValidationDefinition Builder { get; }

        public void BePositive(string message = null, string paramName = null)
        {
            var value = this.ValidatedSpecimen;

            if (value >= 1) return;

            string customMessage = null;

            if (message != null)
            {
                customMessage = message;
            }
            else
            {
                if (paramName != null)
                {
                    paramName = $"'{paramName}' ";
                }

                customMessage = $"The argument {paramName}should be a positive number, greater than zero.";
            }
            throw new ArgumentException(customMessage, paramName);
        }

        public void BeNonNegative(string message = null, string paramName = null)
        {
            var value = ValidatedSpecimen;

            if (value >= 0) return;

            string customMessage = null;

            if (message != null)
            {
                customMessage = message;
            }
            else
            {
                if (paramName != null)
                {
                    paramName = $"'{paramName}' ";
                }

                customMessage = $"The argument {paramName}should be a non-negative number.";
            }
            throw new ArgumentException(customMessage, paramName);
        }

        public void BeNonZero(string message = null, string paramName = null)
        {
            var value = this.ValidatedSpecimen;

            if (value != 0) return;

            string customMessage = null;

            if (message != null)
            {
                customMessage = message;
            }
            else
            {
                if (paramName != null)
                {
                    paramName = $"'{paramName}' ";
                }

                customMessage = $"The argument {paramName}should be other than zero.";
            }
            throw new ArgumentException(customMessage, paramName);
        }

        public NumericValidationDefinition(int validatedObject) : base(validatedObject)
        {
            Builder = this;
        }

        public NumericValidationDefinition(NumericValidationDefinition builder):base(builder.ValidatedSpecimen)
        {
            Builder = builder;
        }
    }
}