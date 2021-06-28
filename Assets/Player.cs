using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Transform playerMove;
   
    [SerializeField]
    float playerSpeed;
    [SerializeField]
    AnimationCurve playerAnimCurve;
    private void Awake()
    {
        playerMove = GetComponent<Transform>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMove.position += playerSpeed * playerMove.forward * Time.deltaTime;
        float Y = playerAnimCurve.Evaluate(Mathf.PingPong(Time.time,2f));
        playerMove.position = new Vector3(playerMove.position.x,Y,playerMove.position.z);
    }
}
