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
            GameObject dec = Instantiate(_decalObject);
            dec.transform.position = transform.position;
            Destroy(this.gameObject);
        }
    }
}
