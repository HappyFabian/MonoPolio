using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Board : MonoBehaviour
{
   [SerializeField]
   public Space[] BoardSpaces = new Space[]{
            new Simple("GO"),
            new Street("MEDITERRANEAN AVENUE"), 
            new Community(), 
            new Street("BALTIC AVENUE"), 
            new Tax("INCOME TAX", 200), 
            new Railroad("READING RAILROAD"), 
            new Street("ORIENTAL AVENUE"), 
            new Chance(), 
            new Street("VERMONT AVENUE"), 
            new Street("CONNECTICUT AVENUE"), 
            new Simple("JAIL"),
            new Street("ST. CHARLES PLACE"), 
            new Utility("ELECTRIC COMPANY"), 
            new Street("STATES AVENUE"), 
            new Street("VIRGINIA AVENUE"), 
            new Railroad("PENNSYLVANIA RAILROAD"), 
            new Street("ST. JAMES PLACE"), 
            new Community(), 
            new Street("TENNESSEE AVENUE"), 
            new Street("NEW YORK AVENUE"), 
            new Simple("FREE PARKING"), 
            new Street("KENTUCKY AVENUE"), 
            new Chance(), 
            new Street("INDIANA AVENUE"), 
            new Street("ILINOIS AVENUE"), 
            new Railroad("B & O RAILROAD"), 
            new Street("ATLANTIC AVENUE"), 
            new Street("VENTNOR AVENUE"), 
            new Utility("WATERWORKS"), 
            new Street("MARVIN GARDENS"), 
            new Simple("GO TO JAIL"), 
            new Street("PACIFIC AVENUE"),
            new Street("NORTH CAROLINA AVENUE"),
            new Community(),
            new Street("PENNSYLVANIA AVENUE"), 
            new Railroad("SHORT LINE"), 
            new Chance(), 
            new Street("PARK PLACE"), 
            new Tax("LUXURY TAX", 100), 
            new Street("BOARDWALK")
        };

}

