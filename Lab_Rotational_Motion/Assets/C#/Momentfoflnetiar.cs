using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Momentfoflnetiar : MonoBehaviour
{
    void FixedUpdate()
    {
        Debug.Log(this.name + "Inertia" + GetComponent<Rigidbody>().inertiaTensor);

        transform.localScale += new Vector3(Input.GetAxis("Horizontal"), 0, 0);

        GetComponent<Rigidbody>().AddTorque(10, 0, 0);

    }//FixedUpdate
}
    