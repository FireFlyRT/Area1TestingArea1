using UnityEngine;

public class DropWithSplash : MonoBehaviour
{
    [SerializeField]
    private GameObject decal;
    [SerializeField]
    private GameObject obj;

    private void OnTriggerEnter(Collider other)
    {
        if (obj.GetComponent<Collider>() != other) 
        {
            GameObject dec = Instantiate(decal);
            dec.transform.position = transform.position;
            Destroy(this.gameObject);
        }
    }
}
