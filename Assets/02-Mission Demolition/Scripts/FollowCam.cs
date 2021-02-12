using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{

    static public FollowCam S;
    public bool __;
    public GameObject poi;
    public float camZ; 

    void Awake()
    {
        S = this;
        camZ = this.transform.position.z;
    }

    void Update()
    {
        if (poi == null)
        {
            return;
        }
        Vector3 destination = poi.transform.position;
        destination.z = camZ;
        transform.position = destination;
        }
}
