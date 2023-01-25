using System;

namespace AreaLibrary
{
    public abstract class Figure
    {
        public string FigureName { get; private set; }

        public Figure(string FigureName)
        {
            this.FigureName = FigureName;
        }

        public abstract double Square();

    }
}
