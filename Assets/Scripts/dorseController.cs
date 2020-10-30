using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dorseController : MonoBehaviour


{

    public GameObject car;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "car")
        //{
        //    ConfigurableJoint sc = gameObject.AddComponent(typeof(ConfigurableJoint)) as ConfigurableJoint;

        //    var xox = sc.xDrive;
        //    xox.positionSpring = 100;
        //    sc.xDrive = xox;

        //    GetComponent<ConfigurableJoint>().connectedBody = other.GetComponent<Rigidbody>();


        //    var coc = sc.yDrive;
        //    coc.positionSpring = 100;
        //    sc.yDrive = coc;

        //    var oxo = sc.zDrive;
        //    oxo.positionSpring = 100;
        //    sc.zDrive = oxo;

        //    var xxx = sc.breakForce;
        //    xxx = 100;
        //    sc.breakForce = xxx;

        //    var ccc = sc.breakTorque;
        //    ccc = 100;
        //    sc.breakTorque = ccc;

        //    Debug.Log("bağlandı");
        //}
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
