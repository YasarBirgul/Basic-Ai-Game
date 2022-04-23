using UnityEngine;

public class Move : MonoBehaviour {

  
    
    public float speed = 1.0f;
    public float accuracy = 0.01f;
    public Transform goal;

    void Start()
    {
          
       
     
    }

    void LateUpdate()
    {
        this.transform.LookAt(goal.position);
        Vector3 direction = goal.position-this.transform.position;
        Debug.DrawLine(this.transform.position,direction,Color.blue);
        if(direction.magnitude > accuracy)
        { this.transform.Translate(direction.normalized*speed*Time.deltaTime,Space.World);}
    }
}
