using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Test : MonoBehaviour
{
    public GameObject projectil;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Instantiate(projectil, transform.position, projectil.transform.rotation);
        }
    }
}
