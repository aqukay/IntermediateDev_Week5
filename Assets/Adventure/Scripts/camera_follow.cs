using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follow : MonoBehaviour
{
    public Transform target;
    public float speed_smooth = 7f;
    public Vector3 offset;

    public Vector3 min_value, max_value;

      // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //clamp camera


        Vector3 desired_position = target.position + offset;
        //find bounds
        Vector3 camera_bounds = new Vector3(
            Mathf.Clamp(desired_position.x, min_value.x, max_value.x),
            Mathf.Clamp(desired_position.y, min_value.y, max_value.y),
            Mathf.Clamp(desired_position.z, min_value.z, max_value.z));

        Vector3 smoothed_position = Vector3.Lerp(transform.position, camera_bounds, speed_smooth * Time.deltaTime);

        transform.position = smoothed_position;   
    }
}