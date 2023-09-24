using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    [SerializeField]
    private int forcepower;
    [SerializeField]
    private float increment;
    [SerializeField]
    private float xinput;
    [SerializeField]
    private int point;
    public int Point { get { return point; } set {  point = value; } }
    [SerializeField]
    private int hp;
    public int HP { get { return hp; } set {  hp = value; } }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveLeftOrRight();
    }
   
    private void MoveLeftOrRight() 
    {
        xinput = Input.GetAxis("Horizontal");
        rb.AddForce(xinput * Vector3.right * forcepower);
    }
}
