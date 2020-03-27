namespace BMS.CustomAttributes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple =true)]
    public class MultipleRegexAttribute : RegularExpressionAttribute
    {
        public MultipleRegexAttribute(string pattern) : base(pattern)
        {

        }
    }
}
