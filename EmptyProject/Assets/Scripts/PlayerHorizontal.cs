using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHorizontal : MonoBehaviour
{
    [SerializeField] private float speed;
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0);
    }
}
