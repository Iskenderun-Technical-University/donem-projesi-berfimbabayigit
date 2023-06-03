using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatKontroller : MonoBehaviour
{
    Rigidbody fizik;
   public float sagsol;
    public float ilerigeri;
    public Transform yol1, yol2;
    void Start()
    {
        fizik = GetComponent<Rigidbody>(); 
    }
    public void OnTriggerEnter(Collider nesne)
    {
        if (nesne.gameObject.tag == "yol1")
        {
            yol2.position = new Vector3(yol1.position.x, yol1.position.y, yol1.position.z + 40.0f);
        }
        if (nesne.gameObject.tag == "yol2")
        {
            yol1.position = new Vector3(yol2.position.x, yol2.position.y, yol2.position.z + 40.0f);
        }
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            fizik.AddForce(0f, 0f, -ilerigeri);
        if (Input.GetKey(KeyCode.S))
            fizik.AddForce(0f, 0f, ilerigeri);
        if (Input.GetKey(KeyCode.A))
            fizik.AddForce(sagsol, 0f, 0f);
        if (Input.GetKey(KeyCode.D))
            fizik.AddForce(-sagsol, 0f, 0f);
    }
}
