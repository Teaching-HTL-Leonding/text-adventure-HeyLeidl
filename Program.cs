// Izudin Muheljic
// 1 AHIF
// Aufgabe: Text Adventure 
// date: 02.03.2023
bool HavingKnife = false;
bool HavingFood = false;
bool HavingWeapon = false;
PrintWelcome();
StartingOfGame();
IntroScene();

void PrintWelcome()
{
    Console.WriteLine("Welcome to the Adventure Game!");
    Console.WriteLine("==============================");
    Console.WriteLine("As an avid traveler, you have decided to visit the Catacombs of Paris. However, during your exploration, you find yourself lost. You can choose to walk in multiple directions to find a way out. Let's start with your name: ");
}
void StartingOfGame()
{
    Console.WriteLine("Let's start with your name:");
    string name = (Console.ReadLine()!);
    Console.WriteLine($"Good luck {name}");
}
void IntroScene()
{
    Console.WriteLine("You are at a crossroads, and you can choose to go down any of the four hallways. Where would you like to go?");
    Console.WriteLine("Options: north/east/south/west");
    string direction = (Console.ReadLine()!);

    switch (direction)
    {
        case "north": Console.WriteLine("DEAD END/WALL"); IntroScene(); break;
        case "east": ShowSkeletons(); break;
        case "south": HauntedRoom(); break;
        case "west": ShowShadowFigure(); break;
    }
}
void ShowSkeletons()
{
    Console.WriteLine("You see a wall of skeletons as you walk into the room. Someone is watching you. Where would you like to go?");
    Console.WriteLine("Options: north/east/south/west");
    string direction = (Console.ReadLine()!);

    switch (direction)
    {
        case "north": DeadEndWall(); break;
        case "east": StrangeCreature(); break;
        case "west": IntroScene(); break;
        case "south": RoomWitch(); break;
    }
}
void StrangeCreature()
{
    Console.WriteLine("A strange goul-like creature has appeared. You can either run or fight it. What would you like to do?");
    Console.WriteLine("Options: flee/fight");
    string option = (Console.ReadLine()!);
    if (option == "flee")
    {
        Console.WriteLine("You are back in the ShowSkeletons-room.");
        ShowSkeletons();
    }
    else if (option == "fight" && HavingKnife)
    {
        Console.WriteLine("You kill the Goul with the knife you found earlier.");
        Console.WriteLine("Now you can only go south");
        Console.WriteLine("Type in south its the only direction for a exit");
        string direction = (Console.ReadLine()!);
        switch (direction)
        {
            case "south": Console.WriteLine("You made it! You've found an exit."); ; break;

        }
    }
    else if (option == "fight" && HavingWeapon)
    {
        Console.WriteLine("You kill the Goul with your pistol .");
        Console.WriteLine("Now you can only go south");
        Console.WriteLine("Type in south its the only direction for a exit");
        string direction = (Console.ReadLine()!);
        switch (direction)
        {
            case "south": Console.WriteLine("You made it! You've found an exit."); ; break;
        }
    }
    else if (option == "fight" && !HavingWeapon)
    {
        Console.WriteLine("The Goul-like creature has killed you.");
        DeadRoom();

    }

    else if (option == "fight" && !HavingKnife && !HavingFood && !HavingWeapon)
    {
        Console.WriteLine("The Goul-like creature has killed you.");
        DeadRoom();

    }
    else if (option == "fight" && HavingFood)
    {
        Console.WriteLine("You don't have a gun so you would win without a weapon");
        Console.WriteLine("You are fighting against the creature an nearly dies, but when you athe the food you activated the Capability (fire breath)");
        Console.WriteLine("Now you have more living points and your fire breath blew the creature away");
        Console.WriteLine("You killed the Goul with your breath .");
        Console.WriteLine("Now you can only go south");
        Console.WriteLine("Type in south its the only direction for a exit");
        string direction = (Console.ReadLine()!);
        switch (direction)
        {
            case "south": Console.WriteLine("You made it! You've found an exit."); ; break;
        }
    }
    DeadRoom();

}



void DeadEndWall()
{
    Console.WriteLine("You find that this door opens into a wall. You open some of the drywall to discover a knife.");
    HavingKnife = true;
    Console.WriteLine("Options: east/south/west");
    string direction = (Console.ReadLine()!);
    switch (direction)
    {

        case "east": StrangeCreature(); break;
        case "west": IntroScene(); break;
    }
}
void ShowShadowFigure()
{
    Console.WriteLine("You see a dark shadowy figure appear in the distance. You are creeped out. Where would you like to go?");
    Console.WriteLine("Options: north/east/south");
    string direction = (Console.ReadLine()!);
    switch (direction)
    {
        case "north": CameraScene(); break;
        case "east": IntroScene(); break;
        case "south": Console.WriteLine("DEAD END/WALL"); ShowShadowFigure(); break;
    }

}
void CameraScene()
{
    Console.WriteLine("You see a camera that has been dropped on the ground. Someone has been here recently. Where would you like to go?");
    Console.WriteLine("Options: north/south");
    string direction = (Console.ReadLine()!);
    switch (direction)
    {
        case "north": Console.WriteLine("it's the exit"); break;
        case "south": ShowShadowFigure(); break;
    }
}
void HauntedRoom()
{
    Console.WriteLine("You hear strange voices. You think you have awoken some of the dead. Where would you like to go?");
    Console.WriteLine("Options: north/east/west");
    string direction = (Console.ReadLine()!);
    switch (direction)
    {
        case "north": IntroScene(); break;
        case "east": Console.WriteLine("it's the exit"); break;
        case "west": Console.WriteLine("You are DEAD"); break;
    }
}
void RoomWitch()  // extra room (advanced)
{
    Console.WriteLine("You see a witch! She asks you if you want a weapon or food?");
    string antwort = (Console.ReadLine()!);
    if (antwort == "weapon")
    {
        Console.WriteLine("You get a pistol");
        HavingWeapon = true;
    }
    else if (antwort == "food")
    {
        HavingFood = true;
        Console.WriteLine("You get some food; it's just an apple and two bananas");
       
    }
    Console.WriteLine("In witch direction do you want to go?");
    Console.WriteLine("Options: north");
    string direction = (Console.ReadLine()!);
    switch (direction)
    {
        case "north": ShowSkeletons(); break;
        case "south": Console.WriteLine("it's the exit"); break;
    }

}
void DeadRoom()
{
    Console.WriteLine("Multiple Goul-like creatures start emerging as you enter the room. You are killed.");
}