using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo4TDDBibliotheque
{
    public class NotFoundException : Exception
    {
        public NotFoundException() : base("***Une exception est levée de type NotFoundException***")
        {
        }
    }
}
