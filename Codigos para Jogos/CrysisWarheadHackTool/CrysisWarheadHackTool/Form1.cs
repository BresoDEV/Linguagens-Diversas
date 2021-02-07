using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MetroFramework;
using MetroFramework.Forms;
using System.Diagnostics;
using System.ComponentModel;

namespace CrysisWarheadHackTool
{



    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }


        //variaveis
        int Tempo = 0;

         //-------------------------VOIDS----------------------

        private void Criar_pasta(string diretorio)
        {
            Directory.CreateDirectory(diretorio);
        }

        private void Copiar_Arquivo(string LocalAtual, string LocalDestino)
        {
            File.Copy(LocalAtual, LocalDestino);
        }

        private bool Ver_se_arquivo_existe(string Arquivo)
        {
            if (File.Exists(Arquivo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Apagar_arquivo(string Arquivo)
        {
            if (Ver_se_arquivo_existe(Arquivo))
            {
                File.Delete(Arquivo);
            }

        }
       
        public static bool CheckDiretorio()
        {
            if (System.IO.File.Exists("Game/config/diff_bauer.cfg"))
            {
                if (System.IO.File.Exists("Game/config/diff_easy.cfg"))
                {
                    if (System.IO.File.Exists("Game/config/diff_hard.cfg"))
                    {
                        if (System.IO.File.Exists("Game/config/diff_normal.cfg"))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool CheckJogRodando()
        {
            Process[] jogo = Process.GetProcessesByName("crysis - dev");
            if (jogo.Length == 0)
            {
                Process[] jogo2 = Process.GetProcessesByName("crysis");
                if (jogo2.Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        //-----------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!CheckDiretorio())
            { 
                MessageBox.Show("Diretorio Invalido" + System.Environment.NewLine + "Por favor, verifique se o programa esta na pasta raiz do jogo e tente novamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Seja bem vindo ao Crysis Warhead Hack" + Environment.NewLine + "Para evitar que o jogo seja danificado, clique em CRIAR BACKUP antes de comecar a editar, caso de algo errado, voce pode reparar o game");
                saveFileDialog1.DefaultExt = ".cfg";
                saveFileDialog1.InitialDirectory = "Game/Nova Pasta";
            }

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
           

            Criar_pasta("Game/files");
            if (Ver_se_arquivo_existe("Game/files/diff_bauer.cfg"))
            {
                MessageBox.Show("Ja existe um backup criado");
            }
            else
            {
                timer1.Enabled = true;
            }
            
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Apagar_arquivo("Game/files/diff_easy.cfg");
            Apagar_arquivo("Game/files/diff_bauer.cfg");
            Apagar_arquivo("Game/files/diff_normal.cfg");
            Apagar_arquivo("Game/files/diff_hard.cfg");
            MessageBox.Show("Backup apagado com sucesso");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Tempo == 100)
            {
                Tempo = 0;
                progressBar1.Value = Tempo;
                timer1.Enabled = false;

                if (Ver_se_arquivo_existe("Game/config/diff_bauer.cfg"))
                {
                    Copiar_Arquivo("Game/config/diff_bauer.cfg", "Game/files/diff_bauer.cfg");
                }
                if (Ver_se_arquivo_existe("Game/config/diff_easy.cfg"))
                {
                    Copiar_Arquivo("Game/config/diff_bauer.cfg", "Game/files/diff_easy.cfg");
                }
                if (Ver_se_arquivo_existe("Game/config/diff_hard.cfg"))
                {
                    Copiar_Arquivo("Game/config/diff_bauer.cfg", "Game/files/diff_hard.cfg");
                }
                if (Ver_se_arquivo_existe("Game/config/diff_normal.cfg"))
                {
                    Copiar_Arquivo("Game/config/diff_bauer.cfg", "Game/files/diff_normal.cfg");
                }
                MessageBox.Show("Backup criado com sucesso");
            }
            else
            {
                Tempo++;
                progressBar1.Value = Tempo;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {


            Apagar_arquivo("Game/config/diff_easy.cfg");
            Apagar_arquivo("Game/config/diff_normal.cfg");
            Apagar_arquivo("Game/config/diff_hard.cfg");
            Apagar_arquivo("Game/config/diff_bauer.cfg");


            textBox3.Text = "-- EASY" + Environment.NewLine + "con_restricted" + Environment.NewLine;
            if(ImortalCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "g_godMode = 1" + Environment.NewLine;
            }
            //----------------------------
            if (VidaCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "g_playerSuitHealthRegenTime = 0" + Environment.NewLine + "g_playerSuitHealthRegenTimeMoving = 0" + Environment.NewLine + "g_playerSuitHealthRegenDelay = 0" + Environment.NewLine + "g_playerSuitArmorModeHealthRegenTime = 0" + Environment.NewLine + "g_playerSuitArmorModeHealthRegenTimeMoving = 0" + Environment.NewLine;
            }
            else
            {
                textBox2.Text = textBox2.Text + "g_playerSuitHealthRegenTime = 20" + Environment.NewLine + "g_playerSuitHealthRegenTimeMoving = 27" + Environment.NewLine + "g_playerSuitHealthRegenDelay = 2.5" + Environment.NewLine + "g_playerSuitArmorModeHealthRegenTime = 10" + Environment.NewLine + "g_playerSuitArmorModeHealthRegenTimeMoving = 15" + Environment.NewLine;
            }

            //-----------------------------------------------------------

            if (MunicaoCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "i_unlimitedammo = 1" + Environment.NewLine;
            }
            else
            {
                textBox2.Text = textBox2.Text + "i_unlimitedammo = 0" + Environment.NewLine;
            }

            //-----------------------------------------------------------

            if (InimigosCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "ai_IgnorePlayer = 1" + Environment.NewLine;
            }
            else
            {
                textBox2.Text = textBox2.Text + "ai_IgnorePlayer = 0" + Environment.NewLine;
            }

            //-----------------------------------------------------------

            if (SemLimiteCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "i_noweaponlimit = 1" + Environment.NewLine;
            }
            else
            {
                textBox2.Text = textBox2.Text + "i_noweaponlimit = 0" + Environment.NewLine;
            }


            //-----------------------------------------------------------

            if (EnergiaCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "g_suitCloakEnergyDrainAdjuster = 0" + Environment.NewLine + "g_suitRecoilEnergyCost = 0" + Environment.NewLine + "g_playerSuitEnergyRechargeTimeArmor = 0" + Environment.NewLine + "g_playerSuitEnergyRechargeTimeArmorMoving = 0" + Environment.NewLine + "g_playerSuitEnergyRechargeTime = 0" + Environment.NewLine + "g_playerSuitEnergyRechargeDelay = 0.0" + Environment.NewLine;
            }
            else
            {
                textBox2.Text = textBox2.Text + "g_suitCloakEnergyDrainAdjuster = 1" + Environment.NewLine + "g_suitRecoilEnergyCost = 7" + Environment.NewLine + "g_playerSuitEnergyRechargeTimeArmor = 6" + Environment.NewLine + "g_playerSuitEnergyRechargeTimeArmorMoving = 7" + Environment.NewLine + "g_playerSuitEnergyRechargeTime = 8" + Environment.NewLine + "g_playerSuitEnergyRechargeDelay = 1.0" + Environment.NewLine;
            }

            //-----------------------------------------------------------

            if (VisaoCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "hud_nighVisionConsumption = 0" + Environment.NewLine;
            }
            else
            {
                textBox2.Text = textBox2.Text + "hud_nighVisionConsumption = 10" + Environment.NewLine;
            }

            //-----------------------------------------------------------

            if (VelocidadeCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "g_suitSpeedMult = 8.85" + Environment.NewLine;
            }
            else
            {
                textBox2.Text = textBox2.Text + "g_suitSpeedMult = 1.85" + Environment.NewLine;
            }


            textBox4.Text = textBox3.Text + Environment.NewLine + TextoBase.Text + Environment.NewLine + textBox2.Text;

            saveFileDialog1.FileName = "Game/config/diff_easy.cfg";
            FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
            StreamWriter writer = new StreamWriter(fs);
            writer.Write(textBox4.Text);
            writer.Close();



            progressBar1.Value = 34;
            System.Threading.Thread.Sleep(1234);
































            textBox3.Text = "-- HARD" + Environment.NewLine + "con_restricted" + Environment.NewLine;
            if (ImortalCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "g_godMode = 1" + Environment.NewLine;
            }
            //----------------------------
            if (VidaCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "g_playerSuitHealthRegenTime = 0" + Environment.NewLine + "g_playerSuitHealthRegenTimeMoving = 0" + Environment.NewLine + "g_playerSuitHealthRegenDelay = 0" + Environment.NewLine + "g_playerSuitArmorModeHealthRegenTime = 0" + Environment.NewLine + "g_playerSuitArmorModeHealthRegenTimeMoving = 0" + Environment.NewLine;
            }
            else
            {
                textBox2.Text = textBox2.Text + "g_playerSuitHealthRegenTime = 20" + Environment.NewLine + "g_playerSuitHealthRegenTimeMoving = 27" + Environment.NewLine + "g_playerSuitHealthRegenDelay = 2.5" + Environment.NewLine + "g_playerSuitArmorModeHealthRegenTime = 10" + Environment.NewLine + "g_playerSuitArmorModeHealthRegenTimeMoving = 15" + Environment.NewLine;
            }

            //-----------------------------------------------------------

            if (MunicaoCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "i_unlimitedammo = 1" + Environment.NewLine;
            }
            else
            {
                textBox2.Text = textBox2.Text + "i_unlimitedammo = 0" + Environment.NewLine;
            }

            //-----------------------------------------------------------

            if (InimigosCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "ai_IgnorePlayer = 1" + Environment.NewLine;
            }
            else
            {
                textBox2.Text = textBox2.Text + "ai_IgnorePlayer = 0" + Environment.NewLine;
            }

            //-----------------------------------------------------------

            if (SemLimiteCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "i_noweaponlimit = 1" + Environment.NewLine;
            }
            else
            {
                textBox2.Text = textBox2.Text + "i_noweaponlimit = 0" + Environment.NewLine;
            }


            //-----------------------------------------------------------

            if (EnergiaCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "g_suitCloakEnergyDrainAdjuster = 0" + Environment.NewLine + "g_suitRecoilEnergyCost = 0" + Environment.NewLine + "g_playerSuitEnergyRechargeTimeArmor = 0" + Environment.NewLine + "g_playerSuitEnergyRechargeTimeArmorMoving = 0" + Environment.NewLine + "g_playerSuitEnergyRechargeTime = 0" + Environment.NewLine + "g_playerSuitEnergyRechargeDelay = 0.0" + Environment.NewLine;
            }
            else
            {
                textBox2.Text = textBox2.Text + "g_suitCloakEnergyDrainAdjuster = 1" + Environment.NewLine + "g_suitRecoilEnergyCost = 7" + Environment.NewLine + "g_playerSuitEnergyRechargeTimeArmor = 6" + Environment.NewLine + "g_playerSuitEnergyRechargeTimeArmorMoving = 7" + Environment.NewLine + "g_playerSuitEnergyRechargeTime = 8" + Environment.NewLine + "g_playerSuitEnergyRechargeDelay = 1.0" + Environment.NewLine;
            }

            //-----------------------------------------------------------

            if (VisaoCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "hud_nighVisionConsumption = 0" + Environment.NewLine;
            }
            else
            {
                textBox2.Text = textBox2.Text + "hud_nighVisionConsumption = 10" + Environment.NewLine;
            }

            //-----------------------------------------------------------

            if (VelocidadeCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "g_suitSpeedMult = 8.85" + Environment.NewLine;
            }
            else
            {
                textBox2.Text = textBox2.Text + "g_suitSpeedMult = 1.85" + Environment.NewLine;
            }


            textBox4.Text = textBox3.Text + Environment.NewLine + TextoBase.Text + Environment.NewLine + textBox2.Text;

            saveFileDialog1.FileName = "Game/config/diff_hard.cfg";
            FileStream fs2 = new FileStream(saveFileDialog1.FileName, FileMode.Create);
            StreamWriter writer2 = new StreamWriter(fs2);
            writer2.Write(textBox4.Text);
            writer2.Close();








            progressBar1.Value = 74;
            System.Threading.Thread.Sleep(1234);




















            textBox3.Text = "-- NORMAL" + Environment.NewLine + "con_restricted" + Environment.NewLine;
            if (ImortalCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "g_godMode = 1" + Environment.NewLine;
            }
            //----------------------------
            if (VidaCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "g_playerSuitHealthRegenTime = 0" + Environment.NewLine + "g_playerSuitHealthRegenTimeMoving = 0" + Environment.NewLine + "g_playerSuitHealthRegenDelay = 0" + Environment.NewLine + "g_playerSuitArmorModeHealthRegenTime = 0" + Environment.NewLine + "g_playerSuitArmorModeHealthRegenTimeMoving = 0" + Environment.NewLine;
            }
            else
            {
                textBox2.Text = textBox2.Text + "g_playerSuitHealthRegenTime = 20" + Environment.NewLine + "g_playerSuitHealthRegenTimeMoving = 27" + Environment.NewLine + "g_playerSuitHealthRegenDelay = 2.5" + Environment.NewLine + "g_playerSuitArmorModeHealthRegenTime = 10" + Environment.NewLine + "g_playerSuitArmorModeHealthRegenTimeMoving = 15" + Environment.NewLine;
            }

            //-----------------------------------------------------------

            if (MunicaoCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "i_unlimitedammo = 1" + Environment.NewLine;
            }
            else
            {
                textBox2.Text = textBox2.Text + "i_unlimitedammo = 0" + Environment.NewLine;
            }

            //-----------------------------------------------------------

            if (InimigosCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "ai_IgnorePlayer = 1" + Environment.NewLine;
            }
            else
            {
                textBox2.Text = textBox2.Text + "ai_IgnorePlayer = 0" + Environment.NewLine;
            }

            //-----------------------------------------------------------

            if (SemLimiteCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "i_noweaponlimit = 1" + Environment.NewLine;
            }
            else
            {
                textBox2.Text = textBox2.Text + "i_noweaponlimit = 0" + Environment.NewLine;
            }


            //-----------------------------------------------------------

            if (EnergiaCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "g_suitCloakEnergyDrainAdjuster = 0" + Environment.NewLine + "g_suitRecoilEnergyCost = 0" + Environment.NewLine + "g_playerSuitEnergyRechargeTimeArmor = 0" + Environment.NewLine + "g_playerSuitEnergyRechargeTimeArmorMoving = 0" + Environment.NewLine + "g_playerSuitEnergyRechargeTime = 0" + Environment.NewLine + "g_playerSuitEnergyRechargeDelay = 0.0" + Environment.NewLine;
            }
            else
            {
                textBox2.Text = textBox2.Text + "g_suitCloakEnergyDrainAdjuster = 1" + Environment.NewLine + "g_suitRecoilEnergyCost = 7" + Environment.NewLine + "g_playerSuitEnergyRechargeTimeArmor = 6" + Environment.NewLine + "g_playerSuitEnergyRechargeTimeArmorMoving = 7" + Environment.NewLine + "g_playerSuitEnergyRechargeTime = 8" + Environment.NewLine + "g_playerSuitEnergyRechargeDelay = 1.0" + Environment.NewLine;
            }

            //-----------------------------------------------------------

            if (VisaoCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "hud_nighVisionConsumption = 0" + Environment.NewLine;
            }
            else
            {
                textBox2.Text = textBox2.Text + "hud_nighVisionConsumption = 10" + Environment.NewLine;
            }

            //-----------------------------------------------------------

            if (VelocidadeCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "g_suitSpeedMult = 8.85" + Environment.NewLine;
            }
            else
            {
                textBox2.Text = textBox2.Text + "g_suitSpeedMult = 1.85" + Environment.NewLine;
            }


            textBox4.Text = textBox3.Text + Environment.NewLine + TextoBase.Text + Environment.NewLine + textBox2.Text;

            saveFileDialog1.FileName = "Game/config/diff_normal.cfg";
            FileStream fs3 = new FileStream(saveFileDialog1.FileName, FileMode.Create);
            StreamWriter writer3 = new StreamWriter(fs3);
            writer3.Write(textBox4.Text);
            writer3.Close();

            progressBar1.Value = 84;
            System.Threading.Thread.Sleep(1234);























            textBox3.Text = "-- BAUER" + Environment.NewLine + "con_restricted" + Environment.NewLine;
            if (ImortalCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "g_godMode = 1" + Environment.NewLine;
            }
            //----------------------------
            if (VidaCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "g_playerSuitHealthRegenTime = 0" + Environment.NewLine + "g_playerSuitHealthRegenTimeMoving = 0" + Environment.NewLine + "g_playerSuitHealthRegenDelay = 0" + Environment.NewLine + "g_playerSuitArmorModeHealthRegenTime = 0" + Environment.NewLine + "g_playerSuitArmorModeHealthRegenTimeMoving = 0" + Environment.NewLine;
            }
            else
            {
                textBox2.Text = textBox2.Text + "g_playerSuitHealthRegenTime = 20" + Environment.NewLine + "g_playerSuitHealthRegenTimeMoving = 27" + Environment.NewLine + "g_playerSuitHealthRegenDelay = 2.5" + Environment.NewLine + "g_playerSuitArmorModeHealthRegenTime = 10" + Environment.NewLine + "g_playerSuitArmorModeHealthRegenTimeMoving = 15" + Environment.NewLine;
            }

            //-----------------------------------------------------------

            if (MunicaoCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "i_unlimitedammo = 1" + Environment.NewLine;
            }
            else
            {
                textBox2.Text = textBox2.Text + "i_unlimitedammo = 0" + Environment.NewLine;
            }

            //-----------------------------------------------------------

            if (InimigosCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "ai_IgnorePlayer = 1" + Environment.NewLine;
            }
            else
            {
                textBox2.Text = textBox2.Text + "ai_IgnorePlayer = 0" + Environment.NewLine;
            }

            //-----------------------------------------------------------

            if (SemLimiteCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "i_noweaponlimit = 1" + Environment.NewLine;
            }
            else
            {
                textBox2.Text = textBox2.Text + "i_noweaponlimit = 0" + Environment.NewLine;
            }


            //-----------------------------------------------------------

            if (EnergiaCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "g_suitCloakEnergyDrainAdjuster = 0" + Environment.NewLine + "g_suitRecoilEnergyCost = 0" + Environment.NewLine + "g_playerSuitEnergyRechargeTimeArmor = 0" + Environment.NewLine + "g_playerSuitEnergyRechargeTimeArmorMoving = 0" + Environment.NewLine + "g_playerSuitEnergyRechargeTime = 0" + Environment.NewLine + "g_playerSuitEnergyRechargeDelay = 0.0" + Environment.NewLine;
            }
            else
            {
                textBox2.Text = textBox2.Text + "g_suitCloakEnergyDrainAdjuster = 1" + Environment.NewLine + "g_suitRecoilEnergyCost = 7" + Environment.NewLine + "g_playerSuitEnergyRechargeTimeArmor = 6" + Environment.NewLine + "g_playerSuitEnergyRechargeTimeArmorMoving = 7" + Environment.NewLine + "g_playerSuitEnergyRechargeTime = 8" + Environment.NewLine + "g_playerSuitEnergyRechargeDelay = 1.0" + Environment.NewLine;
            }

            //-----------------------------------------------------------

            if (VisaoCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "hud_nighVisionConsumption = 0" + Environment.NewLine;
            }
            else
            {
                textBox2.Text = textBox2.Text + "hud_nighVisionConsumption = 10" + Environment.NewLine;
            }

            //-----------------------------------------------------------

            if (VelocidadeCheck.Checked)
            {
                textBox2.Text = textBox2.Text + "g_suitSpeedMult = 8.85" + Environment.NewLine;
            }
            else
            {
                textBox2.Text = textBox2.Text + "g_suitSpeedMult = 1.85" + Environment.NewLine;
            }


            textBox4.Text = textBox3.Text + Environment.NewLine + TextoBase.Text + Environment.NewLine + textBox2.Text;

            saveFileDialog1.FileName = "Game/config/diff_bauer.cfg";
            FileStream fs4 = new FileStream(saveFileDialog1.FileName, FileMode.Create);
            StreamWriter writer4 = new StreamWriter(fs4);
            writer4.Write(textBox4.Text);
            writer4.Close();

            

            progressBar1.Value = 90;
            System.Threading.Thread.Sleep(1234);
            progressBar1.Value = 0;
            MessageBox.Show("Alteracoes aplicadas ao jogo com sucesso");

             
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Criar_pasta("Game/files");
            if (Ver_se_arquivo_existe("Game/files/diff_bauer.cfg"))
            {

                Apagar_arquivo("Game/config/diff_bauer.cfg");
                Apagar_arquivo("Game/config/diff_easy.cfg");
                Apagar_arquivo("Game/config/diff_hard.cfg");
                Apagar_arquivo("Game/config/diff_normal.cfg");
                timer2.Enabled = true;
            }
            else
            { 
                MessageBox.Show("Nao existe nenhum backup criado");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Tempo == 100)
            {
                Tempo = 0;
                progressBar1.Value = Tempo;
                timer2.Enabled = false;

                Copiar_Arquivo("Game/files/diff_bauer.cfg", "Game/config/diff_bauer.cfg");
                Copiar_Arquivo("Game/files/diff_easy.cfg", "Game/config/diff_easy.cfg");
                Copiar_Arquivo("Game/files/diff_hard.cfg", "Game/config/diff_hard.cfg");
                Copiar_Arquivo("Game/files/diff_normal.cfg", "Game/config/diff_normal.cfg"); 
                
                MessageBox.Show("Backup criado com sucesso");
            }
            else
            {
                Tempo++;
                progressBar1.Value = Tempo;
            }
        }
    }
}
