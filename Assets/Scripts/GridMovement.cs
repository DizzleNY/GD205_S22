using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMovement : MonoBehaviour
{

    public Vector3 fwd;  
    public Vector3 Right;
    public Vector3 Down;
    public Vector3 Left;

    // Start is called before the first frame update
    void Start() //like setup
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("you pressed w:)");
            transform.position += fwd;

        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("you pressed w:)");
            transform.position += Right;

        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("you pressed w:)");
            transform.position += Left;

        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("you pressed w:)");
            transform.position += Down;

        }
    }
}
