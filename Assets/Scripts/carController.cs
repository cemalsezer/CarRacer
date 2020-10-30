using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class carController : MonoBehaviour
{
    public float maxMotorGucu;
    public float maxAci;
    public float motorGucu;
    public float donus;
    public int x;
    public float rotationSpeed = 2.0f;


    public WheelCollider onSolCol;
    public WheelCollider onSagCol;
    public WheelCollider arkaSolCol;
    public WheelCollider arkaSagCol;

    public GameObject onSol;
    public GameObject onSag;
    public GameObject arkaSol;
    public GameObject arkaSag;

    public Transform car;
    public Transform dorse;
    public GameObject dorsee;


    public Transform sag;
    public Transform sol;
    
    


    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "dorse")
        {
            ConfigurableJoint sc = gameObject.AddComponent(typeof(ConfigurableJoint)) as ConfigurableJoint;

            GetComponent<ConfigurableJoint>().connectedBody = other.GetComponent<Rigidbody>();

            var xox = sc.xDrive;
            xox.positionSpring = 100;
            sc.xDrive = xox;

            var coc = sc.yDrive;
            coc.positionSpring = 100;
            sc.yDrive = coc;

            var oxo = sc.zDrive;
            oxo.positionSpring = 100;
            sc.zDrive = oxo;

            var xxx = sc.breakForce;
            xxx = 100;
            sc.breakForce = xxx;

            var ccc = sc.breakTorque;
            ccc = 100;
            sc.breakTorque = ccc;

            Debug.Log("bağlandı");
        }
    }

    void Update()
    { 

        RaycastHit hit;
        
        int range = 10;
       
       if(Physics.Raycast(car.position, transform.forward+(transform.right), out hit, range ))
        {
            if(hit.collider.gameObject.tag=="engel")
            {                                
                Debug.Log("sağ ön engel var");
                sag.GetComponent<WheelCollider>().steerAngle= -35;
                sol.GetComponent<WheelCollider>().steerAngle= -35;
            }
             else
            {
                sag.GetComponent<WheelCollider>().steerAngle= 0;
                sol.GetComponent<WheelCollider>().steerAngle= 0;

            }
            
        }

           if(Physics.Raycast(car.position, transform.forward+(-transform.right), out hit, range ))
        {
            if(hit.collider.gameObject.tag=="engel")
            {
                Debug.Log("sol ön engel var");
                sag.GetComponent<WheelCollider>().steerAngle= 35;
                sol.GetComponent<WheelCollider>().steerAngle= 35;
               
            }
            else
            {
                sag.GetComponent<WheelCollider>().steerAngle= 0;
                sol.GetComponent<WheelCollider>().steerAngle= 0;

            }
        }
           if(Physics.Raycast(car.position, transform.forward, out hit, range ))
        {
            if(hit.collider.gameObject.tag=="engel")
            {
                Debug.Log("ön engel var");
                
;
            }
            
        }

            motorGucu = maxMotorGucu * 70 ;
            //donus = maxAci * Input.GetAxis("Horizontal");

        //onSolCol.steerAngle = onSagCol.steerAngle = donus;
        arkaSagCol.motorTorque = motorGucu;
        arkaSolCol.motorTorque = motorGucu;

        teker();
    }

    void teker()
    {
        Quaternion rot;
        Vector3 pos;
        onSolCol.GetWorldPose(out pos, out rot);
        onSol.transform.position = pos;
        onSol.transform.rotation = rot;

        onSagCol.GetWorldPose(out pos, out rot);
        onSag.transform.position = pos;
        onSag.transform.rotation = rot;

        arkaSolCol.GetWorldPose(out pos, out rot);
        arkaSol.transform.position = pos;
        arkaSol.transform.rotation = rot;

        arkaSagCol.GetWorldPose(out pos, out rot);
        arkaSag.transform.position = pos;
        arkaSag.transform.rotation = rot;
       

    }
}
