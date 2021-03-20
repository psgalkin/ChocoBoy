using UnityEngine;
class GoDownTrigger : MonoBehaviour
{
    [SerializeField] private float _goDownAngle;

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<ConveyorSegment>().GoDown(_goDownAngle);
    }
}
