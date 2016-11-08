using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pontos : MonoBehaviour {
    public int score;
    public TextMesh text;
    public TextMesh Life;
    public int Vida;
	// Use this for initialization
	void Start () {
       
        
        score = 0;
        Vida = 5;

	}
	
	// Update is called once per frame
	void Update () {
        if (score < 0)
        {
            score = 0;
        }
        text.text = "Score : " + score;
        Life.text = "= " + Vida;
	}
    
   
}
