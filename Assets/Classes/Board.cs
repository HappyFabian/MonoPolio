using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyTestClass
{
    public class Board
    {
        public Space[] Spaces;

        public Board(Space spaces)
        {
            Spaces = GetBoardSpaces();
        }

        public Space GetSpace(int spaceId)
        {
            if (spaceId < Spaces.Length)
            {
                return Spaces[spaceId];
            }
            return null;
        }

        private Space[] GetBoardSpaces()
        {
            return new Space[]
            {
                new Simple("GO"),
                new Street("OLD KENT ROAD"), 
                new Community(), 
                new Street("WHITECHAPEL ROAD"), 
                new Tax("INCOME TAX", 200), 
                new Railroad("KINGS CROSS STATION"), 
                new Street("THE ANGEL, ISLINGTON"), 
                new Chance(), 
                new Street("EUSTON ROAD"), 
                new Street("PENTONVILLE ROAD"), 
                new Simple("JAIL"), 
                new Street("PALL MALL"), 
                new Utility("ELECTRIC COMPANY"), 
                new Street("WHITEHALL"), 
                new Street("NORTHUMRL AVENUE"), 
                new Railroad("MARYLEBONE STATION"), 
                new Street("BOW STREET"), 
                new Community(), 
                new Street("MARLBOROUGH STREET"), 
                new Street("VINE STREET"), 
                new Simple("FREE PARKING"), 
                new Street("STRAND"), 
                new Chance(), 
                new Street("FLEET STREET"), 
                new Street("TRAFALGAR SQUARE"), 
                new Railroad("FENCHURCH ST. STATION"), 
                new Street("LEICESTER SQUARE"), 
                new Street("CONVENTRY STREET"), 
                new Utility("WATERWORKS"), 
                new Street("PICCADILY"), 
                new Simple("GO TO JAIL"), 
                new Street("REGENT STREET"),
                new Street("OXFORD STREET"),
                new Community(),
                new Street("BOND STREET"), 
                new Railroad("LIVERPOOL ST. STATION"), 
                new Chance(), 
                new Street("PARK LANE"), 
                new Tax("SUPER TAX", 100), 
                new Street("MAYFAIR")
            };
        }
    }
}
