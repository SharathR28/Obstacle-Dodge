using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float flyspeed = 0f;
    [SerializeField] Transform player;
    Vector3 PlayerPosition;
    void Awake()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        PlayerPosition = player.transform.position;
    }

    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }
    void DestroyWhenReached()
    {
        if (transform.position==PlayerPosition)
        {
            Destroy(gameObject);
        }
    }
    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, PlayerPosition, flyspeed * Time.deltaTime);
    }
}
