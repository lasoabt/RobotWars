using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Wars.BL.Interfaces
{
    public interface IMove
    {
        string SetHeading(string currentHeading, string turning);
        List<int> ChangePosition(string currentHeading, List<int> coordinates);
    }
}
