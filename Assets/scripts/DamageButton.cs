using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class DamageButton : MonoBehaviour
{
    [SerializeField] private PlayerHealth _playerHealth;

    private Button _button;

    private int _damage = 25;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(DealDamage);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(DealDamage);
    }

    private void DealDamage()
    {
        _playerHealth.TakeDamage(_damage);
    }
}
