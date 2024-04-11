using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : MonoBehaviour
{
    [SerializeField]
    private GameObject projectil;
    [SerializeField]
    private GameObject projectilPosition;
    [SerializeField]
    private ParticleSystem shootParticle;
   

    private AudioSource playerAudio;

    [SerializeField]
    private AudioClip shootSound;

    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectil,projectilPosition.transform.position, projectilPosition.transform.rotation);
            //bullet.transform.SetParent(projectilPosition.transform);
            playerAudio.PlayOneShot(shootSound);
            shootParticle.Play();

            
        }

    }
}
