using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPick : MonoBehaviour
{
    float rotspeed = 50f;

    private void Update()
    {
        transform.Rotate(Vector3.up * rotspeed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(collision.gameObject.GetComponent<PlayerHel>().currentHealth < 100f)
            {
                collision.gameObject.GetComponent<PlayerHel>().currentHealth = 100f;
                Destroy(this.gameObject);
            }
            
        }
    }
}
