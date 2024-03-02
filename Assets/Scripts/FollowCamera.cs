using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField] GameObject FollowObject;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = FollowObject.transform.position + new Vector3 (0, 0, -10);
    }
}
