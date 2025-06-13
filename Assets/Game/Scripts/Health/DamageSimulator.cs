using UnityEngine;

public class DamageSimulator : HealthActionSimulator
{
    [SerializeField] private float _damageValue = 25;

    public override void Affect()
    {
        Health.TakeDamage(_damageValue);
    }
}