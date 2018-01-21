namespace MordorsCrueltyPlan.Models
{
    public abstract class Mood
    {
        public Mood(string moodName)
        {
            this.MoodName = moodName;
        }

        private string MoodName { get; set; }

        public override string ToString()
        {
            return this.MoodName;
        }
    }
}
