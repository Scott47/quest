using System;

namespace Quest
{
    public class Hat
    {
        public int ShininessLevel { get; set; }
        public string GetShininessLevel()
        {

            if (ShininessLevel < 2)
            {
                return $"{ShininessLevel}: dull";
            }
            if (ShininessLevel >= 2 & ShininessLevel <= 5)
            {
                return $"{ShininessLevel}: noticeable";
            }
            if (ShininessLevel >= 6 & ShininessLevel <= 9)
            {
                return $"{ShininessLevel}: bright";
            }
            if (ShininessLevel > 9)
            {
                return $"{ShininessLevel}: blinding";
            }
            return "No shine";
        }
    }
}