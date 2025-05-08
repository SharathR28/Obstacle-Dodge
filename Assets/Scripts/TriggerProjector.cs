using UnityEngine;

public class TriggerProjector : MonoBehaviour
{
    [SerializeField] GameObject Projector1;
    [SerializeField] GameObject Projector2;
    [SerializeField] GameObject Projector3;
    [SerializeField] GameObject Projector4;
    [SerializeField] GameObject Projector5;
    

    void Start()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            Projector1.SetActive(true);
            Projector2.SetActive(true);
            Projector3.SetActive(true);
            Projector4.SetActive(true);
            Projector5.SetActive(true);
            Destroy(gameObject);
        }
    }
}
