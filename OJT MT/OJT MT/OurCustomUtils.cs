using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OJT_MT
{
    public static class OurCustomUtils
    {
        

            //ganito lang gamitin pre
            //PictureBox varnamenagustomo = HidePasswordEyeIcon.CreatePasswordEye(textBoxPassword);
            //kung gusto mo default values na sinet ko tapos baka gusto mo ma call yung icon sa code ilagay mo sa var
            //tas yung sa parameters lagay mo lang kung saang textbox mo siya gusto i attach, this case sa textBoxPassword sakin



            //pwede rin ganito kung gusto mo lang lagyan yung textBox ng show/hide kahit wag mo na store sa variable if di mo naman need
            //HidePasswordEyeIcon.CreatePasswordEye(textBoxPassword, size: new Size(1000, 1000), iconPwShown: Properties.Resources.eye, iconPwHidden: Properties.Resources.eye_crossed);
            //Optional lang yang ibagn parameters if gusto mo lang mag set ng custom size at icons if gusto mo itguma sa textbox mo
        public static PictureBox CreatePasswordEye(TextBox textBox,Size size = default, Image? iconPwShown = default, Image? iconPwHidden = default)
        {
            //set default values
            size = size == default ? new Size(20, 100) : size;
            iconPwShown = iconPwShown ?? Properties.Resources.eye;
            iconPwHidden = iconPwHidden ?? Properties.Resources.eye_crossed;
            //yung default is naka hide yung password so tatago
            PictureBox pictureBox = new PictureBox
            {
                Dock = DockStyle.Right,
                Size = size,
                BackColor = Color.Transparent,
                Image = iconPwHidden,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Padding = new Padding(1),
                Visible = false //hide picturebox because visibility will be handled by textchanged event of the textbox                
            };
            //add the picturebox to the textbox
            textBox.Controls.Add(pictureBox);
            //setup textchanged event for textbox, change visibility of eye icon if text is empty or not
            textBox.TextChanged += (sender, e) =>
            {
                pictureBox.Visible = !string.IsNullOrWhiteSpace(textBox.Text);
            };
            ToolTip toolTip = new ToolTip();
            string toolTipText = "Show Password"; //default tooltip text
            toolTip.SetToolTip(pictureBox, toolTipText);
            //setup click event for picturebox
            pictureBox.Click += (sender, e) =>
            {   //Logic here is just to swap between normal eye vs crossed eye, show and hide password, and tooltip message
                textBox.UseSystemPasswordChar = !textBox.UseSystemPasswordChar; //invert true/false
                pictureBox.Image = textBox.UseSystemPasswordChar ? iconPwHidden : iconPwShown;
                toolTipText = textBox.UseSystemPasswordChar ? "Show Password" : "Hide Password";
                toolTip.SetToolTip(pictureBox, toolTipText);
            };
            //Change to cursor to click hand event when hovering over the picturebox (eye) set to default when unhovering
            pictureBox.MouseEnter += (s, e) => pictureBox.Cursor = Cursors.Hand;
            pictureBox.MouseLeave += (s, e) => pictureBox.Cursor = Cursors.Default;
            return pictureBox;
        }


        public static string MaskEmail(string email)
        {
            //Split the email into local part/username and domain part with @ symb being the split indicator
            var parts = email.Split('@');
            if (parts.Length != 2)
            {
                throw new ArgumentException("Invalid email address.");
            }

            string localPart = parts[0]; //The first part before the @ ex. [Paul]@gmail.com
            string domainPart = parts[1]; //Domain part after the @ ex. Paul.@[gmail.com]

            //Mask the local part/username i chose to only show the first 3 characters
            if (localPart.Length > 3)
            {
                localPart = localPart.Substring(0, 3) + new string('*', localPart.Length - 3);
            }

            //Mask the domain part
            if (domainPart.Length > 3)
            {
                var domainParts = domainPart.Split('.'); //split from the .
                if (domainParts.Length > 0)
                {
                    //Mask the first part of the domain (subdomain)
                    var maskedDomain = domainParts[0][0] + new string('*', domainParts[0].Length - 1);
                    //Rebuild the domain part
                    string maskedDomainPart = maskedDomain;
                    for (int i = 1; i < domainParts.Length; i++)
                    {
                        maskedDomainPart += "." + domainParts[i];
                    }
                    domainPart = maskedDomainPart;
                }
            }
            //Combine the masked parts back
            return $"{localPart}@{domainPart}";
        }

        private static readonly Regex EmailRegex = new Regex(@"^([A-Z0-9_+-]+\.?)*[A-Z0-9_+-]@([A-Z0-9][A-Z0-9-]*\.)+[A-Z]{2,}$",RegexOptions.IgnoreCase);
        //Dito ko lang kinuha regex -> https://colinhacks.com/essays/reasonable-email-regex
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }
            return EmailRegex.IsMatch(email);
        }




        private static Color HexToColor(string hex)
        {
            return ColorTranslator.FromHtml(hex);
        }

        public static Bitmap RecolorImage(Image original, string hexColor)
        {
            Color color = HexToColor(hexColor);
            ColorMatrix colorMatrix = new ColorMatrix(new float[][]
            {
            new float[] { 0, 0, 0, 0, 0 },
            new float[] { 0, 0, 0, 0, 0 },
            new float[] { 0, 0, 0, 0, 0 },
            new float[] { 0, 0, 0, 1, 0 },
            new float[] { color.R / 255f, color.G / 255f, color.B / 255f, 0, 1 }
            });

            Bitmap newImage = new Bitmap(original.Width, original.Height);
            using (Graphics g = Graphics.FromImage(newImage))
            {
                using (ImageAttributes attributes = new ImageAttributes())
                {
                    attributes.SetColorMatrix(colorMatrix);
                    g.DrawImage(original, new Rectangle(0, 0, newImage.Width, newImage.Height),
                                0, 0, original.Width, original.Height,
                                GraphicsUnit.Pixel, attributes);
                }
            }

            return newImage;
        }


    }
}
