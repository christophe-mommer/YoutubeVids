using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomModelBinder.Models
{
    public struct StudentId
    {
        public Guid Value { get; }

        public StudentId(Guid value)
        {
            if(value == Guid.Empty)
            {
                throw new ArgumentException("StudentId.Ctor() : Value must not be empty");
            }
            Value = value;
        }
    }
}
