using UnityEngine;
using System.Collections;

public class Transition : MonoBehaviour {

	
   public void Jogar()
    {
        Application.LoadLevel(1);
    }
   public void Sobre()
   {
       Application.LoadLevel(2);
   }
   public void Exit()
   {
       Application.Quit();
   }
    public void Back()
   {
       
           Application.LoadLevel(0);
       
   }
}
