namespace rpg_project.src.Entities
{
    public class Devil : Character
    {
        public Devil(string name, int level, string heroType) : base (name, level,heroType){ }
        public override string Attack(string enemie){
            this.xp++;
            return(this.name +" attacked "+enemie+ " with Fire Breath.");
       }

    }
}