using ImageEdgeDetection.IOFiles;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NSubstitute;
using ImageEdgeDetection.Dialogs;
using System.IO;
using ImageEdgeDetection.Business;

namespace TestImageEdgeDetection
{
    [TestClass]
    public class TestReadWriteController
    {
        //Unit test exception for reading image
        [TestMethod]
        public void TestReadException()
        {
            var ofd = Substitute.For<IOFD>();
            ofd.ShowDialog().Returns(x => { throw new Exception(); });

            IReadWriteController readWriteController = new ReadWriteController();
            ILogicController logicController = new LogicController(readWriteController);

            Assert.ThrowsException<Exception>(() => logicController.readImage(ofd));
        }

        [TestMethod]
        public void read()
        {
            //substitute our open file dialog with our own parameters in order to "trick" windows into not opening the dialog box

            var ofd = Substitute.For<IOFD>();
            string FileName = "../../imagesForTesting/testImg.png";
            ofd.FileName = FileName;

            ofd.ShowDialog().Returns(DialogResult.OK);

            IReadWriteController readWriteController = new ReadWriteController();
            ILogicController logicController = new LogicController(readWriteController);

            Bitmap resultImage = logicController.readImage(ofd);

            Bitmap testImage = new Bitmap("../../imagesForTesting/testImg.png");

            //compare our test image with the image we've just loaded
            compareTwoImages(resultImage, testImage);
        }

        [TestMethod]
        public void write()
        {
            //substitute our save file dialog with our own parameters in order to "trick" windows into not opening the dialog box
            Bitmap testImage = new Bitmap("../../imagesForTesting/testImg.png");

            var sfd = Substitute.For<ISFD>();
            string FileName = "../../imagesForTesting/testImgUNITTEST.png";

            sfd.FileName = FileName;

            sfd.ShowDialog().Returns(DialogResult.OK);

            IReadWriteController readWriteController = new ReadWriteController();
            ILogicController logicController = new LogicController(readWriteController);

            //creates an image in our folder with the name "testImgUNITTEST"
            logicController.writeImage(sfd, testImage);
            
            Bitmap resultImage = new Bitmap("../../imagesForTesting/testImgUNITTEST.png");

            //verify the image has been created
            Assert.IsNotNull(resultImage);

            resultImage.Dispose();
            testImage.Dispose();

            //destroy the created image
            File.Delete(FileName);

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
    }
}
