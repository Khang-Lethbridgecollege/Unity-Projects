
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public Transform SpawnPoint;
    public GameObject Prefab;
    void OnTriggerEnter()
    {
    
Instantiate(Prefab, SpawnPoint.position, SpawnPoint.rotation);
        Destroy(gameObject);
    }
}
