using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class HealButton : Input_Button
{
    protected override void ChangeHealth()
    {
        Value.RestoreHealth(Health);
    }
}