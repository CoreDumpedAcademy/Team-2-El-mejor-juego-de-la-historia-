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
            Debug.Log(PlayerPrefs.GetInt("Highscore_count"));
            Debug.Log(PlayerPrefs.GetString("User_1"));
            SceneManager.LoadScene("SampleScene");
        }
    }

    private void checkScores(int myscore)
    {
        for(int i=0;i< PlayerPrefs.GetInt("Highscore_count"); i++)
        {

        }
    }
}
