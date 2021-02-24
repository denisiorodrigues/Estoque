using System;

namespace DR.Business.Models
{
    public abstract class Entity
    {
        public Guid Id { get; set; }

        public Entity()
        {
            Id = new Guid();
        }
    }
}
