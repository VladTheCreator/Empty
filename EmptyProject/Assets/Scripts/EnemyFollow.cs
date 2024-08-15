using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class EnemyFollow : MonoBehaviour
{ 
[SerializeField] private float speed;
[SerializeField] private float rotation;
void Update()
{

    transform.position += new Vector3(speed * rotation * Time.deltaTime, 0, 0);
}
}