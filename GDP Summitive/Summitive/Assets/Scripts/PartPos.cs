using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartPos : MonoBehaviour
{

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
    }
}
