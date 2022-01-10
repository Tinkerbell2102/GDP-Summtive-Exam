using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_Repeat : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position; // Establish the default starting position 
        repeatWidth = GetComponent<BoxCollider>().size.z / 2; // Set repeat width to half of the background
    }

    // Update is called once per frame
    void Update()
    {
        // If background moves down by its repeat width, move it back to start position
        if (transform.position.y < startPos.y - repeatWidth)
        {
            transform.position = startPos;
        }
    }
}
