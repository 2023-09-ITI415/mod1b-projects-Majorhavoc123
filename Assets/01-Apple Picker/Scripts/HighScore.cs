using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Remember, we need this line for uGUI to work
using TMPro;            

public class HighScore : MonoBehaviour
{
    static public int score = 1000;
    // Start is called before the first frame update

    void Awake(){
        if (PlayerPrefs.HasKey("HighScore")){
            score = PlayerPrefs.GetInt("HighScore");
        }
        PlayerPrefs.SetInt("HighScore", score);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI gt = this.GetComponent<TextMeshProUGUI>();
        gt.text = "High Score: "+score;

        if (score > PlayerPrefs.GetInt("HighScore")){
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}
