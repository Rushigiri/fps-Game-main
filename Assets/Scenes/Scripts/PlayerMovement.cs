using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float VerticalInput;
    public float HorizontalInput;
    public float speed;
    public Animator _animator;
    public TextMeshProUGUI Htext;
    public int health;

    public static PlayerMovement instance;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        health = 100;
    }
    

    // Update is called once per frame
    void Update()
    {
        VerticalInput = Input.GetAxis("Vertical");
        HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * VerticalInput * speed * Time.deltaTime);
        transform.Translate(Vector3.right * HorizontalInput * speed  * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);

        if(Input.GetMouseButtonDown(0))
        {
            _animator.SetTrigger("shoot");

        }
        if(health <= 20 && health >= 0)
        {
            Htext.color = Color.red;
        }

        if(health <= 0)
        {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(2);
        }
    }

    public void healthManage()
    {
        Htext.text = health.ToString();

    }
    public void healthReduction(int reduce)
    {
        health -= reduce;
        healthManage();

    }

}
