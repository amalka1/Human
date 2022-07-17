namespace OOP{

    class Human{
        public string Name ;
        public int Strength;
        public int Intelligence ;
        public int Dexterity ;
        public int Health;
        public Human(string name)
        {
            this.Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
            
        }
        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            this.Name = name;
            this.Strength = strength;
            this.Intelligence = intelligence;
            this.Dexterity = dexterity;
            this.Health = health;
            
        }
        public int Attack(Human target){
            int damage = Strength * 5;
            target.Health -= damage;
            return target.Health;
        }

    }
}