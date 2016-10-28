using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetPilotName : MonoBehaviour {

    GameObject gs;
	// Use this for initialization
	void Start () {
        gs = GameObject.FindGameObjectWithTag("GameSettings");
        gameObject.GetComponent<Text>().text = "#!/ Pilot-" + gs.GetComponent<GameSettings>().pilot_name + " /~#";
	}
}
