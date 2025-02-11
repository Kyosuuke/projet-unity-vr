using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorLock : MonoBehaviour
{
    [SerializeField] private bool _isLock = true;
    [SerializeField] private GameObject _doorWedge;
    private XRGrabInteractable _doorStatut;

    public bool IsLock {get => _isLock;}

    void Start()
    {
        _doorStatut = GetComponent<XRGrabInteractable>();
        if (_isLock && _doorStatut != null)
        {
            _doorStatut.enabled = false;
        }
    }

    public void UnlockDoor()
    {
        _isLock = false;
        _doorStatut.enabled = true;
        _doorWedge.SetActive(false);
    }
}
