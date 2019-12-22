using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonEventHandler : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vb;
    public Animator ani;

    void Start()
    {
        //注册事件处理器
        VirtualButtonBehaviour vbb = vb.GetComponent<VirtualButtonBehaviour>();
        //在虚拟按钮中注册TrackableBehaviour事件
        if (vbb)
        {
            vbb.RegisterEventHandler(this);
        }
    }
    
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        ani.SetTrigger("attack");
        Debug.Log("Button Pressed!");  
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        ani.SetTrigger("wait");
        Debug.Log("Button Released!");
    }
}