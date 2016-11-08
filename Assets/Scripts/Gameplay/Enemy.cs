using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    public float Speed;
    public GameObject text;
    public bool Death;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.transform.Translate(Vector2.right * Time.deltaTime * Speed, Space.World);

	}
    void OnBecameInvisible(){
        Destroy(gameObject);
        if (!Death)
            GameObject.Find("Point").GetComponent<Pontos>().Vida--;
        
    }

}
