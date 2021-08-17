namespace rpg_project.src.Entities
{
    public class Wizard : Character
    {
        public Wizard(string name, int level,string heroType) : base (name, level,heroType){ }
        public override string Attack(string enemie){
            return(this.name +" attacked "+enemie+ " with spell.");
       }
  
    }
}