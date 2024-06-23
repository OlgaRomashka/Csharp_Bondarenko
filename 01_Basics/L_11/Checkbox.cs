using System;

namespace L_11
{
    public class Checkbox
    {
        public event Action Click;
    
        public void DoClick()
        {
            State = !State;

            Click?.Invoke();
        }

        public bool State { get; set; }
    }
}
