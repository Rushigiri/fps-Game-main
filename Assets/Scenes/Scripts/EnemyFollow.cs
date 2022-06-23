using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    //public Transform target;
   // public GameObject target;
    public float speed;
    public float distance;
    Rigidbody rig;
    public Animator zombieAnim;
    //public GameObject player;
    

    public float consecutiveAttackInterval;


    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        consecutiveAttackInterval = 2f;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = PlayerMovement.instance.transform.position - transform.position;

        if (v.magnitude < distance)
        {
            consecutiveAttackInterval -= Time.deltaTime;
            rig.velocity = Vector3.zero;
            zombieAnim.SetBool("attack", true);
           
            if (consecutiveAttackInterval<=0)
            {
                //player.gameObject.GetComponent<PlayerMovement>().healthReduction(1);

                PlayerMovement.instance.gameObject.GetComponent<PlayerMovement>().healthReduction(5);
                consecutiveAttackInterval = 2f;
            }
           
        }
        else
        {
            zombieAnim.SetBool("attack",false);
            //make the enemy towerd the player
            Vector3 pos = Vector3.MoveTowards(transform.position, PlayerMovement.instance.transform.position, speed * Time.deltaTime);
            rig.MovePosition(pos);            
            transform.LookAt(PlayerMovement.instance.transform);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.GetComponent<bullet>() != null)
        {
            collision.gameObject.SetActive(false);
            Debug.Log("hit bullet");
            Destroy(gameObject);
        }
    }
}
