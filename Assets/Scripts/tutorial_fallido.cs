using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public Transform[] WheelMeshs;

    public WheelCollider[] Wheelcolliders;

    Vector3 pos, rotation; //revisar
    Quaternion quatern;

    public float Force, RotSpeed;

    void Start()
    {
        rotation = transform.eulerAngles;
    }

    void Update()
    {
        transform.eulerAngles = rotation;

        for(int i=0; i<Wheelcolliders.Length; i++)
        {
            Wheelcolliders[i].GetWorldPose(out pos, out quatern);
            WheelMeshs[i].position = pos;
            WheelMeshs[i].rotation = quatern;
        }

        foreach(var wheelcol in Wheelcolliders)
        {
            wheelcol.motorTorque = Input.GetAxis("Vertical") * Force * Time.deltaTime;
        }

        rotation.y += Input.GetAxis("Horizontal") * RotSpeed;
    }
}
