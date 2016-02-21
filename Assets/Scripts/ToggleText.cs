using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ToggleText : MonoBehaviour {

    public string TrueText;
    public string FalseText;
    public Text target;

    public void TogglingText(float value)
    {  
       if(value == 0)
       {
          target.text = FalseText;
       }
       else
       {
          target.text = TrueText;
       }
    }
}
