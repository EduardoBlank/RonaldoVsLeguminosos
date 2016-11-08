using UnityEngine;
using System.Collections;

/// <summary>
/// Esta serve para o dano de cada tipo de inimigo 
/// Métodos iguais do EnemyHP3
/// </summary>
public class EnemyHP2 : MonoBehaviour
{

    public float maxHealth2 = 100f;
    public float curHealth2 = 0f;
    public GameObject healthBar2;
    public bool Alive2 = true;
    

    // Use this for initialization
    void Start()
    {
        curHealth2 = maxHealth2;
        SetHealthBar2();
        Alive2 = true;

    }
    void DoDamage2()
    {
        takeDamege2(20f);
    }
    void DoDubleDamage2()
    {
        takeDamege2(40f);
    }

    public void takeDamege2(float amount)
    {
        if (!Alive2)
        {
            return;
        }
        if (curHealth2 <= 0)
        {
            curHealth2 = 0;
            Alive2 = false;
            GameObject.Find("Point").GetComponent<Pontos>().score++;
            GetComponent<Enemy>().Death = true;
            Destroy(gameObject);

        }
        curHealth2 -= amount;
        SetHealthBar2();
    }

    public void SetHealthBar2()
    {
        float my_health = curHealth2 / maxHealth2;
        healthBar2.transform.localScale = new Vector3(Mathf.Clamp(my_health, 0f, 1f), healthBar2.transform.localScale.y, healthBar2.transform.localScale.z);
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Chiclete"))
        {
            Destroy(collider.gameObject);
            DoDamage2();
        }
        if (collider.CompareTag("Pirulito"))
        {
            Destroy(collider.gameObject);
            DoDamage2();
        }
        if (collider.CompareTag("Bala"))
        {
            Destroy(collider.gameObject);
            DoDubleDamage2();
        }
    }

}