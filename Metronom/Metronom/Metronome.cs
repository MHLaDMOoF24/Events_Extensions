namespace Metronom
{
    internal class Metronome
    {
        public event EventHandler Tick;

        public void Activate()
        {
            OnTick();
        }

        protected virtual void OnTick() 
        {
            Tick?.Invoke(this, EventArgs.Empty);
        }
    }
}
