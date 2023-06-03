using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
   private AudioSource audioSource;
    [SerializeField] AudioClip Yemek, Jump;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void Yem()
    {
        audioSource.PlayOneShot(Yemek);
    }
    public void Jumping()
    {
        audioSource.PlayOneShot(Jump);
    }
}
