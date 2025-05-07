using UnityEngine;

public class Score : MonoBehaviour
{
    int hits = 0;

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag!="Hit")
        {
            hits += 1;
            Debug.Log("You've bumped into a thing this many time: " + hits);
        }
    }
}
