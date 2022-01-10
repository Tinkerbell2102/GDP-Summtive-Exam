using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 30.0f;
    private float xRange = 41;
    public GameObject lazerPrefab;
    bool fired = false;
    AudioSource audio;
    public AudioClip fire;
    public ParticleSystem explosionParticle;
    private GameManager gameManager;


// Start is called before the first frame update
void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Keep player in bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //Player Movement
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.left * horizontalInput * Time.deltaTime * speed);

        //Lazer from player
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Fire the Lazers
            if (fired == false) 
            {
                audio.PlayOneShot(fire);
                fired = true;
                Instantiate(lazerPrefab, transform.position, lazerPrefab.transform.rotation);
                StartCoroutine(Wait());
            }
        }
    }
    //Fire 2 bullets per second
     IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.5f);
        fired = false;
    }
}
