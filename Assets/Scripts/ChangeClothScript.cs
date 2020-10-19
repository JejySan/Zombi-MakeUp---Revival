using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeClothScript : MonoBehaviour
{
    public GameObject SelectedCloth, spawnPoint, hatSpawnPoint, torsoSpawnPoint, legSpawnPoint, footSpawnPoint, instance;
    public float ScaleReduce;
    public bool clothPut, clothPutHat, clothPutTorso, clothPutLeg, clothPutFoot;
    public string clothName, clothNameHat, clothNameTorso, clothNameLeg, clothNameFoot;

    public void PutCloth()
    {
        clothName = SelectedCloth.name;
        if(spawnPoint.transform.Find(clothName+"(Clone)") != null) // Pour vérifier si y'a pas déjà quelque chose là ou on veut faire spawner notre vêtement
        {
            Destroy(instance);
            Debug.Log(SelectedCloth+" viré");
        }
        instance = Instantiate(SelectedCloth, spawnPoint.transform);
        instance.transform.localScale = instance.transform.localScale / ScaleReduce; // La variable ScaleReduce j'ai dû la mettre parce que, pour une raison encore inconnue, l'armature importée est de taille x100
        
        
        Debug.Log("Et Hop !");
        return;
    }

    public void HatPut()
    {

    }
    public void TorsoPut()
    {
        
    }
    public void LegPut()
    {
        
    }
    public void FootPut()
    {
        
    }
    public void HatDisabled()
    {
        
    }
    public void TorsoDisabled()
    {
        
    }
    public void LegDisabled()
    {
        
    }
    public void FootDisabled()
    {
        
    }
}
