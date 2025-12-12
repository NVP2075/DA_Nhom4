using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wolf_Rabbit
{
     class Rabbit:Animal
    {
        public Rabbit()
        {
            PositionX = 0;
            PositionY = 0;
            Energy = 1;
            Age = 1;
            AnimalColor = Color.White;
            EnergyToReproduce = 10;
            ChangeToReproduce = (float)0.5;
            AgeToReproduce = 3;
            VisionRange = 200;
            MoveSpeed = 12;
        }
        //Phương thức di chuyển của Rabbit
        public override void Move(List<Animal>[,] grid, int worldWidth, int worldHeight)
        {
            int indexX = randomGen.Next(-MoveSpeed, MoveSpeed);
            int indexY = randomGen.Next(-MoveSpeed, MoveSpeed);
            PositionX += indexX;
            PositionY += indexY;
            if(PositionX <0) PositionX = 0;
            if(PositionX > worldWidth -10) PositionX = worldWidth -10;
            if(PositionY<0) PositionY = 0;
            if(PositionY > worldHeight -10) PositionY = worldHeight -10;
            Energy += 2;
            Age++;
           
        }
        public Rabbit rabbitReproduce()
        {
            if (Age >= AgeToReproduce&&Energy >= EnergyToReproduce && randomGen.NextDouble() < ChangeToReproduce)
            {
                Rabbit babyRabbit = new Rabbit();
                babyRabbit.PositionX = PositionX;
                babyRabbit.PositionY = PositionY;
                babyRabbit.AnimalColor = Color.LightSkyBlue;
                Energy = 1;
                return babyRabbit;
            }
            return null;
        }
    }
}
