using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public interface ICar
    {
        string MoveForward(decimal meters);
        string MoveBackards(decimal meters);
    }
}
