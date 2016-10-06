using UnityEngine;
using System.Collections;

public class ShotControl : MonoBehaviour
{

    public int force = 1000;

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, force));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
