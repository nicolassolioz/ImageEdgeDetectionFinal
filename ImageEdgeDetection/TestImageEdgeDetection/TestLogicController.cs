using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ImageEdgeDetection;
using ImageEdgeDetection.Business;
using ImageEdgeDetection.IOFiles;

namespace TestImageEdgeDetection
{
    [TestClass]
    public class TestLogicController
    {

        [TestMethod]
        public void testAllFilterEdgeCombinations()
        {
            //Bitmap without filters
            Bitmap controlImg = new Bitmap("../../imagesForTesting/testImg.png");
            Bitmap[] imgResultMatrice = getImageResultMatrice();
            Bitmap[] imgControlMatrice = getImageControlMatrice(controlImg);

            for (int i = 0; i<imgResultMatrice.Length; i++)
            {
                compareTwoImages(imgResultMatrice[i], imgControlMatrice[i]);
            }
        }

        
        
        public void compareTwoImages(Bitmap bmp1, Bitmap bmp2)
        {
            //code from http://csharpexamples.com/c-fast-bitmap-compare/
            int bytes = bmp1.Width * bmp1.Height * (Image.GetPixelFormatSize(bmp1.PixelFormat) / 8);

            bool result = true;
            byte[] b1bytes = new byte[bytes];
            byte[] b2bytes = new byte[bytes];

            BitmapData bitmapData1 = bmp1.LockBits(new Rectangle(0, 0, bmp1.Width, bmp1.Height), ImageLockMode.ReadOnly, bmp1.PixelFormat);
            BitmapData bitmapData2 = bmp2.LockBits(new Rectangle(0, 0, bmp2.Width, bmp2.Height), ImageLockMode.ReadOnly, bmp2.PixelFormat);

            Marshal.Copy(bitmapData1.Scan0, b1bytes, 0, bytes);
            Marshal.Copy(bitmapData2.Scan0, b2bytes, 0, bytes);

            for (int n = 0; n <= bytes - 1; n++)
            {
                if (b1bytes[n] != b2bytes[n])
                {
                    result = false;
                    break;
                }
            }

            Assert.AreEqual(true, result);
            bmp1.UnlockBits(bitmapData1);
            bmp2.UnlockBits(bitmapData2);
        }


        public Bitmap[] getImageResultMatrice()
        {
            Bitmap imgGaussianRainbow = new Bitmap("../../imagesForTesting/testImgGaussianRainbow.png");
            Bitmap imgGaussianRainbowSwap = new Bitmap("../../imagesForTesting/testImgGaussianRainbowSwap.png");
            Bitmap imgGaussianRainbowZen = new Bitmap("../../imagesForTesting/testImgGaussianRainbowZen.png");
            Bitmap imgGaussianRainbowZenSwap = new Bitmap("../../imagesForTesting/testImgGaussianRainbowZenSwap.png");
            Bitmap imgGaussianSwap = new Bitmap("../../imagesForTesting/testImgGaussianSwap.png");
            Bitmap imgGaussianZen = new Bitmap("../../imagesForTesting/testImgGaussianZen.png");
            Bitmap imgGaussianZenSwap = new Bitmap("../../imagesForTesting/testImgGaussianZenSwap.png");
            Bitmap imgPrewittRainbow = new Bitmap("../../imagesForTesting/testImgPrewittRainbow.png");
            Bitmap imgPrewittRainbowSwap = new Bitmap("../../imagesForTesting/testImgPrewittRainbowSwap.png");
            Bitmap imgPrewittRainbowZen = new Bitmap("../../imagesForTesting/testImgPrewittRainbowZen.png");
            Bitmap imgPrewittRainbowZenSwap = new Bitmap("../../imagesForTesting/testImgPrewittRainbowZenSwap.png");
            Bitmap imgPrewittSwap = new Bitmap("../../imagesForTesting/testImgPrewittSwap.png");
            Bitmap imgPrewittZen = new Bitmap("../../imagesForTesting/testImgPrewittZen.png");
            Bitmap imgPrewittZenSwap = new Bitmap("../../imagesForTesting/testImgPrewittZenSwap.png");

            Bitmap[] imgMatrice = new Bitmap[14] {imgGaussianRainbow, imgGaussianRainbowSwap, imgGaussianRainbowZen,
                                                imgGaussianRainbowZenSwap, imgGaussianSwap, imgGaussianZen,
                                                imgGaussianZenSwap, imgPrewittRainbowSwap, imgPrewittRainbow,
                                                imgPrewittRainbowZen, imgPrewittRainbowZenSwap, imgPrewittSwap,
                                                imgPrewittZen, imgPrewittZenSwap};

            return imgMatrice;
        }

        public Bitmap[] getImageControlMatrice(Bitmap control)
        {
            IReadWriteController rw = new ReadWriteController();
            ILogicController lc = new LogicController(rw);

            Bitmap imgGaussianRainbow = lc.rainbowFilter(control);
            imgGaussianRainbow = lc.gaussianEdge(imgGaussianRainbow);

            Bitmap imgGaussianRainbowZen = lc.rainbowFilter(control);
            imgGaussianRainbowZen = lc.zenFilter(imgGaussianRainbowZen, 1, 10, 1, 1);
            imgGaussianRainbowZen = lc.gaussianEdge(imgGaussianRainbowZen);

            Bitmap imgGaussianZen = lc.zenFilter(control, 1, 10, 1, 1);
            imgGaussianZen = lc.gaussianEdge(imgGaussianZen);

            Bitmap imgPrewittRainbow = lc.rainbowFilter(control);
            imgPrewittRainbow = lc.prewittEdge(imgPrewittRainbow);

            Bitmap imgPrewittRainbowZen = lc.rainbowFilter(control);
            imgPrewittRainbowZen = lc.zenFilter(imgPrewittRainbowZen, 1, 10, 1, 1);
            imgPrewittRainbowZen = lc.prewittEdge(imgPrewittRainbowZen);

            Bitmap imgPrewittZen = lc.zenFilter(control, 1, 10, 1, 1);
            imgPrewittZen = lc.prewittEdge(imgPrewittZen);

            Bitmap imgRainbow = lc.rainbowFilter(control);

            Bitmap imgZen = lc.zenFilter(control, 1, 10, 1, 1);

            Bitmap imgZenRainbow = lc.zenFilter(control, 1, 10, 1, 1);
            imgZenRainbow = lc.rainbowFilter(imgZenRainbow);

            Bitmap imgZenZero = lc.zenFilter(control, 0, 0, 0, 0);

            Bitmap imgGaussianRainbowSwap = lc.rainbowFilter(control);
            imgGaussianRainbowSwap = lc.swapFilter(imgGaussianRainbowSwap);
            imgGaussianRainbowSwap = lc.gaussianEdge(imgGaussianRainbowSwap);

            Bitmap imgGaussianRainbowZenSwap = lc.rainbowFilter(control);
            imgGaussianRainbowZenSwap = lc.zenFilter(imgGaussianRainbowZenSwap, 1, 10, 1, 1);
            imgGaussianRainbowZenSwap = lc.swapFilter(imgGaussianRainbowZenSwap);
            imgGaussianRainbowZenSwap = lc.gaussianEdge(imgGaussianRainbowZenSwap);

            Bitmap imgGaussianSwap = lc.swapFilter(control);
            imgGaussianSwap = lc.gaussianEdge(imgGaussianSwap);

            Bitmap imgGaussianZenSwap = lc.zenFilter(control, 1, 10, 1, 1);
            imgGaussianZenSwap = lc.swapFilter(imgGaussianZenSwap);
            imgGaussianZenSwap = lc.gaussianEdge(imgGaussianZenSwap);

            Bitmap imgPrewittRainbowSwap = lc.rainbowFilter(control);
            imgPrewittRainbowSwap = lc.swapFilter(imgPrewittRainbowSwap);
            imgPrewittRainbowSwap = lc.prewittEdge(imgPrewittRainbowSwap);

            Bitmap imgPrewittRainbowZenSwap = lc.rainbowFilter(control);
            imgPrewittRainbowZenSwap = lc.zenFilter(imgPrewittRainbowZenSwap, 1, 10, 1, 1);
            imgPrewittRainbowZenSwap = lc.swapFilter(imgPrewittRainbowZenSwap);
            imgPrewittRainbowZenSwap = lc.prewittEdge(imgPrewittRainbowZenSwap);

            Bitmap imgPrewittSwap = lc.swapFilter(control);
            imgPrewittSwap = lc.prewittEdge(imgPrewittSwap);

            Bitmap imgPrewittZenSwap = lc.zenFilter(control, 1, 10, 1, 1);
            imgPrewittZenSwap = lc.swapFilter(imgPrewittZenSwap);
            imgPrewittZenSwap = lc.prewittEdge(imgPrewittZenSwap);

            Bitmap[] imgMatrice = new Bitmap[14] {imgGaussianRainbow, imgGaussianRainbowSwap, imgGaussianRainbowZen,
                                                imgGaussianRainbowZenSwap, imgGaussianSwap, imgGaussianZen,
                                                imgGaussianZenSwap, imgPrewittRainbowSwap, imgPrewittRainbow,
                                                imgPrewittRainbowZen, imgPrewittRainbowZenSwap, imgPrewittSwap,
                                                imgPrewittZen, imgPrewittZenSwap};
            return imgMatrice;
        }

    }
}
