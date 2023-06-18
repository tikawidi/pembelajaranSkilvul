// See https://aka.ms/new-console-template for more information
// var angka= " ";
// Console.WriteLine(angka.GetType());

// Console.WriteLine("Hello, World!");
// string input =  Console.ReadLine() ?? "";
// // Console.WriteLine(input.GetType());
// Console.WriteLine("user input"+input);

// var x1 = 3;
// var x2 = 2;
// var x3 = 5;
// var x4 = 4;
// var y = x1;

// y--;
// Console.WriteLine(y);
// Console.WriteLine(x1.GetType());
// Console.WriteLine(x2.GetType());
// Console.WriteLine(x3.GetType());
// Console.WriteLine(x4.GetType());
// Console.WriteLine(y.GetType());

// var isEnemyHealth = 100;
// if (isEnemyHealth >= 50)
// {
//     Console.WriteLine("Enemy Attack");
// }
// else if (isEnemyHealth > 0 && isEnemyHealth < 50)
// {
//     Console.WriteLine("Enemy Restore Heath");
// }
// else
// {
//     Console.WriteLine("Enemy Die Animation");
// }
//  var rand = new Random();
//  Console.WriteLine(rand.Next(19)+1);
//     float playerHP = 1000;
//     float playerATK = 10 ;

//     List<string> enemies = new List<string>(){
//         "goblin",
//         "slime",
//         "wolf"
//         };
//     List<float> enemiesHP = new List<float>(){
//         100,
//         30,
//         50,
//     };
//     List<float> enemiesATK = new List<float>(){
//         50,
//         10,
//         40,
//     };

// int turn = 1;
// Random rand = new Random();
// Console.Clear();
// while (enemies.Count > 0 && playerHP > 0)
// {
//     // tampilin semua status

//     Console.WriteLine("Turn " + turn);
//     Console.WriteLine("PlayerHP: " + playerHP);
//     for ( int i = 0; i < enemies.Count; i++)
//     {
//         Console.WriteLine(i + ". " + enemies[i] + " HP: " + enemies[i]);
//     }
//     // player turn
//     Console.WriteLine("Please Choose target enemy");
//     string input = Console.ReadLine() ?? "";
//     int target= int.Parse(input);
//     Console.WriteLine("Player Attack " + target + ". "+ enemies[target]);

//     float oldTargetHp = enemiesHP[target];
//     float newTargetHp = enemiesHP[target] - playerATK;
//     Console.WriteLine(target + ". "+ enemies[target] + " HP: "+ oldTargetHp + " => " + newTargetHp);

//     enemiesHP[target] = newTargetHp;
//     if (enemiesHP[target]<=0)
//     {
//         Console.WriteLine(target + ". "+ enemies[target] + "die");
//         enemies.RemoveAt(target);
//         enemiesHP.RemoveAt(target);
//         enemiesATK.RemoveAt(target);
//     }
//     // enemy turn
//     int activeEnemy = rand.Next(enemies.Count);
//     Console.WriteLine(activeEnemy + ". " + enemies[activeEnemy] + " attack player");
//     float oldPlayerHp = playerHP;
//     float newPlayerHp = playerHP - enemiesATK[activeEnemy];
//     Console.WriteLine("player hp:  " + oldPlayerHp + " => " + newPlayerHp);

//     turn++;
// }

// using System;

// class ProgramInput
// {
//     static void Main(String[] args)
//     {
//         Console.WriteLine("=== PERCOBAAN SINTAKS INPUT ===");
//         Console.Write("Silahkan masukan nama anda: ");
//         string nama = Console.ReadLine();
//         Console.WriteLine("Hi, " + nama + " selamat datang!");
//     }
// }

// float nilai = 1.5f;

// Console.WriteLine($"Sin value of {nilai} : " + Math.Sin(nilai));
// Console.WriteLine($"Cos value of {nilai} : " + Math.Cos(nilai));
// Console.WriteLine($"Tan value of {nilai} : " + Math.Tan(nilai));

// int angka = 25;

// if((angka % 2) == 0){
//    Console.WriteLine("Faktor terkecil dari " + angka + " adalah 2.");
// }
// else if((angka % 3) == 0){
//    Console.WriteLine("Faktor terkecil dari " + angka + " adalah 3.");
// }
// else if((angka % 5) == 0){
//    Console.WriteLine("Faktor terkecil dari " + angka + " adalah 5.");
// }
// else if((angka % 7) == 0){
//    Console.WriteLine("Faktor terkecil dari " + angka + " adalah 7.");
// }
// else {
//    Console.WriteLine(angka + " tidak bisa dibagi 2, 3, 5, atau 7.");
// }
// string role = Console.ReadLine();

// switch (role) {
//    case "Knight": Console.WriteLine("Serangan Langsung"); break;
//    case "Archer": Console.WriteLine("Serangan Ranged Attack"); break;
//    case "Mage": Console.WriteLine("Serangan AOE"); break;  
//    default: Console.WriteLine("Serangan Tidak Diketahui"); break;
// }

// class GameDevice {
//     public virtual void Deskripsi() {
//         Console.Write("Ini adalah Base Class Game");
//     }
// }

// class Playstation5 : GameDevice{
//     public override void Deskripsi() {
//         Console.WriteLine("Bermain Playstation 5");
//     }
// }
// class NintendoSwitch : GameDevice{
//     public override void Deskripsi() {
//         Console.WriteLine("Bermain Nintendo Switch");
//     }
// }

// class Program {
// }
// using System;
// namespace SkilvulLearning {
//     class MenggunakanParameterMethod
//     {
//       static void Main(string[] args)
// {
//     int angka = 6;
//     int hasilAngka = hitungKurangTiga(
//         hitungKaliDua(
//             hitungTambahLima(angka)
//             )
//         );

//     Console.WriteLine("Hasil akhir angka : " + hasilAngka);
// }

// static int hitungTambahLima(int angka){
//     return angka + 5;
// }

// static int hitungKaliDua(int angka){
//     return angka * 2;
// }
// static int hitungKurangTiga(int angka){
//     return angka - 3;
// }
//     }
// }
// bool loopStatus = true;

while (loopStatus)
{
    if (increment > 10)
    {
        increment -= 1;
        loopStatus = false;
        Console.WriteLine(increment);
    }
    else
    {
        increment += 4;
        Console.WriteLine(increment);
    }
}