using Core.Entities;
using System;

namespace Core.Concrete
{
    public class OperationClaim:IEntity
    {
        public int Id { get; set; }
        public String Name { get; set; }
    }
}
