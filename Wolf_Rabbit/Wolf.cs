using System;
using System.Collections.Generic;
using System.Drawing;

namespace Wolf_Rabbit
{
     class Wolf: Animal
    {
        
        
        public Wolf()
        {
            PositionX = 0;
            PositionY = 0;
            Energy = 20;
            Age = 1;
            AnimalColor = Color.DarkGray;
            EnergyToReproduce = 50;
            ChangeToReproduce = (float)0.25;
            AgeToReproduce = 5;
            VisionRange = 500;
            MoveSpeed = 50;
        }
        //Phương thức di chuyển và săn mồi của sói
        public override void Move(List<Animal>[,] grid, int worldWidth,int worldHeight)
        {
            Rabbit target = null;
            double minDist = -1;
            int cellSize = 10;
            int currCellX = PositionX / cellSize;
            int currCellY = PositionY / cellSize;
            for (int i = -1; i <= 1; i++)       //Tìm mục tiêu trong 9 ô xung quanh sói
            {
                for (int j = -1; j <= 1; j++)   //Tìm mục tiêu trong 9 ô xung quanh sói
                {
                    int neighborCellX = currCellX + i;
                    int neighborCellY = currCellY + j;
                    //Kiểm tra ô cận kề có hợp lệ không 
                    if (neighborCellX >= 0 && neighborCellX < grid.GetLength(0) && neighborCellY >= 0 && neighborCellY < grid.GetLength(1))
                    { 
                        foreach (var closeAnimal in grid[neighborCellX, neighborCellY]) //Khởi tạo biến con vật gần nhất và
                                                                                        //duyệt trong lưới 9 ô xung
                                                                                        //quanh danh sách con vật ở gần 
                            if ((closeAnimal is Rabbit))
                            {
                                //Tính khoảng cách giữa sói và thỏ theo công thức pytago
                                double distance = Math.Sqrt(Math.Pow(closeAnimal.PositionX- PositionX , 2) + Math.Pow(closeAnimal.PositionY- PositionY , 2));
                                if (minDist == -1 || distance < minDist) //kiểm tra lại min distant nếu có mục tiêu gần hơn
                                {
                                    minDist = distance;
                                    target = (Rabbit)closeAnimal;
                                }
                            }
                    }
                }

            }
            if (target != null && minDist < VisionRange)
            {
                if (minDist <= 50) //Nếu mục tiêu có khoảng cách <=50 ô pixel(trong panel) thì nhảy tới mục tiêu và ăn
                {
                    PositionX = target.PositionX;
                    PositionY = target.PositionY;
                    Energy += 20;
                    target.Energy = -1;
                    
                }
                else
                {
                    //Di chuyển theo hướng của con mồi
                    if (target.PositionX > PositionX && target.PositionY > PositionY)
                    {
                        PositionX += MoveSpeed;
                        PositionY += MoveSpeed;
                    }
                    else if (target.PositionX < PositionX && target.PositionY < PositionY)
                    {
                        PositionX -= MoveSpeed;
                        PositionY -= MoveSpeed;
                    }                 
                }
            }
            else //Khoảng cách lớn hơn 500 thì di chuyển ngẫu nhiên
            {

                int deltaX = randomGen.Next(-MoveSpeed, MoveSpeed);
                int deltaY = randomGen.Next(-MoveSpeed, MoveSpeed);
                PositionX += deltaX;
                PositionY += deltaY;
                if (PositionX < 0) PositionX = 0;
                if (PositionX > worldWidth - 10) PositionX = worldWidth - 10;
                if (PositionY < 0) PositionY = 0;
                if (PositionY > worldHeight - 10) PositionY = worldHeight - 10;
            }
            Age++;
        }
      

        public Wolf wolfReproduce()
        {
            
            if (Age >= AgeToReproduce&&EnergyToReproduce < Energy && randomGen.NextDouble() < ChangeToReproduce) {
                Wolf baby = new Wolf();
                baby.PositionX = PositionX;
                baby.PositionY = PositionY;
                baby.AnimalColor = Color.Gray;
                Energy = 20;
                return baby;
            }
            return null;
        }
            
    }
}
