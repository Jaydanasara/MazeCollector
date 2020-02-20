using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


      public float speed;


        private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();  
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ("Gems"))
        {
        //    GetComponent<AudioSource>().Play();
            other.gameObject.SetActive (false);
            
            // count = count + 1;
            // SetCountText();

        }
    }



    // Update is called once per frame
        void Update()
    {
  
         
    }

        void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Mouse X");
        float moveVertical = Input.GetAxis ("Mouse Y");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * speed);
    }
}
