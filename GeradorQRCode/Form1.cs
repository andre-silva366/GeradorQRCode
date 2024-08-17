using QRCoder;
using System.Drawing;

namespace GeradorQRCode;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void buttonGerarQRCode_Click(object sender, EventArgs e)
    {
        string url = textBoxURL.Text;

        if (string.IsNullOrEmpty(url))
        {
            labelMensagem.Text = "Invalid input.";
        }
        else
        {
            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);

            var qrCode = new BitmapByteQRCode(qrCodeData);
            var qrCodeImage = qrCode.GetGraphic(pixelsPerModule: 20);

            using var ms = new MemoryStream(qrCodeImage);

            using (var imgFromStream = Image.FromStream(ms))
            {
                SaveFileDialog saveFileDialogQRCode = new SaveFileDialog();
                saveFileDialogQRCode.Filter = "PNG Image|*.png";
                saveFileDialogQRCode.Title = "Save QR Code";
                saveFileDialogQRCode.FileName = "qrcode.png";

                if (saveFileDialogQRCode.ShowDialog() == DialogResult.OK)
                {
                    imgFromStream.Save(saveFileDialogQRCode.FileName);
                    labelMensagem.Text = "QR Code saved.";


                }

                Image imagemOriginal = Image.FromFile(saveFileDialogQRCode.FileName);

                int largura = 400;
                int altura = 400;

                Image imagemRedimensionada = RedimensionarImagem(imagemOriginal, altura, largura);

                pictureBoxQRCode.Image = imagemRedimensionada;
                pictureBoxQRCode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }


    }

    private Image RedimensionarImagem(Image imagemOriginal, int altura, int largura)
    {
        Bitmap imagemRedimensionada = new Bitmap(largura, altura);

        using (Graphics g = Graphics.FromImage(imagemRedimensionada))
        {
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            g.DrawImage(imagemOriginal, 0, 0, largura, altura);
        }

        return imagemRedimensionada;
    }

    private void buttonLimpar_Click(object sender, EventArgs e)
    {
        textBoxURL.Text = string.Empty;
        labelMensagem.Text = "Your QR Code appears below";
        pictureBoxQRCode.Image = null;
    }

}
