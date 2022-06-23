using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    public Transform player;
    float z = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");
        z -= y;
        z = Mathf.Clamp(z, -90f, 30f);
        player.Rotate(Vector3.up * x);
        transform.localRotation = Quaternion.Euler(z, 0f, 0f);
        // Debug.Log("heloo");
    }
}
