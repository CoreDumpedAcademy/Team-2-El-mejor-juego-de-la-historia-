using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour {

    private int puntuacion = 0;
    private float timer;
    //public TextMesh Marcador;
    public Text m_MyText;

    // Use this for initialization
    void Start () {
        //NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarPuntos");
        ActualizarMarcador();
	}
	
    void IncrementarPuntos(Notification notificacion)
    {
        int puntosAIncrementar = (int)notificacion.data;
        puntuacion+=puntosAIncrementar;
        GlobalVars.score += puntosAIncrementar;
        ActualizarMarcador();
    }

    void ActualizarMarcador()
    {
        //Marcador.text = puntuacion.ToString();
        m_MyText.text = puntuacion.ToString();
    }

	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if (timer > 1f)
        {

            puntuacion += 1;

            ActualizarMarcador();

            timer = 0;
        }
    }
} 
