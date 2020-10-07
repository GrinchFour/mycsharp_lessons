using System;

namespace mycsharp_lesson22
{
    interface ISwitchable
    {
        void SwitchMe(bool sw);
    }

    interface ILight
    {
        void LightMe(string lt);
    }

    class veryImportantDetail : ISwitchable, ILight
    {
        private bool sw;
        private string lt;

        public void SwitchMe(bool sw)
        {
            this.sw = sw;
        }

        public void LightMe(string lt)
        {
            this.lt = lt;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
