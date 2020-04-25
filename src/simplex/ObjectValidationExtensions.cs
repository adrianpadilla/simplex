using System;
using System.Collections.Generic;
using System.Text;

namespace Simplex
{
    public static class ObjectValidationExtensions
    {
        public static ObjectValidationDefinition ShouldBe(this object @object)
        {
            return new ObjectValidationDefinition(@object);
        }
    }
}
