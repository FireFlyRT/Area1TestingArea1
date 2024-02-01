using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireExtingisher : MonoBehaviour
{
    public bool Fire;
    public GameObject prefab;
    public Transform FirePoint;

    void FixedUpdate()
    {
        if (Fire)
        {
            GameObject obj = Instantiate(prefab);
            obj.transform.position = FirePoint.position;
            obj.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
            //obj.GetComponent<Rigidbody>().useGravity = false;
            obj.GetComponent<Rigidbody>().AddForce(transform.forward.normalized * 10, ForceMode.Impulse);
        }
    }

    public void SetFire(bool fire)
    {
        Fire = fire;
    }
}
