using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_25_01
{
    public class House
    {
        private const int CNT_WALL = 4;
        private const int CNT_WINDOW = 4;
        private IPart basement = new Basement();
        private IPart door = new Door();
        private IPart roof = new Roof();
        private IPart[] walls = new Wall[CNT_WALL];
        private IPart[] windows = new Window[CNT_WINDOW];

        public House()
        {
            for (int i = 0; i < CNT_WALL; ++i)
            {
                walls[i] = new Wall();
            }
            for (int i = 0; i < CNT_WINDOW; ++i)
            {
                windows[i] = new Window();
            }
        }

        internal void PaintHouse()
        {
           Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░▄▄▄░░░░░░░░░░░░░░\n░░░░░░░░░░░░░░░░░░░░░███░░░░░░░░░░░░░░\n░░░░░░░░▄█████████████████▄░░░░░░░░░░░\n░░░░░░▄██████████████████▀██▄░░░░░░░░░\n░░░░░▄██████████████████░░░▀██░░░░░░░░\n░░░░███████████████████░░▄▄░░▀█▄░░░░░░\n░░▄██████████████████▀░░▄███▄░░▀█▄░░░░\n░███████████████████▀░░▄█████▄░░▀██▄░░\n███████████████████▀░░█████████▄░░▀█▄░\n░░░▀▀▀▀▀██████████░░░████████████▄░░▀▀\n░░▄▄▄▄░░░░░░░▀▀▀▀░░▄██████████████░░░░\n░░█████████▄▄▄▄▄░░▄███████████████░░░░\n░░█████████████████████▀▀░░███████░░░░\n░░███████████████████░░░░░░███████░░░░\n░░███████████████████░░░░░░███████░░░░\n░░███████████████████░░░░░░███████░░░░\n░░▀▀█████████████████░░░░░░█████▀▀░░░░\n░░░░░░▀▀▀████████████░░░░░░▀▀▀░░░░░░░░\n░░░░░░░░░░░▀▀████████░░░░░░░░░░░░░░░░░\n░░░░░░░░░░░░░░░▀▀▀███░░░░░░░░░░░░░░░░░");
        }

        public IPart Basement
        {
            get
            {
                return basement;
            }
            set
            {
                basement = value;
            }
        }

        public IPart Door
        {
            get
            {
                return door;
            }
            set
            {
                door = value;
            }
        }

        public IPart Roof
        {
            get
            {
                return roof;
            }
            set
            {
                roof = value;
            }
        }
        public IPart WallFirst
        {
            get
            {

                return walls[0];

            }
            set
            {
                walls[0] = value;
            }
        }

        public IPart WallSecond
        {
            get
            {

                return walls[1];

            }
            set
            {
                walls[1] = value;
            }
        }

        public IPart WallThird
        {
            get
            {

                return walls[2];

            }
            set
            {
                walls[2] = value;
            }
        }

        public IPart WallFourth
        {
            get
            {

                return walls[3];

            }
            set
            {
                walls[3] = value;
            }
        }
        public IPart WindowFirst
        {
            get
            {

                return windows[0];

            }
            set
            {
                windows[0] = value;
            }
        }

        public IPart WindowSecond
        {
            get
            {

                return windows[1];

            }
            set
            {
                windows[1] = value;
            }
        }

        public IPart WindowThird
        {
            get
            {

                return windows[2];

            }
            set
            {
                windows[2] = value;
            }
        }

        public IPart WindowFourth
        {
            get
            {

                return windows[3];

            }
            set
            {
                windows[3] = value;
            }
        }
    }
}
