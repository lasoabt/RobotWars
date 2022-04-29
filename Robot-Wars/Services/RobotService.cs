using Robot_Wars.BL;
using Robot_Wars.BL.Interfaces;
using Robot_Wars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Wars
{
    public class RobotService : IRobotService
    {
        private readonly IMove _move;

        public RobotService(IMove move)
        {
            _move = move;
        }

        public Output MoveRobot(List<int> coordinates, string heading, List<string> moves)
        {
            moves.ForEach(m => {
                if (m == "M")
                {
                    coordinates = _move.ChangePosition(heading, coordinates);
                }
                else
                {
                    heading = _move.SetHeading(heading, m);
                }
            });

            return new Output { coordinates = coordinates, heading = heading };
        }
    }
}
