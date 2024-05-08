using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    public PlayerController playerController;

    private void Awake()
    {
        if (playerController == null)
            playerController = GetComponent<PlayerController>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        if (playerController != null)
            playerController.Move(context);
    }


    //public void OnToggleInventory(InputAction.CallbackContext context)
    //{
    //    if (context.performed && playerController != null)
    //        playerController.ToggleInventory();
    //}

    public void OnUseItem(InputAction.CallbackContext context)
    {
        if (context.performed && playerController != null)
            playerController.UseItem();
    }

    public void OnDeselectItem(InputAction.CallbackContext context)
    {
        if (context.performed && playerController != null)
            playerController.DeselectItemUI();
    }

    public void OnUseTranquilizer(InputAction.CallbackContext context)
    {
        if (context.performed && playerController != null)
            playerController.UseTranquilizerGun();
    }

    public void OnPlaceMine(InputAction.CallbackContext context)
    {
        if (context.performed && playerController != null)
            playerController.PlaceMine();
    }

    public void OnPause(InputAction.CallbackContext context)
    {
        if (context.performed && playerController != null)
            playerController.TogglePauseMenu();
    }
}