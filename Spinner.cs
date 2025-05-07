using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float Xangle = 0f;
    [SerializeField]float Yangle=0f;
    [SerializeField] float Zangle = 0f;
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.Rotate(Xangle,Yangle,Zangle);
    }
}
