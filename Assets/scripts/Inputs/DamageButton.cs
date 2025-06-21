using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class DamageButton : InputButton
{
    private int _damage = 25;

    protected override void ChangeHealth()
    {
        Value.TakeDamage(_damage);
    }
}
