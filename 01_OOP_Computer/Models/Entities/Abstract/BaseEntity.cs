using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP_Computer.Models.Entities.Abstract
{
    public abstract class BaseEntity<T>
    {
        public abstract T Id { get; set; }
    }
}
