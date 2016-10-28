using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour {

    public string pilot_name;
    public int pilot_score;
    public GameObject inp_field;

    void Start()
    {
        inp_field = GameObject.FindGameObjectWithTag("InputField");
    }

    void Awake()
    {
        DontDestroyOnLoad(this);
    }
    void saveString()
    {
        InputField input_text = inp_field.GetComponent<InputField>();
        pilot_name = input_text.text;
        //print(pilot_name);
    }

    void saveInt(int score)
    {
        pilot_score = score;
        print("Score Finale : " + pilot_score);
    }


}
