using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerKiller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            int winners = PlayerPrefs.GetInt("Highscore_count", 0);
            if (winners != 0) checkScores(GlobalVars.score, winners);
            else
            {
                PlayerPrefs.SetInt("Highscore_count", 1);
                PlayerPrefs.SetString("User_0", GlobalVars.userName);
                PlayerPrefs.SetInt("Highscore_0", GlobalVars.score);
            }
            //Debug.Log(PlayerPrefs.GetString("User_1"));
            winners = PlayerPrefs.GetInt("Highscore_count", 0);
            if (winners > 0) printScores(winners);
            SceneManager.LoadScene("Default Scene");
        }
    }

    private void checkScores(int myscore, int winners)
    {
        Debug.Log("new Score: "+ myscore);
        for(int i=0;i< winners; i++)
        {
            if (PlayerPrefs.GetInt("Highscore_" + i, 0) < myscore)
            {
                Insertar(winners, i);
                break;
            }
        }
    }

    private void Insertar(int winners, int pos)
    {
        int i;
        if (winners < 5)
        {
            winners++;
            PlayerPrefs.SetInt("Highscore_count", winners);
        }
        for (i = winners - 1; i < pos; i--)
        {
            PlayerPrefs.SetInt("Highscore_"+i, PlayerPrefs.GetInt("Highscore_" + (i-1), 0));
            PlayerPrefs.SetString("User_" + i, PlayerPrefs.GetString("User_" + (i - 1), "Player1234"));
        }
        PlayerPrefs.SetInt("Highscore_" + pos, GlobalVars.score);
        PlayerPrefs.SetString("User_" + pos, GlobalVars.userName);
    }

    private void printScores(int winners)
    {
        for(int i = 0; i < winners; i++) {
            Debug.Log("Highscore "+i+": "+PlayerPrefs.GetInt("Highscore_" + i, -23));
            Debug.Log("User " + i + ": " + PlayerPrefs.GetString("User_" + i, "Jonathan"));
        }
    }
}
