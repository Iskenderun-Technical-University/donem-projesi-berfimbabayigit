using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class klon : MonoBehaviour
{
    public float sagkýsým = 29.23f;
    public float solkýsýma = 21.27f;
    public float ortakýsým = 25.31f;
    public GameObject altýn, engel2, engelKpk;
    public Transform karakter;
    void Start()
    {
        InvokeRepeating("klonla", 0, 1.0f); 
    }

    public void klonla()
    {
        int sayý = Random.Range(0, 100);
        
        if(sayý> 0 && sayý< 100)
        {
            olustur(altýn, 1.0f);
            
        }
        /*if(sayý > 80)
        {
            olustur(engel, 0.0f);
        }*/
        if (sayý > 85)
        {
            olustur(engel2, 0.0f);
        }
        if (sayý > 70)
        {
            olustur(engelKpk, 0.0f);
        }
    }
    public void olustur(GameObject nesne, float üst)
    {
        GameObject yeniklon = Instantiate(nesne);
        int sayý = Random.Range(0, 100);
        if (sayý< 50)
        {
            yeniklon.transform.position = new Vector3(sagkýsým, üst, karakter.position.z + 30.0f);
        }
        if( sayý > 50)
        {
            yeniklon.transform.position = new Vector3(solkýsýma, üst, karakter.position.z + 30.0f);

        }
        if (sayý > 40)
        {
            yeniklon.transform.position = new Vector3(ortakýsým, üst, karakter.position.z + 30.0f);

        }
    }
}

