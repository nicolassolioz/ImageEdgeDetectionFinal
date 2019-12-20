using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ImageEdgeDetection.Business
{
    class ImageFilter
    {

        //Zen Filter apply color filter at your own taste
        public Bitmap zenFilter(Bitmap bmp, int alpha, int red, int blue, int green)
        {

            Bitmap temp = new Bitmap(bmp.Width, bmp.Height);

            //check if one ore more negative or 0
            if (alpha <= 0 || red <= 0 || blue <= 0 || green <= 0)
            {
                if (alpha <= 0)
                    alpha = 1;
                if (red <= 0)
                    red = 1;
                if (blue <= 0)
                    blue = 1;
                if (green <= 0)
                    green = 1;

                for (int i = 0; i < bmp.Width; i++)
                {
                    for (int x = 0; x < bmp.Height; x++)
                    {
                        Color c = bmp.GetPixel(i, x);
                        Color cLayer = Color.FromArgb(c.A / alpha, c.R / red, c.G / green, c.B / blue);
                        temp.SetPixel(i, x, cLayer);
                    }

                }
                return temp;
            }

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int x = 0; x < bmp.Height; x++)
                {
                    Color c = bmp.GetPixel(i, x);
                    Color cLayer = Color.FromArgb(c.A / alpha, c.R / red, c.G / green, c.B / blue);
                    temp.SetPixel(i, x, cLayer);
                }

            }
            return temp;
        }


        //Rainbow Filter
        public Bitmap rainbowFilter(Bitmap bmp)
        {

            Bitmap temp = new Bitmap(bmp.Width, bmp.Height);
            int raz = bmp.Height / 4;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int x = 0; x < bmp.Height; x++)
                {

                    if (i < (raz))
                    {
                        temp.SetPixel(i, x, Color.FromArgb(bmp.GetPixel(i, x).R / 5, bmp.GetPixel(i, x).G, bmp.GetPixel(i, x).B));
                    }
                    else if (i < (raz * 2))
                    {
                        temp.SetPixel(i, x, Color.FromArgb(bmp.GetPixel(i, x).R, bmp.GetPixel(i, x).G / 5, bmp.GetPixel(i, x).B));
                    }
                    else if (i < (raz * 3))
                    {
                        temp.SetPixel(i, x, Color.FromArgb(bmp.GetPixel(i, x).R, bmp.GetPixel(i, x).G, bmp.GetPixel(i, x).B / 5));
                    }
                    else if (i < (raz * 4))
                    {
                        temp.SetPixel(i, x, Color.FromArgb(bmp.GetPixel(i, x).R / 5, bmp.GetPixel(i, x).G, bmp.GetPixel(i, x).B / 5));
                    }
                    else
                    {
                        temp.SetPixel(i, x, Color.FromArgb(bmp.GetPixel(i, x).R / 5, bmp.GetPixel(i, x).G / 5, bmp.GetPixel(i, x).B / 5));
                    }
                }

            }
            return temp;
        }

        // Swap Filter
        public Bitmap swapFilter(Bitmap bmp)
        {
            Bitmap temp = new Bitmap(bmp.Width, bmp.Height);

            Console.WriteLine(temp.GetHashCode());

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int x = 0; x < bmp.Height; x++)
                {
                    Color c = bmp.GetPixel(i, x);
                    Color cLayer = Color.FromArgb(c.A, c.G, c.B, c.R);
                    temp.SetPixel(i, x, cLayer);
                }

            }

            return temp;
        }


    }
}
