using UnityEngine;

namespace StinkySteak.Timer
{
    public struct FlexTimer
    {
        public static FlexTimer None => default;

        private float _targetTime;

        public float TargetTime => _targetTime;

        public static FlexTimer CreateFromSeconds(float duration)
        {
            return new FlexTimer()
            {
                _targetTime = duration + Time.time
            };
        }

        public bool IsRunning => _targetTime > 0;

        public bool IsExpired()
            => Time.time >= _targetTime && IsRunning;

        public bool IsExpiredOrNotRunning()
            => Time.time >= _targetTime;

        public float RemainingSeconds
            => Mathf.Max(_targetTime - Time.time, 0);
    }
}
