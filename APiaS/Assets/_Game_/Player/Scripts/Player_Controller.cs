using UnityEngine;

[SelectionBase]
public class Player_Controller : MonoBehaviour
{
    #region Internal Data
    private Vector2 _moveDir = Vector2.zero;
    #endregion

    #region Tick
    private void Update()
    {
        GatherInput();
    }
    #endregion


    #region InputLogic
    private void GatherInput()
    {
        _moveDir.x = Input.GetAxisRaw("Horizontal");
        _moveDir.y = Input.GetAxisRaw("Vertical");

        print(_moveDir);
    }
    #endregion
}
