using UnityEngine;
using UnityEngine.UI;

public class HealthActionSimulator : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Button _healingButton;
    [SerializeField] private Button _damageButton;
    [SerializeField] private float _healingValue = 25;
    [SerializeField] private float _damageValue = 25;

    private void OnEnable()
    {
        _healingButton.onClick.AddListener(Healing);
        _damageButton.onClick.AddListener(TakeDamage);
    }

    private void OnDisable()
    {
        _healingButton.onClick.RemoveListener(Healing);
        _damageButton.onClick.RemoveListener(TakeDamage);
    }

    public void Healing()
    {
        _health.Add(_healingValue);
    }

    public void TakeDamage()
    {
        _health.TakeDamage(_damageValue);
    }
}