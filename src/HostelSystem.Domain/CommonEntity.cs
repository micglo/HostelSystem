using System;

namespace HostelSystem.Domain
{
    public class CommonEntity
    {
        public Guid Id { get; set; }

        protected CommonEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}