using System;


public class SomeModel {
    public event Action Death;
    public event Action<float> ChangedHealth;

    private float _maxHp = 100;
    private float _currentHp;

    public SomeModel() {
        _currentHp = _maxHp;
    }

    public void SetNewHealth(float damage) {
        _currentHp -= damage;
        if (_currentHp > 0)
            ChangedHealth?.Invoke(_currentHp);
        else
            Death?.Invoke();
    }
}