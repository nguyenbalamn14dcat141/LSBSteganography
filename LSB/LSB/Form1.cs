﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LSB
{
    public partial class Form1 : Form

    {
        OpenFileDialog ofd = new OpenFileDialog();
        SaveFileDialog sft = new SaveFileDialog();
        Bitmap encode_img, decode_img;

        public Form1()
        {
            InitializeComponent();




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Image Files (*.bmp) | *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                encode_img = new Bitmap(ofd.FileName);
                encodeImage1.Image = encode_img;
                encodeInputImage.Text = ofd.FileName;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (encode_img == null || encodeMessage.Text == "")
                return;
            string msg = string.Empty;
            foreach (char ch in encodeMessage.Text)
                msg += Convert.ToString((int)ch, 2).PadLeft(8, '0');
            int z = 0;
            for (int i = 0; i < encode_img.Width; i++)
                for (int j = 0; j < encode_img.Height; j++)
                {
                    Color pxl = encode_img.GetPixel(i, j);
                   
                    encode_img.SetPixel(i, j, Color.FromArgb(change8thbit(pxl.R, msg, ref z), change8thbit(pxl.G, msg, ref z), change8thbit(pxl.B, msg, ref z)));
                }
            encodeImage2.Image = encode_img;
            ofd.Filter = "Image Files (*.bmp) | *.bmp";
            
            if (sft.ShowDialog() == DialogResult.OK)
                encode_img.Save(sft.FileName);

        }

        private void decodeMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private byte change8thbit(byte b, string msg, ref int z)
        {
            string tmp = Convert.ToString(b, 2).PadLeft(8, '0');
            if (z < msg.Length)
            {
                tmp = tmp.Substring(0, 7) + msg.Substring(z, 1);
                z++;
            }
            else
                tmp = tmp.Substring(0, 7) + "0";
            return Convert.ToByte(tmp, 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            ofd.Filter = "Image Files (*.bmp) | *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                decode_img = new Bitmap(ofd.FileName);
                decodeImage.Image = decode_img;
                decodeMessage.Text = ofd.FileName;
                
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (decode_img == null)
                return;
            string result = string.Empty, tmp = string.Empty;
            for (int i = 0; i < decode_img.Width; i++)
                for (int j = 0; j < decode_img.Height; j++)
                {
                    Color pxl = decode_img.GetPixel(i, j);
                    tmp += get8thbit(pxl.R) + get8thbit(pxl.G) + get8thbit(pxl.B);
                    if (tmp.Length >= 8)
                    {
                        string t = tmp.Substring(0, 8);
                        if (t != "00000000")
                            result += Convert.ToChar(Convert.ToByte(t, 2));
                        else
                        {
                            decodeInputImage.Text = result;
                           
                            return;
                        }
                        tmp = tmp.Substring(8, tmp.Length - 8);
                    }
                }
            decodeInputImage.Text = result;
          

        }

        private string get8thbit(byte b)
        {
            return Convert.ToString(b, 2).PadLeft(8, '0').Substring(7, 1);
        }
    }
}
