using System;

namespace PizzaWorld.Domain.Abstracts
{
    public abstract class AEntity
    {
        public long EntityId { get; }
        //public Guid EntityGuid { get; set; }

        protected AEntity()
        {
            EntityId = DateTime.Now.Ticks; //uses seconds since start of computer time tracking also known as EPOC
            //EntityGuid = Guid.NewGuid(); unique for the lifetime of the application but not on shutdown. uses several factores to generate but highly unlikely
        }
    }
}