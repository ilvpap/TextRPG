using System;
using System.Runtime.InteropServices;
using System.Threading;
using static Program;
using System.Xml.Linq;
using System.Security.Cryptography;
using System.Security.Principal;


public static class Program
{
    public static List<Item> itemList;
        static void Main(string[] args) // Main 으로부터 시작합니다~
        {
        // 아이템 목록
        itemList = new List<Item>();
        itemList.Add(new Item("피묻은 옷", "짐승의 것인지 사람의 것인지 모를 피가 말라 붙어있다.", ItemOption.DEFENSE, +5, 10));
        itemList.Add(new Item("낡은 부적", "알 수없는 문자가 새겨져있다. 왠지 가지고 다니면 괜찮을 것 같다.", ItemOption.ATTACK, +5, 10));
        itemList.Add(new Item("화려한 부채", "누가 사용했던 부채인 것 같다. 알 수 없는 기운이 서려있다.", ItemOption.ATTACK, +5, 10));
        itemList.Add(new Item("화려한 부채", "누가 사용했던 부채인 것 같다. 알 수 없는 기운이 서려있다.", ItemOption.ATTACK, +5, 10));
        itemList.Add(new Item("화려한 부채", "누가 사용했던 부채인 것 같다. 알 수 없는 기운이 서려있다.", ItemOption.ATTACK, +5, 10));
        itemList.Add(new Item("화려한 부채", "누가 사용했던 부채인 것 같다. 알 수 없는 기운이 서려있다.", ItemOption.ATTACK, +5, 10));

            // 게임 시작
            string Loading = "GaMe LOaDing . . .";

            TypeEffect(Loading, 50);
            Thread.Sleep(2000);

            Console.WriteLine("\n\n\n희망과 꿈으로 가득 찬, NeRo에 오신 것을 환영합니다.");
            Thread.Sleep(1500);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("이곳은 당신이 하고 □은 모든 것을 할 수 있습니다?");
            Console.WriteLine("이곳은 당신이 n고 싶은 모든 □을 할 수 있습니다.");
            Console.WriteLine("이곳은 □신이 하고 싶은 모든 것을 할 수 있습니d.");
            Console.WriteLine("□곳은 당신이 하고 싶은 모든 것□ 할 수 있습n다.");
            Console.WriteLine("이곳은 당신이 하고 □은 모든 것을 할 수 있습니다.");
            Console.WriteLine("이곳은 당신이 하고 싶은 모든 □을 할 수 있습니다.");
            Console.WriteLine("이곳은 □신이 하고 싶은 모든 것을 할 수 있습니다.");
            Console.WriteLine("□곳은 당신이 하고 싶은 모든 것□ 할 수 있습니다.");
            Console.WriteLine("이곳은 당신이 하고 □은 모든 것을 할 \\n 있습니다.");
            Console.WriteLine("이곳은 당신이 하고 싶은 모든 □을 할 수 있습니다.");
            Console.WriteLine("이곳은 □신이 하고 싶은 모든 것을 할 수 있습니다.");
            Console.WriteLine("□곳은 당신이 하고 n은 모든 것□ 할 수 있습니다.");
            Thread.Sleep(300);

            Console.Clear();

            //Console.WriteLine("");

            string message = "\n저주와 악으□ 가득 찬, Ne※o에 오신 것을 환영합니다?";
            TypeEffect(message, 15);
            Thread.Sleep(300);

            // 장면 전환
            Console.Clear();

            string welcome = "희망과 꿈으로 가득 찬, NeRo에 오신 것을 환영합니다.";
            TypeEffect(welcome, 50);
            Thread.Sleep(2000);

            string type = "\n\n해당 월드에 들어가기 전에 이 계약서에 서명을 하셔야합니다.\n\n";
            TypeEffect(type, 50);
            Thread.Sleep(2000);


            string rule = "첫 번째, 그 누구에게도 말을 걸지 마십시오. 그들은 당신을 인식하지 못합니다.\n\n";
            TypeEffect(rule, 50);
            Thread.Sleep(1000);

            string rule2 = "두 번째, 그들이 당신에게 말을 걸더라도 자연스럽게 행동하십시오.\n\n";
            TypeEffect(rule2, 50);
            Thread.Sleep(1000);

            string rule3 = "세 번째, 여기에서 일어나는 모든 일들은 NeRo에서 책임져주지 않습니다.\n\n";
            TypeEffect(rule3, 50);

            Thread.Sleep(2000);

            Menu.SetName(); // 메뉴 클래스의 메인을 불러옴
            
            Console.Clear();

            Console.WriteLine("\n\n\n그렇습니까.");
            Thread.Sleep(1000);

            string nametype = "\n\n\n당신의 이름은 ";
            TypeEffect(nametype, 50);
            Thread.Sleep(2000);

            Console.Clear();

            string nameType = "\n\n\n  " + player.name + " . . .";
            TypeEffect(nameType, 100);
            Thread.Sleep(2000);

            Menu.SetJob();

            Console.Clear();
            Thread.Sleep(5000);

            Console.WriteLine("\n어서오세요 " + player.name + "님 기다리고 있었습니다.");
            Thread.Sleep(3000);

            Console.WriteLine("\n꿈과 희망이 가득한 NeRo World는 " + player.name + "님의 입장만을 기다리고 있었습니다.");
            Thread.Sleep(3000);

            Console.WriteLine("\n부디 마음껏 즐겨주시길 바랍니다.");
            Thread.Sleep(3000);

            Console.Clear();

            Menu.GameStart();
        }



        static void TypeEffect(string text, int delay = 50)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
        }
}
public class Menu
{
    public static void SetName()
    {
        do //반복
        {
            Console.WriteLine("\n\n서명해주십시오.");
            Thread.Sleep(300);

            int num;

            player.name = Console.ReadLine();
            bool Name = int.TryParse(player.name, out num);
            bool hasAlpha = false;

            foreach (char c in player.name)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    hasAlpha = true;
                    break;
                }
                if (Name)
                {
                    hasAlpha = true;
                    break;
                }


            }
            if (hasAlpha)
            {
                Console.WriteLine("읽을 수 없는 글자가 포함되어 있습니다.");
            }

            else
            {
                loop.Loop = false;
            }

        } while (loop.Loop);

    }
    public static void SetJob()
    {
        loop.Loop = true;
        do
        {
            Console.WriteLine(" \n\n\n 우선 당신의 직업은? \n ");
            Console.WriteLine(" [1] 학생 \n ");
            Console.WriteLine(" [2] 살인마 \n ");
            Console.WriteLine(" [5] ※!▒º?\n ");

            int num;

            string input = Console.ReadLine();
            bool Job = int.TryParse(input, out num);

            if (Job)
            {
                switch (num)
                {
                    case 1:
                        player.job = "학생";
                        loop.Loop = false;
                        break;
                    case 2:
                        player.job = "살인마";
                        loop.Loop = false;
                        break;
                    case 5:
                        Console.WriteLine("dddddd");
                        break;
                    default:
                        Message.FailMessage();
                        break;
                }
            }
            else
            {
                Message.FailMessage();            
            }

        } while (loop.Loop);
    }
    public static void GameStart()
    {
        loop.Loop = true;

        do
        {
            Console.WriteLine("드디어... 당신은 입장했습니다. 꿈과 희망이 가득한 NeRo World 에.");
            Console.WriteLine("이곳은 들어가기 전에 선택하는 창입니다.");
            Console.WriteLine("무엇을 하시겠습니까?");


            Console.WriteLine("[1] 상태보기");
            Console.WriteLine("[2] 인벤토리");
            Console.WriteLine("[3] 상점");
            Console.WriteLine("[0] 종료");

            int num;

            string input = Console.ReadLine();
            bool Gstart = int.TryParse(input, out num);


            if (Gstart)
            {
                switch (num)
                {
                    case 1:
                        player.Gstart = "상태보기";
                        ShowStatus.Show();
                        break;
                    case 2:
                        player.Gstart = "인벤토리";
                        Inventory.Show();
                        break;
                    case 3:
                        player.Gstart = "상점";
                        Shop.Show();
                        break;
                    case 0:
                        Console.WriteLine("NeRo World에서 벗어납니다.");
                        Environment.Exit(0);
                        break;
                    default:
                        Message.FailMessage();
                        continue;
                }

                Console.WriteLine("\n 처음 메뉴로 돌아가려면 아무 키나 누르세요. . .");
                Console.ReadKey(); // 사용자 입력 대기
                Console.Clear(); // 화면 정리
                
            }
            else
            {
                Message.FailMessage();
            }

        } while (loop.Loop);
    }
}
public class ShowStatus
{
    public static void Show()
    {
        Console.Clear();
        Console.WriteLine("======= 상태보기 ========");
        Console.WriteLine($"이름 : {player.name}");
        Console.WriteLine($"직업 : {player.job}");
        Console.WriteLine("레벨 : 1");
        Console.WriteLine("체력 : 100");
        Console.WriteLine("========================");
    }
}

public class Inventory
{
    public static void Show()
    {
        Console.Clear();
        Console.WriteLine("======= 인벤토리 ========");
        if (player.inventory.Count == 0)
        {
        Console.WriteLine("(Empty)");

        }
        else
        {
            foreach (var item in player.inventory)
            {
                Console.WriteLine(item.GetItemInfo());
            }
        }
            Console.WriteLine("========================");
    }
}

public class Shop
{
    public static void Show()
    {
        Console.Clear();
        Console.WriteLine("========= 상점 ==========");
        Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.\n");
        Console.WriteLine($"[보유 골드] {player.Point} P\n");

        Console.WriteLine("[아이템 목록]");

        foreach(var data in Program.itemList)
        {
            Console.WriteLine(data.GetItemInfo());
        }

        Console.WriteLine("[0] 나가기");
        Console.WriteLine("=========================");
        Console.WriteLine("\n 원하시는 행동을 입력해주세요");

        string input = Console.ReadLine();
        int choice;
        bool valid = int.TryParse(input, out choice);

        if (valid)
        {
            if (choice == 0)
            {
                return;
            }
            if(choice>= 1 && choice <= Program.itemList.Count)
            {
                Item selectedItem = Program.itemList[choice - 1];

                if (selectedItem.IsPurchased)
                {
                    Console.WriteLine("\n 이미 구매한 아이템입니다.");
                    return;
                }

                if (player.Point >= selectedItem.Price)
                {
                    player.Point -= selectedItem.Price;
                    selectedItem.IsPurchased = true;
                    player.inventory.Add(selectedItem);
                    Console.WriteLine($"\n{selectedItem.Name} 아이템을 구매하셨습니다. \n 남은 골드는 {player.Point}P");
                }
                else
                {
                    Console.WriteLine("\nPoint가 부족합니다.");
                }
            }
            else
            {
                Message.FailMessage();
            }
        }
        else
        {
            Message.FailMessage();
        }
    }
    
}

public enum ItemOption
{
    ATTACK, DEFENSE
}
//public enum ItemName
//{

//}
public class Item
{
    private string name;
    private string description;
    private ItemOption itemOption;
    private int value;
    private int price;
    private bool isPurchased =false;

    public Item(string name, string description, ItemOption itemOption, int Value, int Price)
    {
        this.name = name;
        this.description = description;
        this.itemOption = itemOption;
        this.value = value;
        this.price = price;
    }
    public string Name => name;
    public string Description => description;
    public ItemOption Option => itemOption;
    public int Value => value;
    public int Price => price;
    public bool IsPurchased
    {
        get => isPurchased;
        set => isPurchased = value;
    }

    public string GetItemInfo()
    {
        return name + " " + description;
    }
    
}
public class player
{
    public static string name = "";
    public static string job = "";
    public static string Gstart = "";
    public static int Point = 1500;

    public static List<Item> inventory = new List<Item>();
}
public class loop
{
    public static bool Loop = true;
}

public class Message
{
    public static void FailMessage()
    {
        Console.WriteLine("\n알맞게 입력하십시오.\n");
    }
}