using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class HealButton : MonoBehaviour
{
    [SerializeField] private PlayerHealth _playerHealth;

    private Button _button;

    private int _health = 25;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(Heal);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(Heal);
    }

    private void Heal()
    {
        _playerHealth.RestoreHealth(_health);
    }
}
