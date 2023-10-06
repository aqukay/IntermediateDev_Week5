using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class depth_sorting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Camera.main.transparencySortMode = TransparencySortMode.CustomAxis;
        Camera.main.transparencySortAxis = Vector3.up;
    }

    // Update is called once per frame
    void Update()
    {

    }
}