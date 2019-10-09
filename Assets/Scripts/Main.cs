using UnityEngine;
using System.Collections;
using Debug=UnityEngine.Debug;
using System;

public class Main : MonoBehaviour 
{
    public float speed = 10f;
    private Vector3 targetPosition;
    private bool isMoving;
    public GameObject ball;
    // Use this for initialization
    void Start () 
        {
            Debug.Log("start");
            ball = GameObject.Find("Quad");
        }
 
    // Update is called once per frame
    void Update ()
    {
        // Debug.Log("update");
        Debug.Log(targetPosition.x);
        Debug.Log(targetPosition.y);
        Debug.Log(targetPosition.z);
        Debug.Log("targetPosition");

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("click");
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPosition.z = transform.position.z;
            if (isMoving == false)
            {
                isMoving = true;
            }
        }
        if (isMoving == true)
        {
            transform.position = Vector3.MoveTowards(transform.position,targetPosition,speed*Time.deltaTime);
        }
        if (targetPosition == transform.position)
        {
            isMoving = false;
        }

    }
}