namespace OOP{
    class HumanTest{
        public static void Main(string[] args){
        var John = new Human("John");
        var Jack = new Human("Jiim");
        System.Console.WriteLine(John.Name);
        System.Console.WriteLine(John.Name + "'s health after " + Jack.Name+ " attacked is " + Jack.Attack(John));
        
    }
}
}