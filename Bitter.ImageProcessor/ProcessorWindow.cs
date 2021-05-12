using Bitter.ImageProcessor.Processors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitter.ImageProcessor
{
    public partial class ProcessorWindow : Form
    {
        public ProcessorWindow()
        {
            
            InitializeComponent();
        }


        private void chooseImgBtn_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog
            {
                Filter = "Image File (*.bmp,*.jpg)|*.bmp;*.jpg"
            };

            if (DialogResult.OK == fileDialog.ShowDialog())
            {
                selectedImagePB.Image = new Bitmap(fileDialog.FileName);

                if (selectedImagePB.Image != null)
                {
                    var grayScaledImg = Processor.GrayScaleUnsafe((Bitmap)selectedImagePB.Image);

                    processedImgPB.Image = grayScaledImg;
                }
            }
        }

        private void saveImgBtn_Click(object sender, EventArgs e)
        {
            var fileDialog = new SaveFileDialog()
            {
                OverwritePrompt = true,
                Filter = "Image File (*.bmp,*.jpg)|*.bmp;*.jpg",
                DefaultExt = ".jpg",
            };

            if(DialogResult.OK == fileDialog.ShowDialog())
            {
                string ext = Path.GetExtension(fileDialog.FileName);
                ImageFormat format = ImageFormat.Jpeg;
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                processedImgPB.Image.Save(fileDialog.FileName, format);
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            //TODO: Needs to change the color schema dynamically!

            //var redScaledImg = Processor.ColorScale((Bitmap)selectedImagePB.Image, (byte)redNumericUD.Value, (byte)greenNumericUD.Value, (byte)blueNumericUD.Value);

            //processedImgPB.Image = redScaledImg;
        }

        private void redColorTB_Scroll(object sender, EventArgs e)
        {
            //Preperation for the color schema changes from RGB Values.
            redNumericUD.Value = redColorTB.Value;
        }

        private void greenColorTB_Scroll(object sender, EventArgs e)
        {
            //Preperation for the color schema changes from RGB Values.
            greenNumericUD.Value = greenColorTB.Value;
        }

        private void blueColorTB_Scroll(object sender, EventArgs e)
        {
            //Preperation for the color schema changes from RGB Values.
            blueNumericUD.Value = blueColorTB.Value;
        }
    }
}
