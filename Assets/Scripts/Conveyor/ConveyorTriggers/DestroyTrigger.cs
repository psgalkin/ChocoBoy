using UnityEngine;

public class DestroyTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        other.gameObject.GetComponent<ConveyorSegment>().OnDestroy();
    }
}
