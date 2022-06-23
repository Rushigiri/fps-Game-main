using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float life =5;
   // public int bulletspeed;
    // Start is called before the first frame update
    private void Awake()
    {
        //Destroy(gameObject, life);
    }

    //private void OnCollisionEnter(Collision collision)
    //{

    //    gameObject.SetActive(false);
    //   // Destroy(collision.gameObject);
    //    //Destroy(gameObject);
    //}

    // Update is called once per frame
    void Update()
    {
        life -= Time.deltaTime;
        if(life<=0)
        {
            transform.gameObject.SetActive(false);
            life = 5f;
        }
        transform.Translate(Vector3.up * 40 * Time.deltaTime);
        //transform.position += Vector3.forward * 5*Time.deltaTime;
    }
}
