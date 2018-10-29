using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour {

    private int puntuacion = 0;
    private float timer;
    //public TextMesh Marcador;
    public Text m_MyText;

    public GameObject myImage;
    Image m_Image;

    Sprite[] mySprites;

    // Use this for initialization
    void Start () {
        //NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarPuntos");
        m_Image = myImage.GetComponent<Image>();
        mySprites= Resources.LoadAll<Sprite>("Rainb Sprites");
        GlobalVars.score = 0;
        ActualizarMarcador();
    }
	
    void IncrementarPuntos(Notification notificacion)
    {
        int puntosAIncrementar = (int)notificacion.data;
        puntuacion+=puntosAIncrementar;
        ActualizarMarcador();
    }

    void ActualizarMarcador()
    {
        //Marcador.text = puntuacion.ToString();
        m_MyText.text = puntuacion.ToString("000");
        //Sprite mysprite1 = mySprites[puntuacion/10];
        int spriteIndex = (puntuacion / 10) <= 7 ? puntuacion / 10 : 7; 
        m_Image.sprite = mySprites[spriteIndex];
    }

	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if (timer > 1f)
        {

            puntuacion += 1;
            GlobalVars.score += 1;

            ActualizarMarcador();

            timer = 0;
        }
    }
} 
