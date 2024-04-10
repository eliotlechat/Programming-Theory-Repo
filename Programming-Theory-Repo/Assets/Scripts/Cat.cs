using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    public Cat() : base("Chat")
    {
        Debug.Log("Un nouveau chat a été créé");
    }

    public void Purr()
    {
        Debug.Log("Le chat ronronne.");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
