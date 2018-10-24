using System;
using System.Collections.Generic;

namespace CodeSquirl.System
{
    public interface IEntity : ICloneable
    {
        int ID { get; set; }
        Guid UniqueID { get; set; }
        bool Deleted { get; set; }
        T DeepClone<T>(T source) where T : IEntity;
    }
}
