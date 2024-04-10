using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : MonoBehaviour
{
    [SerializeField]
    private GameObject projectil;
    [SerializeField]
    private GameObject projectilPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectil,projectilPosition.transform.position,projectil.transform.rotation);
        }
    }
}
