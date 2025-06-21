using UnityEngine;
using System;
public class Health : MonoBehaviour
{
    [SerializeField] private int _value;

    private int _minValue = 0;
    private int _maxValue = 100;

    public int Value { get; private set; }
    public int MaxValue => _maxValue;

    public event Action<int> ChangedHealth;

    private void Awake()
    {
        Value = _value;
    }

    public void TakeDamage(int damage)
    {
        if (damage > 0)
        {
            ChangeHealth(-damage);
        }
    }

    public void RestoreHealth(int health)
    {
        if (health > 0)
        {
            ChangeHealth(health);
        }
    }

    private void ChangeHealth(int health)
    {
        Value = Mathf.Clamp(health + Value, _minValue, _maxValue);

        ChangedHealth?.Invoke(Value);
    }
}