int playerMoney = 500;
int playerResources = 25;
int playerCountCell = 3;

int surchangeMoney = 10;
int surchangeResources = 0;


Random rand = new Random();

while (true)
{
    playerMoney += surchangeMoney;
    playerResources += surchangeResources;
    
    System.Console.WriteLine("0. Пропустить ход");
    System.Console.WriteLine("1. Построить завод I уровня - 300$ 15 ресурсов (+15$ прибыли каждый ход, 1 ячейка)");
    System.Console.WriteLine("2. Построить завод II уровня - 800$ 40 ресурсов (+45$ прибыли каждый ход, 3 ячейки)");
    System.Console.WriteLine("3. Добыча ресурсов (вручную) - 50$ (от 5 до 15 ресурсов рандомно)");
    System.Console.WriteLine("4. Автодобыча ресурсов - 300$ + 10$ каждый ход, 30 ресурсов, 2 ячейки (от 3 до 7 ресурсов рандомно)");
    System.Console.WriteLine("5. Построить завод III уровня - 2000$ 80 ресурсов (+100$ прибыли каждый ход, 7 ячеек)");
    System.Console.WriteLine("6. Расширить территорию на X ячеек - X * 50$ + X * 5 ресурсов)");

    System.Console.WriteLine();

    System.Console.WriteLine($"Денег: {playerMoney}, ресурсов: {playerResources}, ячеек: {playerCountCell}");
    System.Console.WriteLine($"Выручка с продаж за ход: {surchangeMoney}, производительность добычи ресурсов: {surchangeResources}");

    int playerChoice = Convert.ToInt32(Console.ReadLine());

    switch (playerChoice)
    {
        case 0:
            break;

        case 1:
            if (playerMoney >= 300 && playerResources >= 15 && playerCountCell > 0)
            {
                surchangeMoney += 15;

                playerMoney -= 300;
                playerResources -= 15;
                playerCountCell--;
            }
            else
            {
                System.Console.WriteLine("Недостаточно средств для преобретения.");
            }
            break;

        case 2:
            if (playerMoney >= 800 && playerResources >= 40 && playerCountCell >= 3)
            {
                surchangeMoney += 45;

                playerMoney -= 800;
                playerResources -= 40;
                playerCountCell -= 3;
            }
            else
            {
                System.Console.WriteLine("Недостаточно средств для преобретения.");
            }
            break;

        case 3:
            if (playerMoney >= 50)
            {
                playerMoney -= 50;
                playerResources += rand.Next(5, 15);
            }
            else
            {
                System.Console.WriteLine("Недостаточно средств для преобретения.");
            }
            break;

        case 4:
            if (playerMoney >= 300 && playerResources >= 30 && playerCountCell >= 2)
            {
                surchangeMoney -= 10;
                surchangeResources += rand.Next(3, 7);

                playerMoney -= 300;
                playerResources -= 30;
                playerCountCell -= 2;
            }
            else
            {
                System.Console.WriteLine("Недостаточно средств для преобретения.");
            }
            break;

        case 5:
            if (playerMoney >= 2000 && playerResources >= 80 && playerCountCell >= 7)
            {
                surchangeMoney += 100;

                playerMoney -= 2000;
                playerResources -= 80;
                playerCountCell -= 7;
            }
            else
            {
                System.Console.WriteLine("Недостаточно средств для преобретения.");
            }
            break;

        case 6:
            int countOfCells = Convert.ToInt32(Console.ReadLine());

            if (playerMoney >= countOfCells * 50)
            {
                playerMoney -= countOfCells * 50;
                playerCountCell += countOfCells;
            }

            else
            {
                System.Console.WriteLine("Недостаточно средств для преобретения.");
            }
            break;  
    }

}

static int Get(int kratnost, int x)
{
    if (x % kratnost != 0)
    {
        System.Console.WriteLine('net');
    }
    else {
        System.Console.WriteLine('da');
    }
}