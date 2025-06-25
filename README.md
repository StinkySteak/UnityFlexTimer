# Simulation Timer
An Lightweight Efficient Timer for Unity. Inspired by Photon Fusion TickTimer
## Usage/Examples

#### Simulation Timer

![](https://github.com/StinkySteak/UnityFlexTimer/blob/docs/DefaultTimer.gif)

```cs
private FlexTimer _disableTimer;

private void Start()
{
    _disableTimer = FlexTimer.CreateFromSeconds(_delay);
}

private void Update()
{
    if (_disableTimer.IsExpired())
    {
        _gameObject.SetActive(false);
        _disableTimer = FlexTimer.None;
    }
}
```

#### Pauseable Simulation Timer

![](https://github.com/StinkySteak/UnityFlexTimer/blob/docs/PauseableTimer.gif)

```cs
private PauseableFlexTimer _timer;

public PauseableFlexTimer Timer => _timer;

private void Start()
{
    _timer = PauseableFlexTimer.CreateFromSeconds(_delay);
}

public void TogglePause()
{
    if (!_timer.IsPaused)
    {
        _timer.Pause();
        return;
    }

    _timer.Resume();
}

private void Update()
{
    if (_timer.IsExpired())
    {
        _gameObject.SetActive(false);
        _timer = PauseableFlexTimer.None;
    }
}
```
