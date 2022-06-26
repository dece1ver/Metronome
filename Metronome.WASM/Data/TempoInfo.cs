namespace Metronome.WASM.Data
{
    public class TempoInfo
    {
        public int Tempo { get; set; }
        public string Name { get; set; }

        public TempoInfo(int tempo, string name)
        {
            Tempo = tempo;
            Name = name;
        }
    }
}
