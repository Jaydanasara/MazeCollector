using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    static private Ground    S;
                
    // Start is called before the first frame update
    [Header("Set in Inspector")]
    public GameObject           ballStart;
    public GameObject           prefabBall;
    public float                velocityMult = 8f;

 [Header("Set Dynamically")]
    public GameObject           startPoint;
    public Vector3              startPos;
    public GameObject           Ball;
    
    
private Rigidbody           BallRigidbody;

   static public Vector3 LAUNCH_POS{
        get{
            if (S == null) return Vector3.zero;
            return S.startPos;
        }
    }
  
 void Awake() {
      
        S = this;
        Transform startPointTrans = transform.Find("StartPoint");
        startPoint = startPointTrans.gameObject;
        startPoint.SetActive(true);
        startPos = startPointTrans.position;   
       
         }

 void OnMouseDown() {
   
        ballStart.SetActive(true);
        Ball=GameObject.Find("Ball");
        //  Ball = Instantiate(prefabBall) as GameObject;
        Ball.transform.position = startPos;
     
        BallRigidbody = Ball.GetComponent<Rigidbody>();
        // BallRigidbody.isKinematic =true;
        
            BallRigidbody.isKinematic = false;
         
            FollowCam.POI = Ball;
            Ball = null;
            
            DrawLine.S.poi = Ball;

    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    
    }
}
