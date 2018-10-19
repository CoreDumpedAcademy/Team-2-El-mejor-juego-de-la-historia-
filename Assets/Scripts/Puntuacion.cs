﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuacion : MonoBehaviour {

    private int puntuacion = 0;
    public TextMesh Marcador;

	// Use this for initialization
	void Start () {
        NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarPuntos");
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
        Marcador.text = puntuacion.ToString();
    }

	// Update is called once per frame
	void Update () {
		
	}
} 
