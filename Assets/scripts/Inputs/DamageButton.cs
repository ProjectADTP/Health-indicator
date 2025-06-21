using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class DamageButton : Input_Button
{
    protected override void ChangeHealth()
    {
        Value.TakeDamage(Health);
    }
}
