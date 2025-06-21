using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class HealButton : InputButton
{
    private int _health = 25;
    protected override void ChangeHealth()
    {
        Value.RestoreHealth(_health);
    }
}