namespace rpg_project.src.Entities
{
    public class Character
    {
        protected string name { get; set; }
        protected int level { get; set; }
        protected int health { get; set; }
        protected int xp { get; set; }
        protected string heroType { get; set; }
        public Character(string name, int level, string heroType){
          this.name = name;
          this.level = level;
          this.heroType = heroType;
          this.health = 100;
          this.xp = 1;
        }

        public Character(){ }

         public virtual string Attack(string enemie){
             this.xp++;
            return(this.name +" attcked "+enemie+ ".");
         }

         public virtual string Attack(string enemie, int bonus){
            this.xp++;
            return(this.name +" attcked "+enemie+ ". Bonus: "+bonus);
         }

         public string gotDamage(int damage){
            this.health = this.health - damage;
            if (this.health <= 0){
                return (this.name+"is dead");
            }else{
                return (this.name+" hit! Current heath: "+this.health);
            }
         }

        public override string ToString()
        {
        return ("Name: " + this.name + " | Level: " + this.level+ " | XP: " + this.xp+" | Heroe Type: "+this.heroType);
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getLevel()
        {
            return this.level;
        }

        public void setLevel(int level)
        {
            this.level = level;
        }
        public int getHealth()
        {
            return this.health;
        }

        public void setHealth(int health)
        {
            this.health = health;
        }

        public int getXp()
        {
            return this.xp;
        }

        public void setXp(int xp)
        {
            this.xp = xp;
        }
       public string getHeroType()
        {
            return this.heroType;
        }

        public void setHeroType(string heroType)
        {
            this.heroType = heroType;
        }
    }
}