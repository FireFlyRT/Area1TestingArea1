using UnityEngine;

public class DropWithSplash : MonoBehaviour
{
    [SerializeField]
    private GameObject _decalObject;
    [SerializeField]
    private GameObject _fromFiredObject;

    private void OnTriggerEnter(Collider other)
    {
        if (_fromFiredObject.GetComponent<Collider>() != other) 
        {
            RaycastHit hit;
            if (Physics.SphereCast(transform.position, 0.3f, transform.forward, out hit, 0.1f))
            {
                GameObject dec = Instantiate(_decalObject);
                dec.transform.position = transform.position;
                Vector3 rotation = Vector3.zero;
                if (hit.normal.x < 0.45f)
                    rotation += new Vector3(-90, 0, 0);
                else if (hit.normal.x > 0.45f && hit.normal.x < 0.9f)
                    rotation += new Vector3(90, 0, 0);
                //else if (hit.normal.x > 0.9f)
                //    rotation += new Vector3(180, 0, 0);
                dec.transform.eulerAngles = rotation;
            }

            Destroy(this.gameObject);
        }
    }
}
