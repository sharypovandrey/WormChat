using UnityEngine;
using System.Collections;
using Debug=UnityEngine.Debug;

public class player : MonoBehaviour 
{
    public float speed = 10f;
    private Vector3 targetPosition;
    private bool isMoving;
    public GameObject clickAnimation;
 // Use this for initialization
 void Start () 
    {
        Debug.Log("start");
 
 }
 
 // Update is called once per frame
 void Update ()
    {
        Debug.Log("update");

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("click");
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPosition.z = transform.position.z;
            if (isMoving == false)
            {
                isMoving = true;
                Instantiate(clickAnimation, targetPosition, Quaternion.identity);
            }
        }
        if (isMoving == true)
        {

            transform.position = Vector3.MoveTowards(transform.position,targetPosition,speed*Time.deltaTime);
        }
        if (targetPosition == transform.position)
        {
            isMoving = false;
            Destroy(GameObject.Find("Click Animation(Clone)"));
        }
 }
}