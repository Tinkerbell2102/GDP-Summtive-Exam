using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    AudioSource audio;
    public AudioClip asteriodBoom;
    public ParticleSystem explosionParticle;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        //Laser destroys the asteriods
        if (other.gameObject.CompareTag("Asteroid") && gameObject.CompareTag("Lazer"))
        {
            audio.PlayOneShot(asteriodBoom);
            gameManager.UpdateScore(1);
            
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        //Player collision
        else if (gameObject.CompareTag("Asteroid") && other.gameObject.CompareTag("Player"))
        {
            Instantiate(explosionParticle, transform.position , transform.rotation);
            explosionParticle.Play();
            gameManager.GameOver();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
