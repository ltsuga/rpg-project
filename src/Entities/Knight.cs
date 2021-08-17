namespace rpg_project.src.Entities

{
    public class Knight : Character
    {
        public Knight(string name, int level, string heroType) : base (name, level,heroType){ }
        public override string Attack(string enemie){
            this.xp++;
            return(this.name +" attacked "+enemie+ " with sword.");
       }

        public override string Attack(string enemie, int bonus){
            this.xp = this.xp+2;
            if (bonus<=50){
                return(this.name +" attacked "+enemie+ " with sword. Bonus: "+bonus);
            }else{
                return(this.name +" attacked "+enemie+ " with sword. Extra Bonus: "+bonus);
            }
            
       }



    }
}