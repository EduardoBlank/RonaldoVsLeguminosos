using UnityEngine;
using System.Collections;

/// <summary>
/// Esta serve para o dano de cada tipo de inimigo
/// </summary>
public class EnemyHP3 : MonoBehaviour
{

    public float maxHealth3 = 100f;
    public float curHealth3 = 0f;
    public GameObject healthBar3;
    public bool Alive3 = true;
    

    void Start()
    {
        curHealth3 = maxHealth3;
        SetHealthBar3();
        Alive3 = true;

    }
    /// <summary>
    /// Da o dano normal nos inimigos
    /// </summary>
    void DoDamage3()
    {
        takeDamege3(20f);
    }
    /// <summary>
    /// Da o dobro de dano nos inimigos que tal bala tem vantagem
    /// </summary>
    void DoDubleDamage3()
    {
        takeDamege3(40f);
    }


    /// <summary>
    /// Faz o controle de vida ou morte do inimigo ao receber um tiro
    /// </summary>
    /// <param name="amount">É a quantidade de vida do inimigo</param>
    public void takeDamege3(float amount)
    {
        if (!Alive3)
        {
            return;
        }
        if (curHealth3 <= 0)
        {
            curHealth3 = 0;
            Alive3 = false;
            GameObject.Find("Point").GetComponent<Pontos>().score++;
            GetComponent<Enemy>().Death = true;
            Destroy(gameObject);

        }
        curHealth3 -= amount;
        SetHealthBar3();
    }

    /// <summary>
    /// Controle da barra de HP do inimigo
    /// </summary>
    public void SetHealthBar3()
    {
        float my_health = curHealth3 / maxHealth3;
        healthBar3.transform.localScale = new Vector3(Mathf.Clamp(my_health, 0f, 1f), healthBar3.transform.localScale.y, healthBar3.transform.localScale.z);
    }
    /// <summary>
    /// Collisão entre a bala e o inimigo e o dano que recebe
    /// </summary>
    /// <param name="collider"></param>
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Chiclete"))
        {
            Destroy(collider.gameObject);
            DoDamage3();
        }
        if (collider.CompareTag("Bala"))
        {
            Destroy(collider.gameObject);
            DoDamage3();
        }
        if (collider.CompareTag("Pirulito"))
        {
            Destroy(collider.gameObject);
            DoDubleDamage3();
        }
    }

}