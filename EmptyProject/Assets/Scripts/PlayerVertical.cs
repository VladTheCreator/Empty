using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVertical : MonoBehaviour
{

    void Update()
    {

        transform.position += new Vector3(0, Input.GetAxis("Vertical") * Time.deltaTime);
    }
 }
