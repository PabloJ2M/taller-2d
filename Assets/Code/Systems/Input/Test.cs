using UnityEngine;
using UnityEngine.InputSystem;

public class Test : MonoBehaviour
{
    public void OnAtack(InputValue value)
    {
        Debug.Log(value.isPressed);
    }
    public void OnMovement(InputValue value)
    {
        print(value.Get<Vector2>());
    }
}
