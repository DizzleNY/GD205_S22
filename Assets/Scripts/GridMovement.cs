using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMovement : MonoBehaviour
{

    public Vector3 fwd, Right, Back, Left, Up, Down;
    public Transform hazard, key;
    Vector3 startPos;
    public bool hasKey;

    // Start is called before the first frame update
    void Start() //like setup
    {
        startPos = transform.position;
        hasKey = false;
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
            transform.position += Back;

        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("you pressed e:)");
            transform.position += Up;

        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("you pressed q:)");
            transform.position += Down;

        }

        if (hazard.position == transform.position)
        {
            transform.position = startPos;

        }

        if (key.position == transform.position)
            hasKey = true;
    }
}
