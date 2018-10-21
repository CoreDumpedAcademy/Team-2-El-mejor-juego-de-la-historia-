using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

    public static GameObject[] myObjects;

    public GameObject myGobj;

    // Use this for initialization
    void Start () {
        myObjects = Resources.LoadAll<GameObject>("Prefabs");
        myInstantiation();
    }
	
	// Update is called once per frame
	void Update () {
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground"|| col.gameObject.tag == "Platform")
        {
            Destroy(col.gameObject);
            //Instantiate(myPrefab, new Vector2(17, 0), Quaternion.identity);
        }
        else if (col.gameObject.tag == "prefab")
        {
            BoxCollider2D bc2d = col.gameObject.GetComponent<BoxCollider2D>();
            float width = bc2d.bounds.size.x;
            Destroy(col.gameObject);
            myInstantiation();
        }
    }

    void myInstantiation()
    {
        int whichItem = Random.Range(0, myObjects.Length);
        BoxCollider2D bc2d = myGobj.GetComponent<BoxCollider2D>();
        float width = bc2d.bounds.size.x;
        transform.position = new Vector2(-14 - width, transform.position.y);
        GameObject mygob = Instantiate(myObjects[whichItem], new Vector2(myGobj.transform.position.x+width+5, 0), Quaternion.identity);
        myGobj = mygob;
        bc2d = mygob.GetComponent<BoxCollider2D>();
        width = bc2d.bounds.size.x;
    }
}
