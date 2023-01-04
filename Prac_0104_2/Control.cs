using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_0104_2
{
    internal class Control
    {
        public void PlayerMove(string[,]arrayName, ref int locX, ref int locY, ref bool moveCheck, ref int hp, ref int score)
        {
            string temp;
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine();

            switch (keyInfo.KeyChar)
            {
                case 'a':
                    if(arrayName[locX,locY-1] != "■") 
                    {
                        switch(arrayName[locX, locY-1])
                        {
                            case "▼":
                                moveCheck = false;
                                break;
                            case "! ":
                            case "ㅗ":
                                hp -= 10;
                                temp = arrayName[locX, locY];
                                arrayName[locX, locY] = "□";
                                arrayName[locX, locY - 1] = temp;
                                break;
                            case "◎":
                                score+= 10;
                                temp = arrayName[locX, locY];
                                arrayName[locX, locY] = "□";
                                arrayName[locX, locY - 1] = temp;
                                break;
                            case "□":
                                temp = arrayName[locX, locY];
                                arrayName[locX, locY] = arrayName[locX, locY - 1];
                                arrayName[locX, locY - 1] = temp;
                                break;
                        }
                    }
                    else { }
                    break;


                case 'd':
                    if (arrayName[locX, locY+1] != "■")
                    {
                        switch (arrayName[locX, locY+1])
                        {
                            case "▼":
                                moveCheck = false;
                                break;
                            case "ㅗ":
                            case "! ":
                                hp -= 10;
                                temp = arrayName[locX, locY];
                                arrayName[locX, locY] = "□";
                                arrayName[locX, locY + 1] = temp;
                                break;
                            case "◎":
                                score += 10;
                                temp = arrayName[locX, locY];
                                arrayName[locX, locY] = "□";
                                arrayName[locX, locY + 1] = temp;
                                break;
                            case "□":
                                temp = arrayName[locX, locY];
                                arrayName[locX, locY] = arrayName[locX, locY+1];
                                arrayName[locX, locY+1] = temp;
                                break;
                        }
                    }
                    else { }
                    break;
                case 'w':
                    if (arrayName[locX-1, locY] != "■")
                    {
                        switch (arrayName[locX-1 , locY ])
                        {
                            case "▼":
                                moveCheck = false;
                                break;
                            case "ㅗ":
                            case "! ":
                                hp -= 10;
                                temp = arrayName[locX, locY];
                                arrayName[locX, locY] = "□";
                                arrayName[locX-1, locY] = temp;
                                break;
                            case "◎":
                                score += 10;
                                temp = arrayName[locX, locY];
                                arrayName[locX, locY] = "□";
                                arrayName[locX - 1, locY] = temp;
                                break;
                            case "□":
                                temp = arrayName[locX, locY];
                                arrayName[locX, locY] = arrayName[locX - 1, locY];
                                arrayName[locX - 1, locY] = temp;
                                break;
                        }
                    }
                    else { }
                    break;
                case 's':
                    if (arrayName[locX+1, locY] != "■")
                    {
                        switch (arrayName[locX+1, locY])
                        {
                            case "▼":
                                moveCheck = false;
                                break;
                            //다음층
                            case "ㅗ":
                            case "! ":
                                hp -= 10;
                                temp = arrayName[locX, locY];
                                arrayName[locX, locY] = "□";
                                arrayName[locX+1, locY] = temp;
                                break;
                            case "◎":
                                score += 10;
                                temp = arrayName[locX, locY];
                                arrayName[locX, locY] = "□";
                                arrayName[locX + 1, locY] = temp;
                                break;
                            case "□":
                                temp = arrayName[locX, locY];
                                arrayName[locX, locY] = arrayName[locX + 1, locY];
                                arrayName[locX + 1, locY] = temp;
                                break;
                        }
                    }
                    else { }
                    break;
                }
            
        }

    }
}
