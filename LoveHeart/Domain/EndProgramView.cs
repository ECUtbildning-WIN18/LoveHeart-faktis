﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LoveHeart.Domain
{
    class EndProgramView : IView
    {
        public bool ActionButtonPressed(ConsoleKey key)
        {
            throw new NotImplementedException();
        }

        public void Draw()
        {
            
            Console.WriteLine("Thank you, come again\n");
        }

    }
}
