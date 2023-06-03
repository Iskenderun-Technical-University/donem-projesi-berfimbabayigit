using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CARPMA : MonoBehaviour
{
    AudioSource audioSource;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Engel")
        {
            Invoke("restart", 1f);
            audioSource.Play();
        }
        Debug.Log("çarptý");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("çarpýþma bitti");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("çarpýyor");
    }
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
