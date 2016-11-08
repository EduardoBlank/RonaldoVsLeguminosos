using UnityEngine;
using System.Collections;

/// <summary>
/// Esta serve para o dano de cada tipo de inimigo 
/// Métodos iguais do EnemyHP3
/// </summary>
public class EnemyHP1 : MonoBehaviour 
{

    public float maxHealth = 100f;
    public float curHealth = 0f;
    public GameObject healthBar;
    public bool Alive = true;

    
	void Start () 
    {
        curHealth = maxHealth;
        SetHealthBar();
        Alive = true;
       
	}
    void DoDamage()
    {
        takeDamege(20f);
    }
    void DoDubleDamage()
    {
        takeDamege(40f);
    }

	void Update () {
	
	}
   
    
   public void takeDamege(float amount)
    {
        if (!Alive)
        {
            return;
        }
        if (curHealth <= 0)
        {
            curHealth = 0;
                Alive = false;
                GameObject.Find("Point").GetComponent<Pontos>().score++;
                GetComponent<Enemy>().Death = true;
                Destroy(gameObject);

        }
        curHealth -= amount;
        SetHealthBar();
    }

   public void SetHealthBar()
   {
       float my_health = curHealth / maxHealth;
       healthBar.transform.localScale = new Vector3(Mathf.Clamp(my_health, 0f, 1f), healthBar.transform.localScale.y, healthBar.transform.localScale.z);
   }
   void OnTriggerEnter2D(Collider2D collider)
   {
       if (collider.CompareTag("Bala"))
       {
           Destroy(collider.gameObject);

           DoDamage();
          
       }
       if (collider.CompareTag("Pirulito"))
       {
           Destroy(collider.gameObject);
           DoDamage();
       }
       if (collider.CompareTag("Chiclete"))
       {
           Destroy(collider.gameObject);
           DoDubleDamage();
       }
   }
        
}

