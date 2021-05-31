using System.Collections.Generic;

namespace BeynesTestTrainer.Model
{
    public class BeynesTestModel
    {
        public List<DefinedColor> ColorList { get; set; }
        
        public int ShowTime { get; set; }
        public int OffTime { get; set; }

        public BeynesTestModel()
        {
            ColorList = new();
        }
    }
}