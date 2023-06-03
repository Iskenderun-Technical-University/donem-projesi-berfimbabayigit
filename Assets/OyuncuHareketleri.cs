using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class OyuncuHareketleri : MonoBehaviour
{
    SoundManager soundManagerScript;
    
    Rigidbody rb;
    public float sagsol;
    public float ilerigeri;
    float x,z;

    public float speed;
    //public float ziplama;
   // public float ziplama = 10f, jumpFrequncy=1f, nextjump ;
    public Transform yol1,yol2;
    int puan = 0;
    public TextMeshProUGUI puanGoster;
     public bool isGrounded = false;
    public Transform GroundPosition;
    public float GroundRadius;
    public LayerMask GroundLayer;
    Vector3 move = Vector3.zero;
    public float JumpSpeed;
    public float minJump;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
       
        soundManagerScript = GameObject.Find("Sound Manager").GetComponent<SoundManager>();
    }
   


    void FixedUpdate()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        move = new Vector3(x, 0, z)*Time.deltaTime*speed;
        rb.MovePosition(transform.position + transform.TransformDirection(move));
       
    
       /* onGroundCheck();
        if (Input.GetKey(KeyCode.S))
            rb.AddForce(0f, 0f, -ilerigeri);
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(0f, 0f, ilerigeri);
        if (Input.GetKey(KeyCode.D))
            rb.AddForce(sagsol, 0f, 0f);
        if (Input.GetKey(KeyCode.A))
            rb.AddForce(-sagsol, 0f, 0f);
        /*Xmovement = Input.GetAxis("Horizontal") * speed;
        Zmovement = Input.GetAxis("Vertical") * speed;
        rb.AddForce(Xmovement, 0, Zmovement);*/

       /* if (Input.GetKeyDown(KeyCode.Space) && isGrounded && (nextjump< Time.timeSinceLevelLoad))
         {
             nextjump = Time.timeSinceLevelLoad + jumpFrequncy;
             jump();
         }
        /* if (Input.GetKeyDown(KeyCode.Space))
         {
             rb.AddForce(Vector3.up * ziplama);
         }*/ 
        
        
    }
    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Engel")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }*/
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = Vector3.up * Time.deltaTime * JumpSpeed;
            soundManagerScript.Jumping();
        }
        if(x !=0 || z != 0)
        {
            rb.AddForce(Vector3.up * Time.deltaTime * minJump, ForceMode.VelocityChange);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "altýn")
        {
            //Debug.Log("çalýþtý");
            puan++;
            Destroy(other.gameObject);
            puanGoster.text = "puanin=" + puan;
            soundManagerScript.Yem();
        }
        if (other.gameObject.tag == "yol1")
        {
            yol2.position = new Vector3(yol1.position.x, yol1.position.y, yol1.position.z + 40.0f);
        }
        if (other.gameObject.tag == "yol2")
        {
            yol1.position = new Vector3(yol2.position.x, yol2.position.y, yol2.position.z + 40.0f);
        }
        

    }
   /* void jump()
    {
        rb.AddForce(new Vector3(0f,ziplama));
    }*/
     
    void onGroundCheck()
    {
        isGrounded = Physics2D.OverlapCircle(GroundPosition.position,GroundRadius,GroundLayer);
    }
    private void OnCollisionEnter(Collision collision)
    {
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
}
//(Input.GetAxis("Vertical") > 0)