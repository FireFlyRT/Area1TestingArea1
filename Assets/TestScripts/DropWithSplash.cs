using UnityEngine;

public class DropWithSplash : MonoBehaviour
{
    [SerializeField]
    private GameObject decal;

    private void OnTriggerEnter(Collider other)
    {
        GameObject dec = Instantiate(decal);
        dec.transform.position = transform.position;
        Destroy(this.gameObject);
    }
}
