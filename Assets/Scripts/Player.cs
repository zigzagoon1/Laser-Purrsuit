using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private PlayerInput playerInput;
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        playerInput.actions["Click"].performed += OnClick;
    }

    public void OnClick(InputAction.CallbackContext context)
    {
        Debug.Log("Click action performed");
    }

    private void OnDisable()
    {
        playerInput.actions["Click"].performed -= OnClick;
    }
}
