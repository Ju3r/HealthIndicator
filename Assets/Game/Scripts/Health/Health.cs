using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    private float _minValue = 0;

    public event Action Changed;

    [field: SerializeField] public float Value { get; private set; } = 100;
    [field: SerializeField] public float MaxValue { get; private set; } = 100;

    private void Awake()
    {
        Value = MaxValue;
    }

    public void Add(float value)
    {
        if (value <= 0)
            return;

        Value = Mathf.Clamp(Value + value, _minValue, MaxValue);
        Changed?.Invoke();
    }

    public void TakeDamage(float damage)
    {
        if (damage <= 0)
            return;

        Value = Mathf.Clamp(Value - damage, _minValue, MaxValue);
        Changed?.Invoke();
    }
}