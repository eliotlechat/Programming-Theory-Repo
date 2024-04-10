using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public string species;
    public Animal(string animalSpecies)
    {
        species = animalSpecies;
        Debug.Log("Un nouvel animal de l'esp�ce " + species + "a �t� trouv�");
    }
   
    public void MakeSound()
    {
        Debug.Log("L'animal de l'esp�ce" + species + "�met un son");
    }


}
