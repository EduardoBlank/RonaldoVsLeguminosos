using UnityEngine;
using System.Collections;

public class Transition : MonoBehaviour
{   
    /// <summary>
    /// Método para fazer troca de cenas
    /// </summary>
    /// <param name="cena">Recebe a cena</param>
    public void trocarDeCema(int cena)
    {
        Application.LoadLevel(cena);
    }   
}
