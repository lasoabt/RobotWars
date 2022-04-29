using Robot_Wars.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Wars.BL
{
    public class Move : IMove
    {
        public Move()
        {

        }

        public string SetHeading(string currentHeading, string turning)
        {
            switch (currentHeading)
            {
                case "N":
                    if (turning == "L")
                        return "W";
                    else
                        return "E";
                case "E":
                    if (turning == "L")
                        return "N";
                    else
                        return "S";
                case "S":
                    if (turning == "L")
                        return "E";
                    else
                        return "W";
                case "W":
                    if (turning == "L")
                        return "S";
                    else
                        return "N";
                default:
                    return "O";
            }
        }

        public List<int> ChangePosition(string currentHeading, List<int> coordinates)
        {
            switch (currentHeading)
            {
                case "N":
                    coordinates[1]++;
                    return coordinates;
                case "E":
                    coordinates[0]++;
                    return coordinates;
                case "S":
                    coordinates[1]--;
                    return coordinates;
                case "W":
                    coordinates[0]--;
                    return coordinates;
                default:
                    coordinates = new List<int> { 0, 0 };
                    return coordinates;
            }
        }
    }
}
