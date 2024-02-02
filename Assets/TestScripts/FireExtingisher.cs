using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireExtingisher : MonoBehaviour
{
    [SerializeField]
    private bool _isFirering;
    [SerializeField]
    private GameObject _bulletPrefab;
    [SerializeField]
    private Transform _firePoint;

    void FixedUpdate()
    {
        if (_isFirering)
        {
            GameObject obj = Instantiate(_bulletPrefab);
            obj.transform.position = _firePoint.position;
            obj.transform.localScale = new Vector3(0.03f, 0.03f, 0.03f);
            obj.GetComponent<Rigidbody>().AddForce(transform.forward.normalized * 10, ForceMode.Impulse);
        }
    }

    public void SetFire(bool fire)
    {
        _isFirering = fire;
    }
}
