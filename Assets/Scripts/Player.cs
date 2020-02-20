using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{


    public float                speed;
    public Text                 ScoreBoard;
    public Text                 GameOver;

    private                     Rigidbody rb;
    private  int score;                   


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();  

    score= 0;
    SetScoreBoard();
    GameOver.text = "";
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ("Gems"))
        {
        //    GetComponent<AudioSource>().Play();
            other.gameObject.SetActive (false);
            
            score = score + 100;
            SetScoreBoard();

        }

        if (other.gameObject.CompareTag ("End"))
        {
        //    GetComponent<AudioSource>().Play();
            other.gameObject.SetActive (false);
            GameOver.text="Game Over";
            if(score<500){
                score = score + 500;
            SetScoreBoard();
            }else{
            score = score + 1000;
            SetScoreBoard();
            }
        
        }


    }
void SetScoreBoard(){

ScoreBoard.text ="Score:" + score.ToString();
    
    
    

}

    // Update is called once per frame


        void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Mouse X");
        float moveVertical = Input.GetAxis ("Mouse Y");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * speed);
    }
}
