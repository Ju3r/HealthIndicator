using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public event Action HasChanged;

    [field: SerializeField] public float Value { get; private set; } = 100;
    [field: SerializeField] public float MaxValue { get; private set; } = 100;

    private void Awake()
    {
        Value = MaxValue;
    }

    public void Add(float value)
    {
        Value = Mathf.Min(MaxValue, Value + value);
        HasChanged?.Invoke();
    }

    public void TakeDamage(float damage)
    {
        Value = Mathf.Max(0, Value - damage);
        HasChanged?.Invoke();
    }
}