using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.Search;
using UnityEngine;
using Random = UnityEngine.Random;

public class Wave_Movement : MonoBehaviour
{
    [SerializeField] public float speed = 2;
    [SerializeField] public float distance = 1;
    public Vector3 startPos;
    private float offset;

    void Start()
    {
        startPos = transform.position;
        offset = Random.Range(-Mathf.PI, Mathf.PI);
    }
    void Update()
    {
        Vector3 newPos = new Vector3(startPos.x + Mathf.Sin(Time.time * speed + offset) * distance, startPos.y, startPos.z);
        transform.position = newPos; //Vector3.Slerp(transform.position,newPos,speed*Time.deltaTime);

    }
}
