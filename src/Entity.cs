using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace CodeSquirrel.System
{
    public class Entity : IEntity
    {
        private const string _cloneExceptionMessage = "Type is not marked as serializable.";

        private int _id;
        private Guid _uniqueID;
        private bool _deleted;

        public int ID { get => _id; set => _id = value; }        
        public Guid UniqueID { get => _uniqueID; set => _uniqueID = value; }
        public bool Deleted { get => _deleted; set => _deleted = value; }

        protected Entity(SerializationInfo info, StreamingContext context)
        {
            ID = (int)info.GetValue(nameof(ID), typeof(int));
            UniqueID = (Guid)info.GetValue(nameof(UniqueID), typeof(Guid));
            Deleted = (bool)info.GetValue(nameof(Deleted), typeof(bool));
        }
        public Entity() { }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public T DeepClone<T>(T source) where T : IEntity
        {
            if (!typeof(T).IsSerializable)
            {
                throw new ArgumentException(_cloneExceptionMessage);
            }

            if (Object.ReferenceEquals(source, null))
            {
                return default(T);
            }

            var json = JsonSerializer.Serialize(source);
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
