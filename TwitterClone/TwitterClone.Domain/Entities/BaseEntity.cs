using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; private set;  }
        public DateTime CreatedAt { get; private set; }
        public DateTime? ModifiedAt { get; private set; }
        public Guid CreatedBy { get; private set; }
        public Guid? Modifiedby { get; private set; }


        public BaseEntity(Guid id)                 //Constructor
        {
            Id = id;
            CreatedAt = DateTime.UtcNow;
        }

        public virtual string DescribeRecord()
        {
            return $"Base Entity: Id: {Id}, CreatedAt: {CreatedAt}, ModifiedAt: {ModifiedAt}, CreatedBy: {CreatedBy}, Modifiedby: {Modifiedby}";
        }
    }
}
