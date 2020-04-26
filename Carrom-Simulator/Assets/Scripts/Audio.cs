using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{

    public AudioClip CoinCollisionSound;
    public AudioSource CollisionSoundSource;
    // Start is called before the first frame update
    void Start()
    {
        CollisionSoundSource.clip = CoinCollisionSound;
    }

    private void OnTriggerEnter(Collider other)
    {
        CollisionSoundSource.Play();
        Debug.Log("Play Audio");
    }

    
}
