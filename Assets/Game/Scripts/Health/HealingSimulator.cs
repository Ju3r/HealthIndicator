using UnityEngine;

public class HealingSimulator : HealthActionSimulator
{
    [SerializeField] private float _healingValue = 25;

    public override void Affect()
    {
        Health.Add(_healingValue);
    }
}