using UnityEngine;
using System.Collections;

/// <summary>
/// Controle da interface das vantagens de cada tipo de bala
/// </summary>
public class Barra2 : MonoBehaviour 
{
    public Transform seta;
    public GameObject obj;
    public GameObject obj2;
    public GameObject obj3;
    
	
	void Update () 
    {
        if (seta.position.x == 3.3f)
        {
            obj.transform.position = new Vector2(21.1f, 14.71f);
            obj2.transform.position = new Vector2(100, 100);
            obj3.transform.position = new Vector2(100, 100);
        }
        else if (seta.position.x == 5.86f)
        {
            obj2.transform.position = new Vector2(21.1f, 14.71f);
            obj.transform.position = new Vector2(100, 100);
            obj3.transform.position = new Vector2(100, 100);

        }
        else if (seta.position.x == (0.48f))
        {
            obj3.transform.position = new Vector2(21.1f, 14.71f);
            obj2.transform.position = new Vector2(100, 100);
            obj.transform.position = new Vector2(100, 100);

        }
	}
}
