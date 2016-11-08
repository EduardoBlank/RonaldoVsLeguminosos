using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pontos : MonoBehaviour 
{
    public int score;
    public Text scoreUi;
    public Text Life;
    public int Vida;

	void Start () 
    {
        score = 0;
        Vida = 5;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (score < 0)
        {
            score = 0;
        }
        scoreUi.text = "Score : " + score;
        Life.text = "= " + Vida;

        if(Vida < 0)
        {
            Vida = 0;
        }

        if (Vida <= 0)
        {
            Time.timeScale = 0f;
        }
	}
    
   
}
