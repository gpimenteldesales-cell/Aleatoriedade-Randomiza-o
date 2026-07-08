using UnityEngine;
using UnityEngine.InputSystem;

public class BoxDestroy : MonoBehaviour
{
    public InputAction mouseClick;
    private void OnEnable()
    {
        mouseClick.Enable();
    }
    private void OnDisable()
    {
        mouseClick.Disable();
    }
    private void Start()
    {
        
    }

    void Update()
    {
        
    }
}
