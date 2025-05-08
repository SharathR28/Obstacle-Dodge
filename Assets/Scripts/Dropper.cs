using Unity.VisualScripting;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timetowait = 3f;
    MeshRenderer mymeshRenderer;
    Rigidbody myrigidbody;
    void Start()
    {
        mymeshRenderer = GetComponent<MeshRenderer>();
        myrigidbody = GetComponent<Rigidbody>();
        mymeshRenderer.enabled=false;
        myrigidbody.useGravity = false;
    }

    
    void Update()
    {   
        if (Time.time>timetowait)
        {
            mymeshRenderer.enabled = true;
            myrigidbody.useGravity = true;
        }
    }
}