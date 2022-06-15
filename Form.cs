﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupervisorFuzzyMicro
{
    public partial class Form : System.Windows.Forms.Form
    {
        Monitoramento monitoramento = new Monitoramento();
        public Form()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            
            if (!portaSerial.IsOpen)
            {
                portaSerial.Open();
                MessageBox.Show("Rodando");
            }            
            //MessageBox.Show(charPic.ToString());
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (portaSerial.IsOpen)
            {
                portaSerial.Write("1");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (portaSerial.IsOpen)
            {
                portaSerial.Write("2");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (portaSerial.IsOpen)
            {
                portaSerial.Write("3");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (portaSerial.IsOpen)
            {
                portaSerial.Write("4");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (portaSerial.IsOpen)
            {
                portaSerial.Write("5");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (portaSerial.IsOpen)
            {
                portaSerial.Write("6");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (portaSerial.IsOpen)
            {
                portaSerial.Write("7");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (portaSerial.IsOpen)
            {
                portaSerial.Write("8");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (portaSerial.IsOpen)
            {
                portaSerial.Write("9");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (portaSerial.IsOpen)
            {
                portaSerial.Write("0");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            portaSerial.Write("0");
            if (portaSerial.IsOpen)
            {
                portaSerial.Close();
                MessageBox.Show("Encerrada");
            }
        }

        private void btnMon_Click(object sender, EventArgs e)
        {
            monitoramento.abrePorta(portaSerial);
            // dispara uma nova thread para executar
            Thread t = new Thread(printaLista);
            t.Start();
        }

        private void printaLista()
        {
            while (portaSerial.IsOpen)
            {
                listaDadosPic.Items.Add(monitoramento.leitura());                
                Thread.Sleep(2000);
            }
        }
    }
}
