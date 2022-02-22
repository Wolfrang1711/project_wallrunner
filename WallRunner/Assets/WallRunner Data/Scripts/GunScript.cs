using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunScript : MonoBehaviour
{
    public GameObject bullet;
    public Camera cam;
    public Transform muzzle;

    public float bulletForce = 50.0f;
    public float damage = 20.0f;

    GameObject tempBullet;

    public Image muzzleFlashImage;
    public Sprite[] flashes;

    void Start()
    {
        muzzleFlashImage.color = new Color(0, 0, 0, 0);         
    }

    void Update()
    {
        //if(PauseMenuScript.isPaused)
        {
            //return;
        }
                
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
                shoot();
        }
        
        
    }

    void shoot()
    {
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;

        Vector3 target;
        if (Physics.Raycast(ray, out hit))
        {
            target = hit.point;
        }
        else
        {
            target = ray.GetPoint(75);
        }

        Vector3 bulletdirection = target - muzzle.position;
        tempBullet = Instantiate(bullet, muzzle.position, Quaternion.identity);
        tempBullet.GetComponent<Rigidbody>().AddForce(bulletdirection.normalized * bulletForce, ForceMode.Impulse);
        StartCoroutine(MuzzleFlash());
    }

    IEnumerator MuzzleFlash()
    {
        muzzleFlashImage.sprite = flashes[Random.Range(0, flashes.Length)];
        muzzleFlashImage.color = Color.white;
        yield return new WaitForSeconds(0.05f);
        muzzleFlashImage.sprite = null;
        muzzleFlashImage.color = new Color(0, 0, 0, 0);
    }
    
}
