using UnityEngine;
using System.Collections;

/// <summary>
/// É o controle da interface da bala utilizada
/// </summary>
public class Barra : MonoBehaviour 
{
 
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x == 3.3f)
        {
            transform.position = new Vector2(0.48f, 14.71f);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x == 0.48f)
        {
            transform.position = new Vector2(5.86f, 14.71f);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x == 5.86f)
         {
            transform.position = new Vector2(3.3f, 14.71f);
         }


        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x == 3.3f)
        {
            transform.position = new Vector2(5.86f, 14.71f);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x == 5.86f)
        {
            transform.position = new Vector2(0.48f, 14.71f);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x == 0.48f)
        {
            transform.position = new Vector2(3.3f, 14.71f);
        }
	}
}
