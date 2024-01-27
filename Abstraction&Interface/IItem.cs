using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Interface
{
    public interface IItem
    {
        float value { get; set; }

        void RarityUp();
    }
}
