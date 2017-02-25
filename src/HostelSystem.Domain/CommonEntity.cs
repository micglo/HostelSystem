using System;

namespace HostelSystem.Domain
{
    public abstract class CommonEntity
    {
        public Guid Id { get; set; }

        protected CommonEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}