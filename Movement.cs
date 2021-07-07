using System.Collections;
using System.Collections.Generic; 
using UnityEngine; //name space 

public class Movement : MonoBehaviour //called inheritence 
{ //always has one class per script 
    // Start is called before the first frame update
   Rigidbody rb; //must not write the rigidbody as same as the Rigidbody component 
    [SerializeField]float xValue = 8f;
    [SerializeField] float rotationThrust = 50f;
[SerializeField]float yValue = 15f * Time.deltaTime;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); //must use it as a beginning
        //for return back to the ground  
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }




    void ProcessThrust(){

if(Input.GetKey(KeyCode.Space)){
    Debug.Log("Pressed Space - Thrusting");
    //transform.Translate(0,yValue,0); //nah not use that
    rb.AddRelativeForce(0,yValue,0);          //Adds a Force to the Rigid Body relative to it's coordinatte System
        //and have a defination of vector3 what is vector 3 
        //vector 3 is method work on print magnitude of x , y, z axis 
        //and we use it in indicate the force direction 
 }



    
    }
    void ProcessRotation(){
if(Input.GetKey(KeyCode.D))
        {
            //Debug.Log("Rotating Right");
            ClockWise();//ctrl + (.)
            //transform.Rotate(Vector3.forward * Time.deltaTime);
 //transform.Rotate(xValue * rotationThrust * Time.deltaTime, 0, 0);
      //Rotation(rotationThrust);//as 2 in 1 method
        }
        else if(Input.GetKey(KeyCode.A))
        {
            //Debug.Log("Rotating Left");
            AntiClockWise();
            //transform.Rotate(-Vector3.forward * Time.deltaTime);
        //Rotation(-rotationThrust); as 2 in 1 method 
        }
    }

    private void AntiClockWise()
    {
                rb.freezeRotation = true; //freezing rotation so we can  manually rotate
        transform.Rotate(-xValue * rotationThrust * Time.deltaTime, 0, 0);
            rb.freezeRotation = false; //unfreezing rotation so the physics system can take over
    }

    private void ClockWise()
    {
        rb.freezeRotation = true; //freezing rotation so we can  manually rotate
        transform.Rotate(xValue * rotationThrust * Time.deltaTime, 0, 0);
        rb.freezeRotation = false; //unfreezing rotation so the physics system can take over
    }

//private void Rotation(float rotationThrust){
  //      transform.Rotate(-xValue * rotationThrust * Time.deltaTime, 0, 0);
//}

}
