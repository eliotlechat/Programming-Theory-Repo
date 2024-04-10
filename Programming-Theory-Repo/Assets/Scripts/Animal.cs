using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public string species;
    public Animal(string animalSpecies)
    {
        species = animalSpecies;
        Debug.Log("Un nouvel animal de l'espèce " + species + "a été trouvé");
    }
   
    public void MakeSound()
    {
        Debug.Log("L'animal de l'espèce" + species + "émet un son");
    }


}
