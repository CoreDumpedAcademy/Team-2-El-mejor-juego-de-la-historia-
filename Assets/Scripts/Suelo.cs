using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suelo : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "suelo")
        {
            Destroy(col.gameObject);
        }
    }
}
