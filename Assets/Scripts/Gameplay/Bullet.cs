using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
    public float Speed;
    float damage = 5f;
   

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.transform.Translate(Vector2.right * Time.deltaTime * Speed, Space.World);
	}

    void OnTriggerEnter(Collider other)
    {
        damage = Random.Range(5f, 10f);
        other.gameObject.GetComponent<EnemyHP1>().takeDamege(damage);
        
        
    }
    void OnTriggerEnter2(Collider Diferente)
    {
        damage = Random.Range(5f, 10f);
        Diferente.gameObject.GetComponent<EnemyHP2>().takeDamege2(damage);
        
    }
    void OnTriggerEnter3(Collider Tlgd)
    {
        damage = Random.Range(5f, 10f);
        Tlgd.gameObject.GetComponent<EnemyHP3>().takeDamege3(damage);
        
    }
}
