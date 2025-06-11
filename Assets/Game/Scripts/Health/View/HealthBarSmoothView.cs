using System.Collections;
using UnityEngine;

public class HealthBarSmoothView : HealthBarView
{
    [SerializeField] private float _transitionSpeed = 2f;
    [SerializeField] private float _minInaccuracy = 0.01f;

    private float _targetValue;
    private Coroutine _smoothTransitionCoroutine;

    public override void UpdateUI()
    {
        _targetValue = Health.Value;

        if (_smoothTransitionCoroutine != null)
        {
            StopCoroutine(_smoothTransitionCoroutine);
        }

        _smoothTransitionCoroutine = StartCoroutine(SmoothTransition());
    }

    protected override void Init()
    {
        base.Init();
        _targetValue = Health.Value;
    }

    private IEnumerator SmoothTransition()
    {
        while (Mathf.Abs(_slider.value - _targetValue) > _minInaccuracy)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _targetValue, _transitionSpeed * Time.deltaTime);
                
            yield return null;
        }

        _slider.value = _targetValue;
        _smoothTransitionCoroutine = null;
    }
}
