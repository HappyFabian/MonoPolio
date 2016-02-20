using UnityEngine;
using System.Collections;

public class SelectedPlayer : MonoBehaviour {

        public bool IsOn;
        public int PlayerKind;
        public string name;


        public SelectedPlayer(string Name, int PlayerKind)
        {
            this.name = Name;
            this.PlayerKind = PlayerKind;
        }
}
