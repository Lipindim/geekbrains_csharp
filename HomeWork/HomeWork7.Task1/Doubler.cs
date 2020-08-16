using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7.Task1
{
    public class Doubler
    {
        public int TargetValue { get; }
        public int CurrentValue { get; private set; }
        public int CommandCount
        {
            get
            {
                return this.commands.Count;
            }
        }
        private readonly Stack<CommandType> commands;

        public Doubler()
        {
            this.TargetValue = new Random().Next(100, 200);
            this.CurrentValue = 1;
            this.commands = new Stack<CommandType>();
        }

        public void Reset()
        {
            this.CurrentValue = 1;
            this.commands.Clear();
        }

        public void Cancel()
        {
            if (this.CommandCount != 0)
            {
                CommandType lastCommnad = this.commands.Pop();
                switch (lastCommnad)
                {
                    case CommandType.PlusOne:
                        this.CurrentValue--;
                        break;
                    case CommandType.MyltiplyByTwo:
                        this.CurrentValue /= 2;
                        break;
                    default:
                        break;
                }
            }
        }

        public void PlusOne()
        {
            this.CurrentValue++;
            this.commands.Push(CommandType.PlusOne);
        }

        public void MyltiplyByTwo()
        {
            this.CurrentValue *= 2;
            this.commands.Push(CommandType.MyltiplyByTwo);
        }
        public bool IsWin()
        {
            return this.TargetValue == this.CurrentValue;
        }
    }

    public enum CommandType
    {
        PlusOne,
        MyltiplyByTwo
    }
}
