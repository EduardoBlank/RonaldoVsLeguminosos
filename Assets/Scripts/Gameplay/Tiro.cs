using UnityEngine;
using System.Collections;

public class Tiro : MonoBehaviour {
    public GameObject[] bala;
    public Transform Spawn;
    public float cooldownTime;
    public bool cooldown;
    public int currentBullet;

	// Use this for initialization
	void Start () {
        cooldown = false;
	}
	
	// Update is called once per frame
	void Update () {
        BasicInputs();
	}
    void Shoot()
    {
        if (!cooldown)
        {
            Object bullet = Instantiate(bala[currentBullet], Spawn.position, Quaternion.identity);
            bullet.name = "munição";
            cooldown = true;
            StartCoroutine(Refresh());
        }
    }
    IEnumerator Refresh()
    {
        yield return new WaitForSeconds(cooldownTime);
        cooldown = false;
    }
    void BasicInputs()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Shoot();
        if (Input.GetKeyDown(KeyCode.LeftArrow)){
            if(currentBullet <= 0)
                currentBullet = bala.Length - 1;
            else
                currentBullet--;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currentBullet >= bala.Length -1)
                currentBullet = 0;
            else
                currentBullet++;
        }
    }
}
