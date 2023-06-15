using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum Position { left, middle, right }
    public class PlayerEntity
    {

            public const int NOTA_MINIMA = 1;
        public const int NOTA_MAXIMA = 10;

     


        public PlayerEntity(string name, string secondName, string positionInField, Position position, bool canPlayOtherPosition, string imagePath )
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.secondName = secondName ?? throw new ArgumentNullException(nameof(secondName));
            this.positionInField = positionInField ?? throw new ArgumentNullException(nameof(positionInField));
            this.position = position;
            this.canPlayOtherPosition = canPlayOtherPosition;
            this.imagePath = imagePath ?? throw new ArgumentNullException(nameof(imagePath));
        }

        

        public string name { get; set; }
        public string secondName { get; set; }
        public string positionInField { get; set; }
        public Position position { get; set; }
        public bool canPlayOtherPosition { get; set; }
        public string imagePath { get; set; }


        public override string ToString()
        {
            return $"Player {name}";
        }


    }
}
