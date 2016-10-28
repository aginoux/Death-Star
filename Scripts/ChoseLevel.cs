using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChoseLevel : MonoBehaviour {

    GameObject Ppf;

    public void Start()
    {
        Ppf = GameObject.FindGameObjectWithTag("GameSettings");
    }

    public void chose_level(int level)
    {
        Ppf.SendMessage("saveString");
        SceneManager.LoadScene(level);
    }

}
