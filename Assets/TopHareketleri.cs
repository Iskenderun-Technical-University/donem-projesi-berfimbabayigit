using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopHareketleri : MonoBehaviour
{
    Rigidbody rb;
    float Xmovement;
    float Zmovement;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        Xmovement = Input.GetAxis("Horizontal") * speed;
        Zmovement = Input.GetAxis("Vertical") * speed;
        rb.AddForce(Xmovement, 0, Zmovement);
    }
}

