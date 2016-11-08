using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y == 0.15f)
        {
            transform.position = new Vector2(-7,-3.80f);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y == 0.15f)
        {
            transform.position = new Vector2(-7, 4);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y == 4)
        {
            transform.position = new Vector2(-7, 0.15f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y == 4)
        {
            transform.position = new Vector2(-7, 0.15f);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y == -3.80f)
        {
            transform.position = new Vector2(-7, 0.15f);
        }
	}
}
