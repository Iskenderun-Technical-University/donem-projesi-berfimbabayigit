using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class klon : MonoBehaviour
{
    public float sagk�s�m = 29.23f;
    public float solk�s�ma = 21.27f;
    public float ortak�s�m = 25.31f;
    public GameObject alt�n, engel2, engelKpk;
    public Transform karakter;
    void Start()
    {
        InvokeRepeating("klonla", 0, 1.0f); 
    }

    public void klonla()
    {
        int say� = Random.Range(0, 100);
        
        if(say�> 0 && say�< 100)
        {
            olustur(alt�n, 1.0f);
            
        }
        /*if(say� > 80)
        {
            olustur(engel, 0.0f);
        }*/
        if (say� > 85)
        {
            olustur(engel2, 0.0f);
        }
        if (say� > 70)
        {
            olustur(engelKpk, 0.0f);
        }
    }
    public void olustur(GameObject nesne, float �st)
    {
        GameObject yeniklon = Instantiate(nesne);
        int say� = Random.Range(0, 100);
        if (say�< 50)
        {
            yeniklon.transform.position = new Vector3(sagk�s�m, �st, karakter.position.z + 30.0f);
        }
        if( say� > 50)
        {
            yeniklon.transform.position = new Vector3(solk�s�ma, �st, karakter.position.z + 30.0f);

        }
        if (say� > 40)
        {
            yeniklon.transform.position = new Vector3(ortak�s�m, �st, karakter.position.z + 30.0f);

        }
    }
}

