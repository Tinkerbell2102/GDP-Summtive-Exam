using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
     // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        //Laser destroys the asteriods
        if (other.gameObject.CompareTag("Asteroid"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
       
    }
}
