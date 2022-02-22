using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float dmg = 20.0f;
    float delay = 5;
       
    void Update()
    {
        StartCoroutine(bulletSelfDestruct());
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Boss")
        {
            collision.gameObject.GetComponent<Boss>().currentHealth -= dmg;
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<Enemy>().currentHealth -= dmg;
            Destroy(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    IEnumerator bulletSelfDestruct()
    {
        yield return new WaitForSeconds(delay);

        Destroy(this.gameObject);
    }
}
