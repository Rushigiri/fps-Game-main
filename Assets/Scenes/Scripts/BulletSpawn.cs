using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject bulletPrefabe;
    public float bulletSpeed;
    public ParticleSystem _muzzleFlash;
   // public Rigidbody _rigidbody;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
       //if(Input.GetMouseButtonDown(0))
       // {
       //     var bullet = Instantiate(bulletPrefabe, spawnPoint.position, spawnPoint.rotation);
       // }
            //
            //bullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * bulletSpeed;
    }

}

