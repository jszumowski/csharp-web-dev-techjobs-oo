using System;
namespace TechJobsOO
{
    public class PositionType : JobField
    {
        public PositionType()
        {
            Id = nextId;
            nextId++; 
        }
        public PositionType(string value)
        {
            Value = value;
        }
    }
    
}
