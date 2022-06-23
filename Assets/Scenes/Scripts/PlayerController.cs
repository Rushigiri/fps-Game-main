using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;


public class PlayerController : MonoBehaviour
{

    [SerializeField] Animator _animation;
    //[SerializeField] Joystick _joystick;
    public CinemachineFreeLook _cinemachine;
    //public Joystick joystick;
    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {
       // var h = _joystick.Horizontal;
        //var v = _joystick.Vertical; 

        //var h = Input.GetAxis("Horizontal");
        //var v = Input.GetAxis("Vertical");

        //_animation.SetFloat("horizontal", h);
        //_animation.SetFloat("vertical",v);
        //_cinemachine.m_XAxis.Value += joystick.Direction.x;
        //_cinemachine.m_YAxis.Value -= joystick.Direction.y / 100;

    }

    public void OnClickJump()
    {
        _animation.SetTrigger("jump");
    }
    public void OnClickAttack()
    {
        _animation.SetInteger("attackint",Random.Range(0,5));
        _animation.SetTrigger("attacktri");
    }
    
}
