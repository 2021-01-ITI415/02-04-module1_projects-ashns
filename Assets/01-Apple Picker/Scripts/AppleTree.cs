using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject applePrefab;
    public float speed = 1f;
    public float leftAndRightEdge = 10f;
    public float chanceToChangeDirection;
    public float secondBetweenAppleDrop=2f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropApple", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < -leftAndRightEdge){
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftAndRightEdge){
            speed = -Mathf.Abs(speed);
        }
    }
    void FixedUpdate(){
        if (Random.value < chanceToChangeDirection)
        {
            speed *= -1;
        }
    }

    void DropApple(){
        GameObject apple = Instantiate(applePrefab) as GameObject;
        apple.transform.position = transform.position;
        Invoke("DropApple", secondBetweenAppleDrop);
    }
}
