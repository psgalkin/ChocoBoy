using UnityEngine;

public class DestroyTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ConveyorSegment"))
            other.gameObject.GetComponent<ConveyorSegment>().OnDestroy();
    }
}
