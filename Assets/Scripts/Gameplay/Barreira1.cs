using UnityEngine;
using System.Collections;

public class Barreira1 : MonoBehaviour {
    public GameObject obj;
    public GameObject obj2;
    public GameObject obj3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D collider)
    {
       
        Debug.Log("Deu");
        if (collider.gameObject.tag == "Bala")
        {
            Destroy(obj);
        }
    }

        
       
    }

