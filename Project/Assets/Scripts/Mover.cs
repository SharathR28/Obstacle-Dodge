using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]float Movespeed = 5f;

    void Start()
    {
        PrintInstruction();
    }

    void Update()
    {
        MovePlayer();
    }
    void PrintInstruction()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Moving Controls are simple just press the ASWD key");
        Debug.Log("Don't hit the Obstacles");
    }
    void MovePlayer()
    {
        float xvalue = Input.GetAxis("Horizontal") * Time.deltaTime;
        float yvalue = 0.0f;
        float zvalue = Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(xvalue * Movespeed, yvalue, zvalue * Movespeed);
    }
}