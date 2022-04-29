using Robot_Wars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Wars
{
    public interface IRobotService
    {
        Output MoveRobot(List<int> coordinates, string heading, List<string> moves);
    }
}
